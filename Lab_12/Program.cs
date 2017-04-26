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
            //values for loops and setting up integers for the score count
            bool run = true;
            int p = 0;
            int c = 0;
            int t = 0;
            //Intro
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            do
            {   //intial output variables to be used throughout the main method
                string output1 = null;
                string output2 = null;
                //prompting user
                Console.WriteLine("\nHow would you like to play?");
                Console.WriteLine("\nOPTION 1: To input your own value");
                Console.WriteLine("OPTION 2: To randomly generate a value");
                Console.WriteLine("OPTION 3: To select Rock");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Please enter your choice: ");
                int input = Validation.GetIntWithinRange();//gathering an integer value to select game type w/ validation

                if (input == 1)
                {   //creates new objects for game
                    HumanPlayer value1 = new HumanPlayer();
                    RandomPlayer value2 = new RandomPlayer();
                    //runs method on each object in class
                    output1 = value1.GetRoshambo();
                    output2 = value2.GetRoshambo();
                    //prints result to user
                    Console.WriteLine("\nComputer: " + output2);
                }

                if (input == 2)
                {
                    RandomPlayer value1 = new RandomPlayer();
                    RandomPlayer value2 = new RandomPlayer();

                    output1 = value1.GetRoshambo();
                    output2 = value2.GetRoshambo();

                    Console.WriteLine("\nYou: " + output1);
                    Console.WriteLine("\nComputer: " + output2);
                }

                if (input == 3)
                {
                    RockPlayer value1 = new RockPlayer();
                    RandomPlayer value2 = new RandomPlayer();

                    output1 = value1.GetRoshambo();
                    output2 = value2.GetRoshambo();

                    Console.WriteLine("\nComputer: " + output2);
                }
                //passes values to method which calculates results and counts score
                GetOutcome(output1, output2, ref c, ref p, ref t);
                //prompts user to continue
                run = Validation.Continue();

        } while (run == true);
      }

        public static void GetOutcome(string output1, string output2, ref int p, ref int c, ref int t)
        {   //takes values and determines outcome with simple if statements
            if (output1 == "paper" && output2 == "rock" || output1 == "scissors" && output2 == "paper" || output1 == "rock" && output2 == "scissors")
            {   //returns results to user
                Console.WriteLine("\n\nYou win!");
                p++;//counts up an integer value for running score
            }

            if (output1 == "rock" && output2 == "paper" || output1 == "paper" && output2 == "scissors" || output1 == "scissors" && output2 == "rock")
            {
                Console.WriteLine("\n\nComputer wins!");
                c++;
            }

            if (output1 == "rock" && output2 == "rock" || output1 == "paper" && output2 == "paper" || output1 == "scissors" && output2 == "scissors")
            {
                Console.WriteLine("\n\nTie!");
                t++;
            }
            //prints the current game count to user
            Console.WriteLine($"\n\nScore--> Player: {p} win(s) -- Computer: {c} win(s) -- {t} Ties");
        }


           
            
        
   }
}
