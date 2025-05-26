using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Administracion_WinForms
{
    internal class Class1
    {
    }
    public static class Sesion
    {
        public static int IdUsuario;
        public static string NombreUsuario;
    }

    public static class Seguridad
    {
        public static string Hashear(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                    builder.Append(b.ToString("x2")); // Hexadecimal
                return builder.ToString();
            }
        }
    }

}
