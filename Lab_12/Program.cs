using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string output1="";
            string output2="";
            bool run = true;

            Console.WriteLine("Welcome to Rock Paper Scissors!");
            do
            {
                Console.WriteLine("\nWould you like to input or generate?");
                Console.WriteLine("Select 1 to input your own value, 2 to generate a value, 3 to select Rock");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                int input = Validation.GetIntWithinRange();

                if (input == 1)
                {
                    HumanPlayer value1 = new HumanPlayer();
                    RandomPlayer value2 = new RandomPlayer();

                    output1 = value1.GetRoshambo();
                    output2 = value2.GetRoshambo();

                    Console.WriteLine("\nComputer:" + output2);
                }

                if (input == 2)
                {
                    RandomPlayer value1 = new RandomPlayer();
                    RandomPlayer value2 = new RandomPlayer();

                    output1 = value1.GetRoshambo();
                    output2 = value2.GetRoshambo();

                    Console.WriteLine("\nYou:" + output1);
                    Console.WriteLine("\nComputer:" + output2);
                }

                if (input == 3)
                {
                    RockPlayer value1 = new RockPlayer();
                    RandomPlayer value2 = new RandomPlayer();

                    output1 = value1.GetRoshambo();
                    output2 = value2.GetRoshambo();

                    Console.WriteLine("\nComputer:" + output2);
                }

                GetOutcome(output1, output2);
                run = Validation.Continue();
        } while (run == true);

      }

        public static void GetOutcome(string output1, string output2)
        {
            if (output1 == "paper" && output2 == "rock" || output1 == "scissors" && output2 == "paper" || output1 == "rock" && output2 == "scissors")
            {
                Console.WriteLine("\n\nYou win!");
            }

            if (output1 == "rock" && output2 == "paper" || output1 == "paper" && output2 == "scissors" || output1 == "scissors" && output2 == "rock")
            {
                Console.WriteLine("\n\nComputer wins!");
            }

            if (output1 == "rock" && output2 == "rock" || output1 == "paper" && output2 == "paper" || output1 == "scissors" && output2 == "scissors")
            {
                Console.WriteLine("\n\nTie!");
            }
        }


           
            
        
   }
}
