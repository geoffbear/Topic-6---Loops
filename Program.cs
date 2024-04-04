using System.Text.RegularExpressions;
using System.Transactions;

namespace Topic_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            string choicePercentage = "";
            int max, min, userNumber, percentages, guess;
            int addition = 0;
            double totalChoices = 0;
            double above70 = 0;
            List<int> numberList = new List<int>();
            while (choice != "q")
            {
                Console.Clear(); 
                Console.WriteLine("Welcome to my Geoffrey's Great Games. Type a numeric option:");
                Console.WriteLine();
                Console.WriteLine("1 - The Pretty Prompter");
                Console.WriteLine("2 - The Philosophical Percent Passing");
                Console.WriteLine("3 - Awesome Odd Sum");
                Console.WriteLine("4 - Really Random Numbers");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chosen Prompter.");
                    Console.WriteLine("Give me 2 numbers and you will play a little game with them. (Your larger number will be the max");
                    Console.WriteLine();
                    Console.WriteLine("First number.");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Second number.");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    if (firstNumber > secondNumber)
                    {
                        Console.WriteLine("You max is " + firstNumber + "and your min is " + secondNumber);
                        Console.ReadLine();
                        while (guess => firstNumber || guess =< secondNumber)
                        {

                        }
                    }
                    else if (secondNumber > firstNumber)
                    {
                        Console.WriteLine("You max is " + secondNumber + "and your min is " + firstNumber);
                        Console.ReadLine();
                    }
                    else if (firstNumber == secondNumber)
                    {
                        Console.WriteLine("Oops, your numbers are equal, press Enter to continue.");
                        Console.ReadLine();
                    }














                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chosen Percent Passing");
                    Console.WriteLine("Give me as many numbers as you want and I will calculate what % is above 70, type 'Q' when done.");
                    Console.WriteLine();
                    bool done = false;
                    while (!done)
                    {
                        Console.WriteLine("Type a number or 'Q' to quit.");
                        choicePercentage = Console.ReadLine().ToUpper().Trim();

                        if (choicePercentage == "Q")
                        {
                            done = true;
                        }

                        else
                        {
                            totalChoices++;

                            if (Convert.ToInt32(choicePercentage) >= 70)
                            {
                                above70++;
                            }
                        }
                    }
                        Console.WriteLine(Math.Round(above70 / totalChoices * 100, 1)+ "% is above 70.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You have chosen Odd sum.");
                    Console.WriteLine();

                    Console.WriteLine("Give me a number and I will add up all its previous odd numbers.");
                    int oddNumber = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i < oddNumber; i += 2)
                    {
                        addition += i;
                    }
                    Console.WriteLine("Your total is: " + addition);
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    Random generator = new Random();
                    Console.WriteLine("You have chosen Random numbers, welcome user.");
                    Console.WriteLine();

                    Console.WriteLine("Give me a maximum whole number of your choice.");
                    max = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Give me a minimum whole number LOWER than the previous value.");
                    min = Convert.ToInt32(Console.ReadLine());
                    if (min > max)
                    {
                        Console.WriteLine("Here are 25 random numbers with in your chosen range:");
                        for (int i = 0; i < 25; i++)
                        {
                            userNumber = generator.Next(max, min);
                            Console.Write($"{userNumber} ");
                        }
                    }
                    else if (max > min)
                    {
                        Console.WriteLine("Here are 25 random numbers with in your chosen range:");
                        for (int i = 0; i < 25; i++)
                        {
                            userNumber = generator.Next(min, max);
                            Console.Write($"{userNumber} ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}
