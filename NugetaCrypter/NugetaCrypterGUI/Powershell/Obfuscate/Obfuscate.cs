using System;
using System.Text;
using System.Text.RegularExpressions;
namespace NugetaCrypterGUI.Powershell.Obfuscate
{
    internal class Obfuscate
    {
        public static string ObfuscatePowerShellCode(string originalCode)
        {
            // Rename variables
            Regex variableRegex = new Regex(@"\$(\w+)");
            originalCode = variableRegex.Replace(originalCode, match =>
            {
                string originalVariableName = match.Groups[1].Value;
                string obfuscatedVariableName = GenerateObfuscatedName();
                return "$" + obfuscatedVariableName;
            });

            // Rename functions
            Regex functionRegex = new Regex(@"function\s+(\w+)");
            originalCode = functionRegex.Replace(originalCode, match =>
            {
                string originalFunctionName = match.Groups[1].Value;
                string obfuscatedFunctionName = GenerateObfuscatedName();
                return "function " + obfuscatedFunctionName;
            });

            // Randomize control flow
            string[] conditions = { "-eq", "-ne", "-gt", "-lt", "-ge", "-le", "-like", "-notlike", "-match", "-notmatch" };
            Regex conditionRegex = new Regex(@"(\s+-\w+\s+)(\$\w+)");
            originalCode = conditionRegex.Replace(originalCode, match =>
            {
                string conditionOperator = conditions[new Random().Next(conditions.Length)];
                string originalVariableName = match.Groups[2].Value;
                string obfuscatedVariableName = GenerateObfuscatedName();
                return match.Groups[1].Value + "$" + obfuscatedVariableName;
            });

            return originalCode;
        }

        static string GenerateObfuscatedName()
        {
            // Generate random obfuscated name
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = random.Next(5, 11); // Generate random length between 5 and 10 characters
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, characters.Length);
                sb.Append(characters[index]);
            }
            return sb.ToString();
        }
    }
}
