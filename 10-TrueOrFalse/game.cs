using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Questions and answers
            string[] questions = {
                "Does usagi taste like usagi?",
                "Does unagi taste like unagi?",
                "Does bosh taste like yosh?",
                "Does sqoush taste like squeesh?",
                "Does bnuy taste like usagidood?"
            };

            bool[] answers = { true, true, false, false, true };
            bool[] responses = new bool[answers.Length];

            if (answers.Length != responses.Length)
            {
                Console.WriteLine("Warning! answers and responses aren't the same length.");
            }

            int askingIdx = 0;

            foreach (string question in questions)
            {
                bool isValid = false;

                while (!isValid)
                {
                    Console.WriteLine($"\nQuestion {askingIdx + 1}:");
                    Console.WriteLine(question);
                    Console.Write("\nTrue or False: ");
                    string input = Console.ReadLine().ToLower();

                    if (input == "true")
                    {
                        responses[askingIdx] = true;
                        isValid = true;
                    }
                    else if (input == "false")
                    {
                        responses[askingIdx] = false;
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is incorrect. Please type 'true' or 'false'.");
                    }
                }

                askingIdx++;
            }

            // Score calculation
            int score = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (responses[i] == answers[i]) score++;
            }

            Console.WriteLine($"\nYour score: {score}/{answers.Length}");
        }
    }
}