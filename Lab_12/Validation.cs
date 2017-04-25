using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Validation
    {
        public static int GetIntWithinRange()
        {
            int Min = 1;
            int Max = 3;
            int value;

            while (true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Please enter a valid number between 1 and 3:");
                }
                else if (value < Min || value > Max)
                {
                    Console.Write("Please enter a valid input year between {0} and {1}: ", Min, Max);
                }
                else
                {
                    break;
                }
            }
            return value;
        }

        public static string InputVerifyList()
        {
            bool run = true;
            string input;

            List<string> InputList = new List<string>();

            InputList.Add("rock");
            InputList.Add("paper");
            InputList.Add("scissors");

            do
            {
                input = Console.ReadLine().ToLower();

                if (InputList.Any(input.Contains))
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("\nPlease enter: Rock, Paper or Scissors");
                }

            } while (run == true);

            return input;
        }

        public static bool Continue()
        {
            string conf;
            bool check = true;
            bool run = true;

            Console.WriteLine("\n=============================");
            Console.WriteLine("\nWould you like to play again?");
            Console.Write("\nPlease Enter (y/n): ");

            do
            {
                conf = Console.ReadLine();
                var t = conf.ToLower();

                if (t != "y" || t != "n")
                {
                    Console.Write("\nPlease Enter (y/n): ");
                }
                if (t == "y")
                {
                    Console.Clear();
                    check = false;
                }

                if (t == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing!");

                    run = false;
                    check = false;
                }
            } while (check == true);

            return run;
        }

    }
}
