using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{   //abstract class which allows otherclass to use/override method
    abstract class Player
    {   //actual method that used by other classes for different game types
        abstract public string GetRoshambo();
    }
}
