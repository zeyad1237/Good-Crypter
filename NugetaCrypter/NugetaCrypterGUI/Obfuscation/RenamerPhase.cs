using dnlib.DotNet.Emit;
using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetaCrypterGUI.Obfuscation
{
    internal class RenamerPhase
    {
        public enum RenameMode
        {
            Ascii,
            Key,
            Normal
        }

        private const string Ascii = "ⒶⒷⒸⒹⒺⒻⒼⒽⒾⒿⓀⓁⓂⓃⓄⓅⓆⓇⓈⓉⓊⓋⓌⓍⓎⓏⓐⓑⓒⓓⓔⓕⓖⓗⓘⓙⓚⓛⓜⓝⓞⓟⓠⓡⓢⓣⓤⓥⓦⓧⓨⓩ⓪①②③④⑤⑥⑦⑧⑨";
        private static readonly Random Random = new Random();

        private static readonly string[] NormalNameStrings =
{
"XZ", "YR", "PL", "TG", "F35", "ZAP",
"GetApplesFOO", "WHY", "WHEN", "Happy", "SLEEPY", "LOST",
"HELLO", "Happy", "BURNED", "HIM", "SAW", "<Initialize>b__13_0", "InitializeLIFE",
"FixBOBOBOte", "StBAB", "checkLALALARestart", "QueuePOPOThread", "QueueTETEThread", "RunMOMOAnc", "RUMBLEACTON",
"Dance", "FixOPOPOdate", "IXOXOWUWri", "GetVAVAVATypes", "GetTypVAVAFwsFromParentClass", "GetTypwMOMOwesFromParentClass",
"GetVAVAVATypesFromInterface", "GetTypesLOLOMAMomInterface", "geTAFAfeout", "setTATADate", "GetILYrequest",
"geWOWID64", "set_LOLID64", "get_HELLOID", "set_WOWID", "getTYTYneState", "setLLState",
"getILOVEMessage", "SLEEPYMessage", "get_HEY", "set_BYEState", "getBYEState",
"set_VAVAGState", "getEGGcon", "set_NEWIcon", "get_CHILLMedium", "set_MELLOMedium",
"gBYEBYEfull", "set_HELLOfull", "getMOMOBOBanned", "set_LOVEganed", "get_OOFage",
"set_CUDDLEState", "getWOWmoment", "set_KISSstate", "geSMILEURL", "seSMILEURL",
"gLULLcute", "sBYEGWAVE", "get_LALALWeeks", "set_SLEEPOWEEKS",
"gHUGGONE", "set_KISSGoodbye", "LEAVEaction", "sLULLABYon", "geCUDDLEName", "seCUDDLEName", "gLOVEmama",
"HUGbaby", "get_MOMOGames", "set_MostPlayedGames", "get_Groups", "set_Groups", "Reload",
"ParseApple", "ParseSun", "ParseEagle", "ParseOcean", "ParseStar", "ParseMoon", "ParseSky",
"ParseFire", "ParseWater", "LoadDefaults", "LoadDefaults", "get_Cats", "Happy", "handleDance",
"FixedDance", "Broadcast", "OnDestroy", "Read", "Send", "<Happy>b__8_0", "get_SmileID", "set_SmileID",
"get_DanceTime", "set_DanceTime", "Send", "Read", "Close", "get_City", "get_Star",
"set_Star", "Save", "Load", "Unload", "Load", "Save", "Load", "get_Settings", "LoadPlugin",
"<.ctor>b__3_0", "<LoadPlugin>b__4_0", "add_OnPluginUnloading", "remove_OnPluginUnloading",
"add_OnPluginLoading", "remove_OnPluginLoading", "get_Translations", "get_State", "get_Assembly",
"set_Assembly", "get_Directory", "set_Directory", "get_Name", "set_Name", "get_PluginData", "set_PluginData", "get_PluginSettings", "set_PluginSettings", "get_IsActive", "set_IsActive",
"get_Version", "set_Version", "get_Description", "set_Description", "get_Author", "set_Author", "get_Website",
"set_Website", "get_Dependencies", "set_Dependencies", "get_LoadOrder", "set_LoadOrder", "get_Priority", "set_Priority",
"get_IsHidden", "set_IsHidden", "get_IsDebug", "set_IsDebug", "get_IsStandalone", "set_IsStandalone",
"get_RequireRestart", "set_RequireRestart", "get_HasUpdate", "set_HasUpdate", "get_UpdateVersion", "set_UpdateVersion",
"get_UpdateURL", "set_UpdateURL", "get_IsCustom", "set_IsCustom", "get_CustomSettings", "set_CustomSettings",
"get_IsDeleted", "set_IsDeleted", "get_DeletedBy", "set_DeletedBy", "get_DeletedDate", "set_DeletedDate",
"get_IsCompatible", "set_IsCompatible", "get_CompatibilityNotes", "set_CompatibilityNotes", "get_HasWarnings",
"set_HasWarnings", "get_Warnings", "set_Warnings", "get_HasErrors", "set_HasErrors", "get_Errors", "set_Errors",
"get_LoadErrors", "set_LoadErrors", "get_EnabledPlugins", "get_DisabledPlugins", "get_AvailablePlugins",
"get_LockedPlugins", "get_PluginCount", "get_HiddenPluginCount", "get_CustomPluginCount", "get_UnloadedPluginCount",
"get_ActivePluginCount", "get_InactivePluginCount", "get_ErrorPluginCount", "get_WarningPluginCount",
"get_PluginWarningCount", "get_LoadWarningCount", "get_PluginErrorCount", "get_LoadErrorCount", "get_PluginUpdateCount",
"get_UpdateablePluginCount", "get_HasUpdateablePlugins", "get_IsUpdating", "get_IsCheckingForUpdates",
"get_UpdateProgress", "get_IsLoadingDefaults", "get_IsReloading", "get_IsSaving", "get_IsLoading",
"get_IsUnloading", "get_IsUpdatingSettings", "get_IsUpdatingPlugins", "get_IsDeletingPlugins",
"get_IsCleaningUp", "get_IsUpdatingCompatibility", "get_IsPerformingAction", "get_IsRefreshingUI",
"get_IsSortingPlugins", "get_IsFilteringPlugins", "get_IsSearchingPlugins", "get_IsLoadingTranslations",
"get_IsLoadingPluginData", "get_IsLoadingPluginSettings", "get_IsLoadingPluginDependencies",
"get_IsLoadingPluginLoadOrder", "get_IsLoadingPluginPriority", "get_IsLoadingPluginIsHidden",
"get_IsLoadingPluginIsDebug", "get_IsLoadingPluginIsStandalone", "get_IsLoadingPluginRequireRestart",
"get_IsLoadingPluginHasUpdate", "get_IsLoadingPluginUpdateVersion", "get_IsLoadingPluginUpdateURL",
"get_IsLoadingPluginIsCustom", "get_IsLoadingPluginCustomSettings", "get_IsLoadingPluginIsDeleted",
"get_IsLoadingPluginDeletedBy", "get_IsLoadingPluginDeletedDate", "get_IsLoadingPluginIsCompatible",
"get_IsLoadingPluginCompatibilityNotes", "get_IsLoadingPluginHasWarnings", "get_IsLoadingPluginWarnings",
"get_IsLoadingPluginHasErrors", "get_IsLoadingPluginErrors", "get_IsLoadingPluginLoadErrors",
"get_IsLoadingPluginEnabledPlugins", "get_IsLoadingPluginDisabledPlugins", "get_IsLoadingPluginAvailablePlugins" };

        private static readonly Dictionary<string, string> Names = new Dictionary<string, string>();

        private static string RandomString(int length, string chars)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        private static string GetRandomName()
        {
            return NormalNameStrings[Random.Next(NormalNameStrings.Length)];
        }

        public static string GenerateString(RenameMode mode)
        {
            return mode switch
            {
                RenameMode.Ascii => RandomString(Random.Next(1, 7), Ascii),
                RenameMode.Key => RandomString(16, Ascii),
                RenameMode.Normal => GetRandomName(),
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null)
            };
        }


        public static void ExecuteClassRenaming(ModuleDefMD module)
        {
            foreach (var type in module.GetTypes())
            {
                if (type.IsGlobalModuleType)
                    continue;

                if (type.Name == "GeneratedInternalTypeHelper" || type.Name == "Resources" || type.Name == "Settings")
                    continue;

                if (type.FullName.Contains(".My"))
                    continue;

                if (Names.TryGetValue(type.Name, out var nameValue))
                {
                    type.Name = nameValue;
                }
                else
                {
                    var newName = GenerateString(RenameMode.Normal);

                    Names.Add(type.Name, newName);
                    type.Name = newName;
                }
            }

            ApplyChangesToResourcesClasses(module);
        }


        private static void ApplyChangesToResourcesClasses(ModuleDefMD module)
        {
            var moduleToRename = module;
            foreach (var resource in moduleToRename.Resources)
                foreach (var item in Names)
                    if (resource.Name.Contains(item.Key))
                        resource.Name = resource.Name.Replace(item.Key, item.Value);
            foreach (var type in moduleToRename.GetTypes())
                foreach (var property in type.Properties)
                {
                    if (property.Name != "ResourceManager")
                        continue;

                    var instr = property.GetMethod.Body.Instructions;

                    for (var i = 0; i < instr.Count - 3; i++)
                        if (instr[i].OpCode == OpCodes.Ldstr)
                            foreach (var item in Names.Where(item =>
                                         item.Key == instr[i].Operand.ToString()))
                                instr[i].Operand = item.Value;
                }
        }


        public static void ExecuteFieldRenaming(ModuleDefMD module)
        {
            foreach (var type in module.GetTypes())
            {
                if (type.IsGlobalModuleType) continue;

                if (type.FullName.Contains(".My"))
                    continue;
                foreach (var field in type.Fields)
                    if (Names.TryGetValue(field.Name, out var nameValue))
                    {
                        field.Name = nameValue;
                    }
                    else
                    {
                        var newName = GenerateString(RenameMode.Ascii);

                        Names.Add(field.Name, newName);
                        field.Name = newName;
                    }
            }

            ApplyChangesToResourcesField(module);
        }

        private static void ApplyChangesToResourcesField(ModuleDefMD module)
        {
            foreach (var type in module.GetTypes())
                if (!type.IsGlobalModuleType)
                {
                    if (type.FullName.Contains(".My"))
                        continue;
                    foreach (var methodDef in type.Methods)
                        if (methodDef.Name != "InitializeComponent")
                        {
                            if (!methodDef.HasBody) continue;

                            IList<Instruction> instructions = methodDef.Body.Instructions;
                            for (var i = 0; i < instructions.Count - 3; i++)
                                if (instructions[i].OpCode == OpCodes.Ldstr)
                                    foreach (var keyValuePair in Names)
                                        if (keyValuePair.Key == instructions[i].Operand.ToString())
                                            instructions[i].Operand = keyValuePair.Value;
                        }
                }
        }

        public static void ExecuteMethodRenaming(ModuleDefMD module)
        {
            foreach (var type in module.GetTypes())
            {
                if (type.IsGlobalModuleType) continue;
                if (type.FullName.Contains(".My"))
                    continue;

                if (type.Name == "GeneratedInternalTypeHelper") continue;

                foreach (var method in type.Methods)
                {
                    if (!method.HasBody) continue;

                    if (method.Name == ".ctor" || method.Name == ".cctor") continue;

                    method.Name = GenerateString(RenameMode.Ascii);
                }
            }
        }

        public static void ExecuteModuleRenaming(ModuleDefMD mod)
        {
            foreach (var module in mod.Assembly.Modules)
            {
                var isWpf = false;
                foreach (var asmRef in module.GetAssemblyRefs())
                    if (asmRef.Name == "WindowsBase" || asmRef.Name == "PresentationCore" ||
                        asmRef.Name == "PresentationFramework" || asmRef.Name == "System.Xaml")
                        isWpf = true;

                if (!isWpf)
                {
                    module.Name = GenerateString(RenameMode.Ascii);

                    module.Assembly.CustomAttributes.Clear();
                    module.Mvid = Guid.NewGuid();
                    module.Assembly.Name = GenerateString(RenameMode.Ascii);
                    module.Assembly.Version = new Version(Random.Next(1, 9), Random.Next(1, 9), Random.Next(1, 9),
                        Random.Next(1, 9));
                }
            }
        }

        public static void ExecuteNamespaceRenaming(ModuleDefMD module)
        {
            foreach (var type in module.GetTypes())
            {
                if (type.IsGlobalModuleType) continue;

                if (type.FullName.Contains(".My"))
                    continue;

                if (type.Namespace == "") continue;

                if (Names.TryGetValue(type.Namespace, out var nameValue))
                {
                    type.Namespace = nameValue;
                }
                else
                {
                    var newName = GenerateString(RenameMode.Ascii);

                    Names.Add(type.Namespace, newName);
                    type.Namespace = newName;
                }
            }

            ApplyChangesToResourcesNamespace(module);
        }

        private static void ApplyChangesToResourcesNamespace(ModuleDefMD module)
        {
            foreach (var resource in module.Resources)
                foreach (var item in Names.Where(item => resource.Name.Contains(item.Key)))
                    resource.Name = resource.Name.Replace(item.Key, item.Value);

            foreach (var type in module.GetTypes())
                foreach (var property in type.Properties)
                {
                    if (property.Name != "ResourceManager") continue;

                    var instr = property.GetMethod.Body.Instructions;

                    for (var i = 0; i < instr.Count - 3; i++)
                        if (instr[i].OpCode == OpCodes.Ldstr)
                            foreach (var item in Names.Where(item =>
                                         item.Key == instr[i].Operand.ToString()))
                                instr[i].Operand = item.Value;
                }
        }

        public static void ExecutePropertiesRenaming(ModuleDefMD module)
        {
            foreach (var type in module.GetTypes())
            {
                if (type.IsGlobalModuleType) continue;

                foreach (var property in type.Properties) property.Name = GenerateString(RenameMode.Ascii);
            }
        }
    }
}
