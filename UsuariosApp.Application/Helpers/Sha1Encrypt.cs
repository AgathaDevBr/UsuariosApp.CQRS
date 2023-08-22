using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Application.Helpers
{
    public class Sha1Encrypt
    {
        public static string Encrypt(string valor)
        {
            using(SHA1 sha1 = SHA1.Create())
            {
                var hashByte = sha1.ComputeHash(Encoding.UTF8.GetBytes(valor));
                var sb = new StringBuilder();

                foreach(var item in hashByte) 
                    sb.Append(item.ToString("x2"));

                return sb.ToString();

            }
        }
    }
}
