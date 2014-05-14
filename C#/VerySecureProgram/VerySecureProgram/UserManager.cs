using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyCodeCata
{
    /// <summary>
    /// Given the code below, do the following:
    /// 1. Break the dependency on the Console
    /// 2. Get the password comparison feature under test
    /// 3. Get the password validation feature under test
    /// 4. Add a feature to allow different encryption algorithms to be used
    /// 5. Add a feature to allow different outputs, ie. write to file (tip: do your homework)
    /// </summary>
    public class UserManager
    {
        public static void CreateUser()
        {
            Console.WriteLine("Enter a username");
            var username = Console.ReadLine();

            Console.WriteLine("Enter your full name");
            var fullName = Console.ReadLine();

            Console.WriteLine("Enter your password");
            var password = Console.ReadLine();

            Console.WriteLine("Re-enter your password");
            var confirmPassword = Console.ReadLine();

            if (password != confirmPassword)
            {
                Console.WriteLine("The passwords don't match");
                return;
            }

            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters in length");
                return;
            }

            // Encrypt the password (just reverse it, should be secure)
            char[] array = password.ToCharArray();
            Array.Reverse(array);

            Console.Write(String.Format("Saving Details for User ({0}, {1}, {2})\n",
                username,
                fullName,
                new string(array)));
        }
    }
}