using System;
using Tynamix.ObjectFiller;

namespace RandomGenerator 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntRange numberGenerator = new IntRange(min: 0, max: 999);
            int randomNumber = numberGenerator.GetValue();

            Console.WriteLine(randomNumber);






        }
    }
}
