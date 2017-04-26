using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{   //subclass which takes on method from player class
    class HumanPlayer: Player
    {
        public override string GetRoshambo()
        {   //gathers user input and returns value to the main method
            Console.Write("\nPlease type a value: ");
            string input = Validation.InputVerifyList();
           
            return input;
        }
    }
}
