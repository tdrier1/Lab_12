using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class HumanPlayer: Player
    {
        public override string GetRoshambo()
        {
            Console.WriteLine("Please type a value: ");
            string input = Validation.InputVerifyList();
           
            return input;
        }
    }
}
