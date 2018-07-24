using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Forest
    {
        // member variable
        public string forestSetting;

        // constructor
        public Forest()
        {
            forestSetting = "You have now entered the forest! Proceed with coution for danger lies around every turn!";
        }

        // member method
        public void ForestMenu()
        {
            Console.WriteLine("Press [1] to follow the marked path through the forest!");
            Console.WriteLine("Press [2] to forge your own path and head deeper into the forest!");
            Console.WriteLine("Press [3] to see the current radio station.");
            Console.WriteLine("Press [4] to set the current radio station.");
            Console.WriteLine("Press [5] to turn the alarm on or off.");
        }
    }
}
