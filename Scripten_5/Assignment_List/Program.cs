using System;
using System.Collections.Generic;

namespace Assignment_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Part 1...
            - Make a list of 5 items
            - Make a list of 3 items
            - Add the items of list one to list two
            - Print the list content to the console

              Part 2...
            - Ask the user to enter an item
            - Check if the item is in the list
            - Let the user know if the selected item is in the list

              Part 3...
            - Remove a random item from the list
            - Sort the list and print the list to the console

              Part 4...
            - Remove all items after position 4 of you list
            - Sort the list in reverse order
            - Print the list content to the console
            */

            //Part 1
            var item = new List<string>() { "O_o", "UwU", "T-T", "OwO", "OOF" };
            var numbers = new List<string>() { "GMN", "LMA", "KF" };
            item.AddRange(numbers);
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintList(); // totaal 8 items in list
            Console.ResetColor();
            Console.WriteLine("\n---------------------------\n");

            //Part 2
            string ding;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter an Item");
            ding = Console.ReadLine();
            Console.WriteLine($"Does the list contain {ding}? : " + item.Contains(ding));
            Console.ResetColor();
            Console.WriteLine("\n---------------------------\n");
            
            //Part 3
            Random rnd = new Random();
            item.RemoveAt(rnd.Next(0, item.Count));
            Console.ForegroundColor = ConsoleColor.Magenta;
            PrintList(); // 7 items blijven over
            Console.ResetColor();
            Console.WriteLine("\n---------------------------\n");

            //Part 4
            item.RemoveRange(5, 2); 
            // RemoveRange heeft 2 waarden nodig. de eerste cijfer is vanaf welke waarde je wilt verwijderen, het 2de cijfer is hoeveel waarden je wilt verwijderen.
            item.Reverse();
            Console.ForegroundColor = ConsoleColor.Blue;
            PrintList(); // 5 items blijven over
            Console.ResetColor();

            #region Methods
            void PrintList()
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Console.WriteLine(item[i]);
                }
            }
            #endregion
        }
    }
}