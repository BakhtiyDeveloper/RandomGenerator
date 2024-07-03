# RandomGenerator
> # Welcome to our Random Generator Program

### Overview

#### This program generates random data based on the user's choice. The available services are:

1. Full Name Generator
2. Email Address Generator
3. Integer Range Generator
4. Lipsum Text Generator

### Usage

After running the program, the user is prompted to choose a service and specify the amount of data they want to generate. The program then generates and displays the requested data. The user can choose to continue using the program or exit.

### Instructions

1. Choose a Service:

    * The program will display a menu with the available services.
    * Enter the number corresponding to your choice and press Enter.


2. Specify the Amount of Data:

    * The program will ask how many random items you want to generate.
    * Enter the desired number and press Enter.

3. Generate Data:

    * Depending on your choice, the program may ask for additional input (e.g., range for integers).
    * Enter the requested values and press Enter.

4. Continue or Exit:

    * After generating the data, the program will ask if you want to continue.
    * Enter "yes" or "no" to continue or exit the program.

### Code Explanation
The program uses the ```Tynamix.ObjectFiller``` library to generate random data. The main logic is encapsulated within a **do-while loop** to allow the user to continue generating data until they choose to exit.

### Main Code Structure

1. Main Method:

    * Displays the menu and processes user input.
    * Calls the appropriate method to generate the requested data.

```cs 
'''

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
Console.WriteLine("Enter the value: ");
string userInput = Console.ReadLine();
int userInputValue = Convert.ToInt32(userInput);

'''
```

2. GenerateFullName Method:

    * Generates and displays random full names.

```cs
'''
static void GenerateFullName(int count)
{
    RealNames realNameGenerator = new RealNames();

    for (int i = 0; i < count; i++)
    {
        string fullNameRandom = realNameGenerator.GetValue();
        Console.WriteLine(fullNameRandom);
    }
}

'''
```

3. GenerateEmailAddress Method:

    * Generates and displays random email addresses.

```cs 
'''
static void GenerateEmailAddress(int count)
{
    EmailAddresses emailGenerator = new EmailAddresses();

    for (int i = 0; i < count; i++)
    {
        string emailRandom = emailGenerator.GetValue();
        Console.WriteLine(emailRandom);
    }
}

'''
```

4. GenerateIntRange Method:

    * Generates and displays random integers within the specified range.

```cs
'''
static void GenerateIntRange(int count, int min, int max)
{
    IntRange intGenerator = new IntRange(min: min, max: max);

    for (int i = 0; i < count; i++)
    {
        int intRandom = intGenerator.GetValue();
        Console.WriteLine(intRandom);
    }
}

'''
```

5. GenerateLoremIpsum Method:

    * Generates and displays random Lipsum text.

```cs
'''
static void GenerateLoremIpsum(int count, int numberOfWords)
{
    Lipsum lipsumGenerator = new Lipsum(LipsumFlavor.ChildHarold, minWords: numberOfWords);

    for (int i = 0; i < count; i++)
    {
        string lipsumRandom = lipsumGenerator.GetValue();
        Console.WriteLine(lipsumRandom);
    }
}

'''
```
6. Result to GIF:

![Result to gif!](/resultGif/result%20gif.gif)

> # I'm glad you are using the program.