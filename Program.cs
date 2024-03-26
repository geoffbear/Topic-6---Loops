using System.Text.RegularExpressions;

namespace Topic_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            int max, min, userNumber;
            while (choice != "q")
            {
                Console.Clear(); // Optional
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
                    Console.WriteLine("You chosen option 1");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chosen ");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You have chosen Odd sum.");
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
