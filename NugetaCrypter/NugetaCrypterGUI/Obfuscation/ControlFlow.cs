using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetaCrypterGUI.Obfuscation
{
    internal class ControlFlow
    {
    }
    public class Block
    {
        public Block()
        {
            Instructions = new List<Instruction>();
        }

        public List<Instruction> Instructions { get; set; }

        public int Number { get; set; }
    }


    public class BlockParser
    {
        public static List<Block> ParseMethod(MethodDef meth)
        {
            var blocks = new List<Block>();
            var block = new Block();
            var id = 0;
            var usage = 0;
            block.Number = id;
            block.Instructions.Add(Instruction.Create(OpCodes.Nop));
            blocks.Add(block);
            block = new Block();
            var handlers = new Stack<ExceptionHandler>();
            foreach (var instruction in meth.Body.Instructions)
            {
                foreach (var eh in meth.Body.ExceptionHandlers)
                {
                    if (eh.HandlerStart == instruction || eh.TryStart == instruction || eh.FilterStart == instruction)
                        handlers.Push(eh);
                }
                foreach (var eh in meth.Body.ExceptionHandlers)
                {
                    if (eh.HandlerEnd == instruction || eh.TryEnd == instruction)
                        handlers.Pop();
                }

                instruction.CalculateStackUsage(out var stacks, out var pops);
                block.Instructions.Add(instruction);
                usage += stacks - pops;
                if (stacks == 0)
                {
                    if (instruction.OpCode != OpCodes.Nop)
                    {
                        if ((usage == 0 || instruction.OpCode == OpCodes.Ret) && handlers.Count == 0)
                        {
                            block.Number = ++id;
                            blocks.Add(block);
                            block = new Block();
                        }
                    }
                }
            }
            return blocks;
        }
    }

    internal class ControlFlowObfuscation
    {
        public static void Execute(ModuleDefMD md)
        {
            foreach (var type in md.Types)
            {
                if (type == md.GlobalType) continue;
                foreach (var meth in type.Methods)
                {
                    if (meth.Name.StartsWith("get_") || meth.Name.StartsWith("set_")) continue;
                    if (!meth.HasBody || meth.IsConstructor) continue;
                    meth.Body.SimplifyBranches();
                    ExecuteMethod(meth);
                }
            }
        }

        private static void ExecuteMethod(MethodDef meth)
        {
            meth.Body.SimplifyMacros(meth.Parameters);
            var blocks = BlockParser.ParseMethod(meth);
            blocks = Randomize(blocks);
            meth.Body.Instructions.Clear();
            var local = new Local(meth.Module.CorLibTypes.Int32);
            meth.Body.Variables.Add(local);
            var target = Instruction.Create(OpCodes.Nop);
            var instr = Instruction.Create(OpCodes.Br, target);
            foreach (var instruction in Calc(0))
                meth.Body.Instructions.Add(instruction);
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Br, instr));
            meth.Body.Instructions.Add(target);
            foreach (var block in blocks.Where(block => block != blocks.Single(x => x.Number == blocks.Count - 1)))
            {
                meth.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
                foreach (var instruction in Calc(block.Number))
                    meth.Body.Instructions.Add(instruction);
                meth.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
                var instruction4 = Instruction.Create(OpCodes.Nop);
                meth.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction4));

                foreach (var instruction in block.Instructions)
                    meth.Body.Instructions.Add(instruction);

                foreach (var instruction in Calc(block.Number + 1))
                    meth.Body.Instructions.Add(instruction);

                meth.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
                meth.Body.Instructions.Add(instruction4);
            }
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
            foreach (var instruction in Calc(blocks.Count - 1))
                meth.Body.Instructions.Add(instruction);
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instr));
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Br, blocks.Single(x => x.Number == blocks.Count - 1).Instructions[0]));
            meth.Body.Instructions.Add(instr);

            foreach (var lastBlock in blocks.Single(x => x.Number == blocks.Count - 1).Instructions)
                meth.Body.Instructions.Add(lastBlock);
        }

        private static readonly Random Rnd = new Random();

        private static List<Block> Randomize(List<Block> input)
        {
            var ret = new List<Block>();
            foreach (var group in input)
                ret.Insert(Rnd.Next(0, ret.Count), group);
            return ret;
        }

        private static List<Instruction> Calc(int value)
        {
            var instructions = new List<Instruction> { Instruction.Create(OpCodes.Ldc_I4, value) };
            return instructions;
        }

        public void AddJump(IList<Instruction> instrs, Instruction target)
        {
            instrs.Add(Instruction.Create(OpCodes.Br, target));
        }
    }

    public static class JumpCFlow
    {
        public static void Execute(ModuleDefMD module)
        {
            foreach (var type in module.Types)
            {
                foreach (var meth in type.Methods.ToArray())
                {
                    if (!meth.HasBody || !meth.Body.HasInstructions || meth.Body.HasExceptionHandlers) continue;
                    for (var i = 0; i < meth.Body.Instructions.Count - 2; i++)
                    {
                        var inst = meth.Body.Instructions[i + 1];
                        meth.Body.Instructions.Insert(i + 1, Instruction.Create(OpCodes.Ldstr, RenamerPhase.GenerateString(RenamerPhase.RenameMode.Ascii)));
                        meth.Body.Instructions.Insert(i + 1, Instruction.Create(OpCodes.Br_S, inst));
                        i += 2;
                    }
                }
            }
        }
    }
}
