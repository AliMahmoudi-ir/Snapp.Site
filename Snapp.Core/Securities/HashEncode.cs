using System.Text;
using System.Security.Cryptography;

namespace Snapp.Core.Securities
{
    public static class HashEncode
    {
        public static string GetHashCode(string password)
        {
            byte[] mainBytes;
            byte[] encodeBytes;

            #pragma warning disable SYSLIB0021 // Type or member is obsolete
            MD5 md5 = new MD5CryptoServiceProvider();
            #pragma warning restore SYSLIB0021 // Type or member is obsolete

            mainBytes = ASCIIEncoding.Default.GetBytes(password);
            encodeBytes = md5.ComputeHash(mainBytes);

            return BitConverter.ToString(encodeBytes);


        }
    }
}
