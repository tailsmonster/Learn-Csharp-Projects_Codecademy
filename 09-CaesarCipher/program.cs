using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            Console.Write("Please enter a secret message for me to store.");
            string secretMsg = Console.Read();

            char[] encryptedMsg = new char[secretMsg.Length];

            for (int i = 0; i < secretMsg.Length; i++) {
                char letter = secretMsg[i];
                int alphI = Array.IndexOf(alphabet, letter);
                int letterPos = (alphI + 3) % alphabet.Length;
                char encryptedLetter = alphabet[letterPos];
                encryptedMsg[i] = encryptedLetter;
            } 
            Console.WriteLine("Your secret message is encrypted as:\n");
            Console.WriteLine(String.Join("", encryptedMsg));


        }
    }
}