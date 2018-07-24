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
            Console.WriteLine("You arrive at the forest entrence you have three paths before you! Choose wisely!");
            Console.WriteLine("Press [1] to follow the marked path through the forest!");
            Console.WriteLine("Press [2] to forge your own path and head deeper into the forest!");

            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("You've chosen to follow the safest path into the forest however you encounter a large lizard who looks quite hungry and you're the main course!");
                Console.WriteLine("Press [1] to attack the lizard!");
                Console.WriteLine("Press [2] to run from the lizard!");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("You charge at the lizard letting out a loud battle cry!");
                        Console.WriteLine("The lizard is shocked by this display of courage and runs off into the woods!");
                        break;
                    case "2":
                        Console.WriteLine("You've attempted to run from the Lizard, you did not take into account how fast he could run!");
                        Console.WriteLine("He catches you with ease and drags you away! Your adventure ends here, better luck next time...");
                        break;
                    default:
                        Console.WriteLine("Not correct input, please enter the correct input!");
                        ForestMenu();
                        break;

                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine("You decide that making your own path will be the most efficient way of navigating through the forest despite your lack of knowledge or survivles instincts...");
                Console.WriteLine("While forging your own way you realize the trees are growing taller....you've found yourself in quicksand!!!");
                Console.WriteLine("You see something that looks like a vine within your reach it may be your only chance of survivle!");
                Console.WriteLine("Press [1] to grab the object that appears to be a vine!");
                Console.WriteLine("Press [2] to accept your fate and wait for the end!");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("You reach out for the \"vine\"!");
                        Console.WriteLine("You pull the vine it comes crumbleing down! That wasn't a vine it was a snake and it is now slowly wrappig itself around you! Your adventure ends here!");
                        break;
                    case "2":
                        Console.WriteLine("You decide that there is nothing more you can do! You sit and await your fate!");
                        Console.WriteLine("It's been a few hours now and you seem to have stopped sinking! The quicksand appears to only go 2 feet deep and you can just walk out!");
                        break;
                    default:
                        Console.WriteLine("Not correct input, please enter the correct input!");
                        ForestMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("The input you have entered is incorrect! Please try again!");
                ForestMenu();
            }
        }
    }
}
