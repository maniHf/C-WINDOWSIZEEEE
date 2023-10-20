using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c1
{
    internal class WindowSettings
    {
        public void MethodWindow(string WindTitl)
        {
            Console.Title = WindTitl;
        } 
        public void MethodWondowSizeDeform (bool CursorV)
        {
            Console.CursorVisible = CursorV;
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey();
            
            while (KeyInfo.Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("({0}x{1}) ", Console.WindowWidth, Console.WindowHeight);
                if (KeyInfo.Key == ConsoleKey.LeftArrow) { Console.WindowWidth = Console.WindowWidth - 1;  }
                if (KeyInfo.Key == ConsoleKey.RightArrow) { Console.WindowWidth = Console.WindowWidth + 1; }
                if (KeyInfo.Key == ConsoleKey.UpArrow) { Console.WindowHeight = Console.WindowHeight - 1;  }
                if (KeyInfo.Key == ConsoleKey.DownArrow) { Console.WindowHeight = Console.WindowHeight + 1;}
            }
        }       
    }
}
/* 
 * 
 *             do
            {
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.WindowWidth = Math.Max(Console.WindowWidth - 1, 6);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WindowWidth = Math.Min(Console.WindowWidth + 1, 100);
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WindowHeight = Math.Max(Console.WindowHeight - 1, 2);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WindowHeight = Math.Min(Console.WindowHeight + 1, 60);
                        break;
                }
            }while (KeyInfo.Key != ConsoleKey.Enter);
*
*
*            while (KeyInfo.Key != ConsoleKey.Enter)
            {
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.WindowWidth = Console.WindowWidth - 1; break;
                    case ConsoleKey.RightArrow:
                        Console.WindowWidth = Console.WindowWidth + 1; break;
                    case ConsoleKey.UpArrow:
                        Console.WindowHeight = Console.WindowHeight + 1; break;
                    case ConsoleKey.DownArrow:
                        Console.WindowHeight = Console.WindowHeight - 1; break;
                }
*
*
*
*
*
*
*/