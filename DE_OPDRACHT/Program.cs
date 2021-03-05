using System;

namespace DE_OPDRACHT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "1", "2", "3" };
            int[] diceValues = { 1, 6 };
            Random rnd = new Random();

            menu();

            void menu()
            {
                Console.WriteLine("Have Fun Human, this is maybe the last time you play OwO");
                Console.WriteLine("choose a optoin or die ÙwÚ:");
                Console.WriteLine("1] Start the game!");
                Console.WriteLine("2] Read the rules O_o");
                Console.WriteLine("3] Close the game and die :)");
                Console.WriteLine("");

                string option = Console.ReadLine();
                if (option == options[0])
                {
                    startGame();
                }
                else if (option == options[1])
                {
                    rules();
                }
                else if (option == options[2])
                {
                    Environment.Exit(0);
                }
                else
                {
                    Err(1);
                }
            }

            void startGame()
            {
                Console.Clear();

            }

            void settings()
            {

            }

            void rules()
            {
                Console.Clear();
                Console.WriteLine("Hi, All you need to do is to choose how many players you play and what dobbelsteen you guys wanna play with!");
                Console.WriteLine("you need min. 2 players max. is 6. but for people is the best :)");
                Console.WriteLine("I wish you guys good luk you wil need it! TwT");
                Console.WriteLine("Have Fun! OwO");
                Console.WriteLine("dit you really read the rules O_o If yes press Enter!");
                Console.ReadLine();
                Console.Clear();
                menu();
            }

            void Err(int ErrorValue)
            {
                if (ErrorValue == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Give a valid option! or do you realy wanna die that badly O_o");
                    menu();
                }
            }
        }
    }
}
