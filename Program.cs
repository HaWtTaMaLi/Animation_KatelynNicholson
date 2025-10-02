using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            for (int i = 0; i < 10; i++) //right 10
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(i, 0);// (Verticle, Horizontal)
                Console.Write("   ");

                if (i > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(i - 1, 0);
                    Console.Write("  ");
                }

                Thread.Sleep(100);
            }

            for (int i = 0; i < 6; i++) //DOWN 6
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

            for (int i = 6; i < 16; i++) //Down 6
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, i);
                Console.Write("  ");

                if (i > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(10, i - 1);
                    Console.Write("   ");
                }

                Thread.Sleep(100);
            }

            for (int i = 10; i < 25; i++) //Right
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(i, 15);
                Console.Write("   ");

                if (i > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(i - 1, 15);
                    Console.Write("  ");
                }

                Thread.Sleep(100);
            }

            Console.ReadKey();
        }
    }
}
