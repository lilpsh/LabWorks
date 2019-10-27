using Controllers.Controllers;
using System;
using System.Text;

/**
* @author - Michael Mushynskyi
*
* @date - 10/22/2019 12:18:00 AM 
*/

namespace View
{
    public class ConsoleUI
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string input = "";
            while (input != "exit")
            {
                Console.Clear();
                ShowHomeScreen();
                input = Console.ReadLine();
                switch(input.ToLower())
                {
                    case "student":
                        RunStud();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Wrong input!!\nPress any key...");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private void RunStud()
        {
            StudController std = new StudController();
            Console.Clear();
            Console.WriteLine("StudController\n\nCommands:\n" + std.GetCommands());
            string inp = null;
            string com = null;
            while (std.isActive)
            {
                Console.WriteLine("Command:");
                com = Console.ReadLine();
                Console.WriteLine("Input:");
                inp = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(std.CheckInput(inp,com));
            }
        }
        private void ShowHomeScreen()
        {
            //Any welcome words and command list...
            Console.WriteLine("Hello\n\nStudent - student controller;\n\nExit - exit.");
        }
    }
}
