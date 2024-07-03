using System;
using Tynamix.ObjectFiller;

namespace RandomGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {







            //Console.WriteLine("Enter how many emails you want to send: ");
            //string userInput = Console.ReadLine();
            //int userInputValue = Convert.ToInt32(userInput);

            //Console.WriteLine("Enter how many emails you want to send: ");
            //string userInputtwo = Console.ReadLine();
            //int userInputValueWord = Convert.ToInt32(userInput);

            //GenerateEmailAddress(count: userInputValue);

            //GenerateFullName(count: userInputValue);

            //GenerateLipsum(1);

            //GenerateIntRange(count: userInputValue);



        }

        static void GenerateEmailAddress(int count)
        {
            EmailAddresses emailGenerator = new EmailAddresses();

            for (int i = 0; i < count; i++)
            {
                string emailRandom = emailGenerator.GetValue();
                Console.WriteLine(emailRandom);
            }
        }

        static void GenerateFullName(int count)
        {
            Console.WriteLine("Enter how many emails you want to send: ");
            string userInput = Console.ReadLine();
            int userInputValue = Convert.ToInt32(userInput);

            RealNames realNamesGenerator = new RealNames();

            for (int i = 0; i < count; i++)
            {
                string fullNameRandom = realNamesGenerator.GetValue();
                Console.WriteLine(fullNameRandom);
            }
        }

        static void GenerateLipsum(int count)
        {
            Lipsum lipsumGenerator = new Lipsum(LipsumFlavor.InDerFremde, 10);

            for (int i = 0; i < count; i++)
            {
                string lipsumRandom = lipsumGenerator.GetValue();
                Console.WriteLine(lipsumRandom);
            }
        }

        static void GenerateIntRange(int count)
        {
            IntRange intGenerator = new IntRange(min: 0, max: 9999);

            for (int i = 0; i < count; i++)
            {
                int intRandom = intGenerator.GetValue();
                Console.WriteLine(intRandom);
            }
        }


    }
}
