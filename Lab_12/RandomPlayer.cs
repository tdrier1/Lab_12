using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class RandomPlayer: Player
    { 
        public override string GetRoshambo()
        {   //generates random number with a new seed and pull value from list of strings
            var random = new Random(Guid.NewGuid().GetHashCode());
            var game = new List<string>{"rock","paper","scissors"};
            int index = random.Next(game.Count);
            string RandomString = game[index];
            
            return RandomString;
        }
    
    }
}
