using System;
using Tynamix.ObjectFiller;

namespace RandomGenerator.Services
{
    internal class CostumeRandomiser
    {
        static void GenerateFullName(int count)
        {
            RealNames realNameGenerator = new RealNames();

            Console.WriteLine("Full Names:");

            for (int i = 0; i < count; i++)
            {
                string fullNameRandom = realNameGenerator.GetValue();
                Console.WriteLine(fullNameRandom);
            }
        }

        static void GenerateEmailAddress(int count)
        {
            EmailAddresses emailGenerator = new EmailAddresses();

            Console.WriteLine("Email Adresses:");

            for (int i = 0; i < count; i++)
            {
                string emailRandom = emailGenerator.GetValue();
                Console.WriteLine(emailRandom);
            }
        }

        static void GenerateIntRange(int count, int min, int max)
        {
            IntRange intGenerator = new IntRange(min: min, max: max);

            Console.WriteLine("Random Numbers:");

            for (int i = 0; i < count; i++)
            {
                int intRandom = intGenerator.GetValue();
                Console.WriteLine(intRandom);
            }
        }

        static void GenerateLoremIpsum(int count, int numberOfWords)
        {
            Lipsum lipsumGenerator = new Lipsum(LipsumFlavor.ChildHarold, minWords: numberOfWords);

            Console.WriteLine("Random Lipsum Text:");

            for (int i = 0; i < count; i++)
            {
                string lipsumRandom = lipsumGenerator.GetValue();
                Console.WriteLine(lipsumRandom);
            }
        }


    }
}
