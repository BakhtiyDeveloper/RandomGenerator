using System;
using Tynamix.ObjectFiller;

namespace RandomGenerator.Services
{
    internal class CostumeRandomiser
    {
        internal void GenerateFullName(int count)
        {
            RealNames realNameGenerator = new RealNames();

            PrintMassege("Full Names:");
            
            for (int i = 0; i < count; i++)
            {
                string fullNameRandom = realNameGenerator.GetValue();
                PrintMassege(fullNameRandom);
            }
        }

        internal void GenerateEmailAddress(int count)
        {
            EmailAddresses emailGenerator = new EmailAddresses();

            PrintMassege("Email Adresses:");

            for (int i = 0; i < count; i++)
            {
                string emailRandom = emailGenerator.GetValue();
                PrintMassege(emailRandom);
            }
        }

        internal void GenerateIntRange(int count, int min, int max)
        {
            IntRange intGenerator = new IntRange(min: min, max: max);

            PrintMassege("Random Numbers:");

            for (int i = 0; i < count; i++)
            {
                int intRandom = intGenerator.GetValue();

                PrintMassege(intRandom.ToString());
            }
        }

        internal void GenerateLoremIpsum(int count, int numberOfWords)
        {
            Lipsum lipsumGenerator = new Lipsum(LipsumFlavor.ChildHarold, minWords: numberOfWords);

            PrintMassege("Random Lipsun Text:");

            for (int i = 0; i < count; i++)
            {
                string lipsumRandom = lipsumGenerator.GetValue();
                PrintMassege(lipsumRandom);
            }
        }

        private void PrintMassege(string massege) 
        {
            Console.WriteLine(massege);
        }
    }
}
