using System;
using System.Xml.Linq;


namespace pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetWindowSize(100, 25);
            Console.Clear();

            PrintFunctions.PrintTopMenu();
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            PrintFunctions.PrintTopFrame();
            PrintFunctions.PrintTableHeader();

            PrintFunctions.PrintFilesList();
            PrintFunctions.PrintTableFooter();
            PrintFunctions.PrintBottomMenu();

            Console.ResetColor();
        }
    }
}
