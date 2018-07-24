using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Game
    {
        // member variables
        public Rules rules;
        public Character character;
        public Forest forest;
        public Sea sea;
        public Desert desert;

        // contructors
        public Game()
        {
            rules = new Rules();
            character = new Character();
            forest = new Forest();
            sea = new Sea();
            desert = new Desert();
        }

        // member methods
        public void MainMenu()
        {
            Console.WriteLine("Press [1] to see game rules.");
            Console.WriteLine("Press [2] to view character info sheet.");
            Console.WriteLine("Press [3] to enter the dark forest!");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    rules.DisplayRules();
                    break;
                case "2":
                    character.DisplayCharacter();
                    break;
                case "3":
                    forest.ForestMenu();
                    break;
            }
            MainMenu();
        }
    }
}
