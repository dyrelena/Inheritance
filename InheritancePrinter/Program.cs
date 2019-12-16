using System;
using System.Collections.Generic;

namespace InheritancePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string printingTest = "Text for test printing";
            PrinterColor printColorText = new PrinterColor();
            Printer printText = printColorText;
            printColorText.PrintValue = "Text for test printing";

            Console.WriteLine("Press 1 for default color or 0 for custom color:");
            
            string textColor = Console.ReadLine();
            if (textColor == "1")
            {
                printText.Print(printText.PrintValue);
            }
            else if (textColor == "0")
            {
                printColorText.ChooseColor();
                printColorText.Print(printText.PrintValue);
                Console.ResetColor();
            }
            else
            {
                printColorText.Print();
            }
        }
    }

    class Printer
    {
        String printValue;

        public string PrintValue { get => printValue; set => printValue = value; }

        public void Print(string value)
        {
            PrintValue = value;
            Console.WriteLine("\n{0}", value);
            Console.ReadLine();
        }
    }

    class PrinterColor : Printer
    {
        string colorName;
        protected Dictionary<string, ConsoleColor> colorSet = new Dictionary<string, ConsoleColor>();
        public void ChooseColor()
        {            
            colorSet.Add("black", ConsoleColor.Black);
            colorSet.Add("blue", ConsoleColor.Blue);
            colorSet.Add("cyan", ConsoleColor.Cyan);
            colorSet.Add("dark blue", ConsoleColor.DarkBlue);
            colorSet.Add("dark cyan", ConsoleColor.DarkCyan);
            colorSet.Add("dark gray", ConsoleColor.DarkGray);
            colorSet.Add("dark green", ConsoleColor.DarkGreen);

            Console.WriteLine("Choose color: ");
            foreach (string keyValue in colorSet.Keys)
            {
                Console.WriteLine("\t\t{0};", keyValue);
            }
            colorName = Console.ReadLine();
            Console.ForegroundColor = colorSet[colorName];            
        }
        public void Print()
        {
            string errorValue = "Error! Please Reboot Universe";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorValue);
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    
}
