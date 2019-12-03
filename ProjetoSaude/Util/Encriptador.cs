using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Util
{
    public static class Encriptador
    {
        public static string Sha256(string @string)
        {
            SHA256Managed crypt = new SHA256Managed();
            StringBuilder hash = new System.Text.StringBuilder();

            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(@string));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
