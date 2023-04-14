using System.IO;
using System.Security.Cryptography;
namespace NugetaCrypterGUI.Powershell
{
    internal class RandomKeyandIv
    {
        public static byte[] GenerateRandomBytes(int length)
        {
            byte[] bytes = new byte[length];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }
            return bytes;
        }
    }
}
