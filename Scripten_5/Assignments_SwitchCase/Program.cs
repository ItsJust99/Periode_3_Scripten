using System;

namespace Assignments_SwitchCase
{
    class Program
    {
        enum WeekDays
        {
            Maandag,
            Dinsdag,
            Woensdag,
            Donderdag,
            Vrijdag,
            Zaterdag,
            Zondag
        }
        enum Direction
        {
            North,
            East,
            South,
            West,
            Stay
        }

        static void Main(string[] args)
        {
            /*
             Part 1: Days of the Week...
              1. Create a region named 'DaysOfTheWeek'.
              2. Create an enumerable type named 'WeekDays' containing all days of the week.
                 Tip : Enums are defined before the Main method.
              3. Declare a variable named 'today' of the enum 'WeekDays' type.
              4. Assign the 'today' variable a value from the 'WeekDays' enum.
              5. Create a Switch Case which prints text to the console depending on the day of the week.
 
            Part 2: Player Direction...
              1. Create a new region named 'Directions'.
              2. Create an enumerable type named 'Direction' containing the following items:
                 - North
                 - East
                 - South
                 - West
                 - Stay
              4. Create a variable of the type Direction with the name playerDirection.
              5. Create a menu where the user has to provide a number to select one of the four directions.
                 Make sure only valid input is accepted. 
              6. Create a Switch Case which assigns playerDirection the correct enum value based on the user selected direction.
              7. Create a second Switch Case which prints some text to the console depending on the active direction.
             */

            //part 1
            #region DaysOfTheWeek
            WeekDays today = WeekDays.Woensdag;

            switch (today)
            {
                case WeekDays.Maandag:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("het is maandag OwO");
                    Console.ResetColor();
                    break;
                case WeekDays.Dinsdag:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Dindag het is nog een lange dag dat te gaan T-T");
                    Console.ResetColor();
                    break;
                case WeekDays.Woensdag:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Woendag we zijn op de helft UwU");
                    Console.ResetColor();
                    break;
                case WeekDays.Donderdag:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("you can do it, you can do it! but It's only Donderdag ~OwO~ ");
                    Console.ResetColor();
                    break;
                case WeekDays.Vrijdag:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Zowat weekend OvO vrijdag");
                    Console.ResetColor();
                    break;
                case WeekDays.Zaterdag:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("-3- best day evver zaterdag");
                    Console.ResetColor();
                    break;
                case WeekDays.Zondag:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("maak je maar klaar voor morgen want nu is het zondag xP");
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
            #endregion

            Console.WriteLine("\n---------------------------\n");

            //part 2 nog niet klaar!
            #region Directions
            string input;
            string menuChoice;
            int choice;
            Direction playerDirection;

            Console.WriteLine("Choose 1 for North");
            Console.WriteLine("Choose 2 for East");
            Console.WriteLine("Choose 3 for South");
            Console.WriteLine("Choose 4 for West");
            Console.WriteLine("Choose 5 for Stay");
            Console.WriteLine();
            Console.Write("please make your choice: ");

            input = Console.ReadLine();
            int.TryParse(input, out choice);
            ShowMenu();

            void ShowMenu()
            {
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:      
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
            #endregion
        }
    }
}
