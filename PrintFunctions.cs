using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    public static class PrintFunctions
    {
        // вывод верхнего меню
        public static void PrintTopMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            string[] items = { "Левая", "Файл", "Диск", "Команды", "Правая" };
            foreach(string item in items)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(item[0].ToString().PadLeft(6, ' '));
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(item.Substring(1));
            }

            Console.Write("".PadLeft(44, ' '));
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("8 30".PadLeft(5, ' '));
        }


        // вывод верхней части рамки
        public static void PrintTopFrame()
        {
            // левая часть
            Console.Write("\u2554");
            for(int i = 0; i < 15; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2564");
            for(int i = 0; i < 4; i++)
            {
                Console.Write("\u2550");
            }

            Console.Write(" C:\\NC ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2564");
            for (int i = 0; i < 15; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2557");


            // правая часть
            Console.Write("\u2554");
            for (int i = 0; i < 16; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2564");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\u2550");
            }

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" C:\\NC ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\u2550\u2550\u2564");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2564");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("\u2550");
            }

            Console.WriteLine("\u2557");
        }

        // вывод шапки таблицы
        public static void PrintTableHeader()
        {
            Console.Write("\u2551C:\u2193  Имя".PadRight(16, ' '));
            for(int i = 0; i < 2; i++)
            {
                Console.Write("\u2502".PadRight(7, ' '));
                Console.Write("Имя".PadRight(9, ' '));
            }
            Console.Write("\u2551\u2551");

            Console.Write("C:\u2193  Имя".PadRight(16, ' '));
            Console.Write("\u2502".PadRight(4, ' '));
            Console.Write("Размер".PadRight(10, ' '));
            Console.Write("\u2502".PadRight(4, ' '));
            Console.Write("Дата".PadRight(7, ' '));
            Console.Write("\u2502".PadRight(2, ' '));
            Console.Write("Время".PadRight(6, ' '));
            Console.Write("\u2551");

            Console.WriteLine();
        }



        // вывод списка файлов (основная функция)
        public static void PrintFilesList()
        {
            List<File> f = FileList.CreateList();

            // i - строка
            for (int i = 0; i < 18; i++)
            {
                // вывод левой части
                Console.Write("\u2551");
                if (i == 0)
                    Console.Write("..".PadRight(15, ' '));
                else
                {
                    Console.Write($"{f[i - 1].getNameToPrint()}".PadRight(12, ' '));
                    f[i].printExtension();
                }

                Console.Write("\u2502");
                Console.Write($"{f[i + 17].getNameToPrint()}".PadRight(12, ' '));
                f[i + 18].printExtension();

                Console.Write("\u2502");
                Console.Write($"{f[i + 35].getNameToPrint()}".PadRight(12, ' '));
                f[i + 36].printExtension();

                Console.Write("\u2551\u2551");

                // вывод правой части
                if (i == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("..".PadRight(16, ' '));
                    Console.Write("\u2502  \u25B6КАТАЛОГ\u25C0  \u2502");
                    Console.Write("  11.10.02\u2502  19:48");

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\u2551");
                }
                else
                {
                    Console.Write($"{f[i - 1].getNameToPrint()}".PadRight(13, ' '));
                    f[i - 1].printExtension();
                    Console.Write("\u2502");
                    Console.Write($"{f[i - 1].getSizeToString()}".PadLeft(13, ' '));
                    Console.Write("\u2502  ");
                    f[i - 1].printDate();
                    Console.Write("\u2502  ");
                    f[i - 1].printTime();
                    Console.Write("\u2551");
                }

                Console.WriteLine();
            }
        }



        // вывод нижней части таблицы
        public static void PrintTableFooter()
        {
            // 1 строка левая часть
            Console.Write("\u255F");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write("\u2500");
                }
                Console.Write("\u2534");
            }
            for(int i = 0; i < 15; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2562");

            // 1 строка правая часть
            Console.Write("\u255F");
            for (int i = 0; i < 16; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2534");
            for (int i = 0; i < 13; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2534");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2534");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("\u2500");
            }
            Console.WriteLine("\u2562");


            // 2 строка левая часть
            Console.Write("\u2551");
            Console.Write("..".PadRight(18, ' '));
            Console.Write("\u25B6КАТАЛОГ\u25C0    11.10.02   19:48\u2551");

            // 2 строка правая часть
            Console.Write("\u2551");
            Console.Write("..".PadRight(20, ' '));
            Console.WriteLine("\u25B6КАТАЛОГ\u25C0    11.10.02   19:48\u2551");


            // 3 строка
            Console.Write("\u255A");
            for(int i = 0; i < 47; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u255D\u255A");
            for(int i = 0; i < 49; i++)
            {
                Console.Write("\u2550");
            }
            Console.WriteLine("\u255D");
        }



        // вывод нижнего меню
        public static void PrintBottomMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("C:\\NC>".PadRight(100, ' '));


            string[] items = { "Помощь", "Вызов", "Чтение", "Правка", "Копия", "НовИмя", "НовКат", "Удал-е", "Меню", "Выход" };
            for(int i = 0; i < items.Length; i++)
            {
                Console.Write(i+1);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(items[i].PadRight(6, ' '));
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("   ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
