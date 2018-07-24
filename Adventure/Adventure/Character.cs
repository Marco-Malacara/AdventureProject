using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Character
    {
        // member variable
        public string standardCharacterInfo;

        // constructor
        public Character()
        {
            standardCharacterInfo = "retrieving character info!";
        }

        // member methods
        public string DisplayCharacter()
        {
            Console.WriteLine("Your character is 21 years old.");
            Console.WriteLine("His name is Blake Blurke."); 
            Console.WriteLine("Average 21 year old kid, no real source of income, very little wisdom, lots of energy, constantly making impulsive decisions");
            return standardCharacterInfo;
        }
    }
}