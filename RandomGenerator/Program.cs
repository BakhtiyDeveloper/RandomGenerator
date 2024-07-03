using System;
using Tynamix.ObjectFiller;


namespace RandomGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yesOrNo;
            do
            {
                try
                {
                    Console.WriteLine("This program randomly generates Lorem text based on Full Name, Email Address, Integer number and entered value");
                    Console.WriteLine("Which service do you want to use? Enter the contest!!!");
                    Console.WriteLine("1 - Full Name Generator");
                    Console.WriteLine("2 - Email Address Generator");
                    Console.WriteLine("3 - Integer Range Generator");
                    Console.WriteLine("4 - Lipsum Text Generator");
                    Console.Write("Your choice: ");

                    string userInputChoice = Console.ReadLine();
                    int userInputChoiceValue = Convert.ToInt32(userInputChoice);

                    Console.WriteLine("How many random do you want it to generate?");
                    Console.Write("Enter the value: ");
                    string userInput = Console.ReadLine();
                    int userInputValue = Convert.ToInt32(userInput);

                    if (userInputChoiceValue == 1)
                    {
                        GenerateFullName(count: userInputValue);
                    }
                    else if (userInputChoiceValue == 2)
                    {
                        GenerateEmailAddress(count: userInputValue);
                    }
                    else if (userInputChoiceValue == 3)
                    {
                        Console.Write("Enter a random starting value: ");
                        string userInputMin = Console.ReadLine();
                        int userInputMinValue = Convert.ToInt32(userInputMin);

                        Console.Write("Enter a random starting value: ");
                        string userInputMax = Console.ReadLine();
                        int userInputMaxValue = Convert.ToInt32(userInputMax);
                        GenerateIntRange(count: userInputValue, min: userInputMinValue, max: userInputMaxValue);
                    }
                    else if (userInputChoiceValue == 4)
                    {
                        Console.WriteLine("How many words of text do you need?");
                        Console.Write("Enter the number of words: ");
                        string userInputLipsum = Console.ReadLine();
                        int userInputLipsumValue = Convert.ToInt32(userInputLipsum);
                        GenerateLoremIpsum(count: userInputValue, numberOfWords: userInputLipsumValue);
                    }
                    else
                    {
                        Console.WriteLine("You entered an invalid value\nPlease try again");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"You entered an invalid value: {exception.Message}");
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to continue? (yes / no)");
                yesOrNo = Console.ReadLine();

            } while (yesOrNo.ToLower() == "yes" || yesOrNo.ToLower() == "y");

            Console.WriteLine("Thank you for using our program");
        }

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
