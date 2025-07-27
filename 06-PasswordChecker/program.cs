using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWYXZ";
            string lowercase = uppercase.ToLower();
            string digits = "1234567890";
            string specialChars = "!@#$%^&*()_+-={}[]\\|`~\"';:?/>.<,";
            Console.Write("Please enter a password: ");

            string input = Console.ReadLine().Trim();
            int score = 0;

            if (input != "1234" && input.ToLower() != "password") {
                if (input.Length >= minLength) score++;
                if (Tools.Contains(input, uppercase)) score++;
                if (Tools.Contains(input, lowercase)) score++;
                if (Tools.Contains(input, digits)) score++;
                if (Tools.Contains(input, specialChars)) score++;
            }

            Console.WriteLine($"You're password gets a score of: {score}");

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Your password is very strong!");
                    break;
                case 3:
                    Console.WriteLine("Your password is decently strong!");
                    break;
                case 2:
                    Console.WriteLine("Your password is just okay.");
                    break;
                case 1:
                    Console.WriteLine("Your password is weak.");
                    break;
                default:
                    Console.WriteLine("Your password is unconcievably weak. Go change it now!");
                    break;
            }
        }
    }
}