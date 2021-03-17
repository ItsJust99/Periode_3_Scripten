using System;

namespace Assignment_Enums
{
    class Program
    {
        #region Enume
        //part 1
        enum Directions
        {
            North, //value 0
            South, // value 1
            East, //value 2
            West//value 3
        }
        #endregion

        static void Main(string[] args)
        {
            /*
             Part 1: Directions...
              1. Create an enumerable type named 'Directions' containing all 4 directions north, south, east and west.
              Tip : Enums are defined before the Main method.
            
             Part 2: 
              1. Declare a variable named 'playerDirection' of the enum 'Directions' type.
              2. Ask the user to input one of the available directions.
              3. Use an if statment to check the input and display a different message for every possible option.
  
            Part 3:
              1. Do the same as Part 2 but use the enum value instead of the name.
              2. If you're feeling adventurous you can try to use a foreach to create the menu from the enum 
            */

            //part 2
            string userInput;

            DirectionL();

            void DirectionL()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Directions playerDirection;
                playerDirection = Directions.North;
                Console.WriteLine(playerDirection);

                playerDirection = Directions.East;
                Console.WriteLine(playerDirection);

                playerDirection = Directions.South;
                Console.WriteLine(playerDirection);

                playerDirection = Directions.West;
                Console.WriteLine(playerDirection);
                Console.ResetColor();

                Console.WriteLine();
 
                Console.WriteLine("Type a Direction OwO");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "north")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("So you wanne go North O_o");
                    Console.ResetColor();
                }
                else if (userInput == "east")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Good luk going East UwU");
                    Console.ResetColor();
                }
                else if (userInput == "south")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("South hmmm good choice -3-");
                    Console.ResetColor();
                }
                else if (userInput == "west")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("West is always best TvT");
                    Console.ResetColor();
                }
                else
                {
                    Error(1);
                }
            }
            Console.WriteLine("\n---------------------------\n");

            //part 3
            DirectionC();

            void DirectionC()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                int DirectionsID = (int)Directions.North;
                Console.WriteLine("For North Chooce " + DirectionsID);

                int DirectionsID1 = (int)Directions.East;
                Console.WriteLine("For East Chooce " + DirectionsID1);

                int DirectionsID2 = (int)Directions.South;
                Console.WriteLine("For South Chooce " + DirectionsID2);

                int DirectionsID3 = (int)Directions.West;
                Console.WriteLine("For West Chooce " + DirectionsID3);
                Console.ResetColor();

                Console.WriteLine();

                Console.WriteLine("Chooce a dam Direction ÙwÚ");
                userInput = Console.ReadLine();
                if (userInput == "0")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Alright North here we come OwO");
                    Console.ResetColor();
                }
                else if (userInput == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Beware East Becouse I am here :)");
                    Console.ResetColor();
                }
                else if (userInput == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("-3- Ssssouth");
                    Console.ResetColor();
                }
                else if (userInput == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("always West T-T");
                    Console.ResetColor();
                }
                else
                {
                    Error(2);
                }
            }

            void Error(int ErrorValue)
            {
                if (ErrorValue == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Try agian stupid Human ^w^ \n");
                    Console.ResetColor();
                    DirectionL();
                }
                else if (ErrorValue == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Are you that stupid -,- stupid Human ^w^ \n");
                    Console.ResetColor();
                    DirectionC();
                }
            }
        }
    }
}
