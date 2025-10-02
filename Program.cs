using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Animation_KatelynNicholson
{
    internal class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(10, 5);
            Console.Write("  ");

            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(i, 0);
                Console.Write("   ");

                if (i > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(i - 1, 0);
                    Console.Write("  ");
                }

                Thread.Sleep(100);
            }

            for (int i = 0; i < 10; i++) //numbers X, Y 
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, i);
                Console.Write("  ");

                if (i > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(10, i - 1);
                    Console.Write("  ");
                }

                Thread.Sleep(100);
            }

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 15);
            Console.Write("  ");

            for (int i = 5; i < 5; i++) //numbers X, Y 
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(5, i);
                Console.Write("  ");

                if (i > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(10, i - 1);
                    Console.Write("  ");
                }

                Thread.Sleep(100);
            }


            Console.ReadKey();
        }
    }
}
