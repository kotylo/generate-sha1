using System;
using System.Text;

namespace generate_sha1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = null;
            if (args.Length == 0 || args[0] == "/?")
            {
                Console.WriteLine("Hi! Use the first parameter to provide a string to hash. Or type it here:");
                password = Console.ReadLine();
            }
            var sha1 = System.Security.Cryptography.SHA1.Create();
            
            if (password == null){
                password = args[0];
            }

            var passwordBytes = Encoding.ASCII.GetBytes(password);
            var hashBytes = sha1.ComputeHash(passwordBytes);

            var result = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
