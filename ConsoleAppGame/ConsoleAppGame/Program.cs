using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGame
{
    class Program
    {
        static void Main(string[] args)
        {
            winnerWinner();
        }

        public static void winnerWinner()
        {
            Console.WriteLine("Hello there, Human!");
            Console.WriteLine("Press Enter to continue!");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string choice;

            Console.WriteLine("You've bought the winning lottery ticket!");
            Console.WriteLine("What will you do with all your ritches?!?!");
            Console.WriteLine("1.Buy the Moon");
            Console.WriteLine("2.Buy Mars");
            Console.Write("Choice: ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "buy the moon":
                case "moon":
                    {
                        Console.WriteLine("Planet Mars is very angry!");
                        Console.WriteLine("Red Asteroids come crashing down to Earth!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }

                case "2":
                case "buy mars":
                case "mars":
                    {
                        Console.WriteLine("Elon Musk is calling your phone!!");
                        Console.WriteLine("Welcome to SpaceX!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I'm sorry i don't have Human emotions");
                        Console.WriteLine("You should press the Enter key again...");
                        Console.ReadLine();
                        first();
                        break;
                    }
                
            }
        }

        public static void second()
        {
            Random rnd = new Random();
            string[] secOptions = { "Wow, tell me how you really feel?!?.", "Earth has hope." };
            int randomNumber = rnd.Next(0, 2);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Are you happy with your choice?; yes or No?");
            Console.Write("Choice:  ");
            secChoice = Console.ReadLine();


            if (secChoice == "yes")
            {
                second();
            }
            else if (secChoice == "no")
            {
                Console.WriteLine("The asteriod approaches!");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                gameOver();
            }
            else
            {
                Console.WriteLine("I'm sorry i don't have human emotions");
                Console.WriteLine("You should press the Enter key again...");
                Console.ReadLine();
                second();
            }

        }

   
        public static void gameOver()
        {
            Console.WriteLine("Wow that was selfish");
            Console.WriteLine("Press Enter to try again");
            Console.ReadLine();
            Console.Clear();
            winnerWinner();
        }   


        public static void Victory()
        {
            Console.WriteLine("You win this time....");
            Console.WriteLine("Press Enter to try again");
            Console.ReadLine();
            Console.Clear();
            winnerWinner();
        }
    }
}
