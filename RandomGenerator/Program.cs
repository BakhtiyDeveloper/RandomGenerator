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

                    if (userInputChoiceValue > 0)
                    {
                        switch (userInputChoiceValue)
                        {
                            





                        }

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

        
        static void GenerateEmailAddress(int count)
        {
            EmailAddresses emailGenerator = new EmailAddresses();

            for (int i = 0; i < count; i++)
            {
                string emailRandom = emailGenerator.GetValue();
                Console.WriteLine(emailRandom);
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

        //GenerateEmailAddress(count: userInputValue);



        //GenerateLipsum(1);

        //GenerateIntRange(count: userInputValue);
    }
}
