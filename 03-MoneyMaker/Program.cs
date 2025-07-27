using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.Write("Enter an amount of cents to convert to coins: ");
            string totalAsString = Console.ReadLine();

            // Convert input string to an integer for whole cents
            int total = Convert.ToInt32(totalAsString);

            // Define coin values in cents
            int goldValue = 10;
            int silverValue = 5;

            // Calculate number of gold coins (10¢)
            int goldCoins = total / goldValue;
            int remainder = total % goldValue;

            // Calculate number of silver coins (5¢)
            int silverCoins = remainder / silverValue;
            remainder = remainder % silverValue;

            Console.WriteLine($"{total} cents is equal to:");
            Console.WriteLine($"{goldCoins} gold coins (10¢)");
            Console.WriteLine($"{silverCoins} silver coins (5¢)");
            Console.WriteLine($"{remainder} bronze coinds (1¢)");
        }
    }
}