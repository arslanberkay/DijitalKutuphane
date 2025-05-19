using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Helper
{
    public class Sifreleme
    {
        /// <summary>
        /// İçine aldığı string türünde parametreyi şifrelenmiş şekilde geri döndürür.
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public static string Sha256Hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(s => s.ToString("X2")));
            }
        }
    }
}
