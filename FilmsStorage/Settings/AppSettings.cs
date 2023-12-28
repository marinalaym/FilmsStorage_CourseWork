using FilmsStorage.Models;
using System.Security.Cryptography;
using System.Text;

namespace FilmsStorage.Settings
{
    public class AppSettings
    {
        public static User? User { get; set; }

        public const string ConnectionString = @"Server=localhost;database=FilmsStorage;Integrated Security=True";

        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
