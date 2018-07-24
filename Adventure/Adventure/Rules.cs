using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Rules
    {
        //member variables
        public string setOfRules;

        //constructor
        public Rules()
        {
            setOfRules = "Fetching rule book! Sit tight!";
        }

        //member methods
        public string DisplayRules()
        {
            Console.WriteLine("You may only venture forward!");
            Console.WriteLine("If you die you die! Must restart from beginning!");
            Console.WriteLine("Most importantly! Make sure to have fun!");
            return setOfRules;
        }
    }
}
