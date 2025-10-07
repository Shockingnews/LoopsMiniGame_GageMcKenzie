using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsMiniGame_GageMcKenzie
{
    internal class Program
    {

        static int x;
        static int y;
        static bool gameOver = false;
        static void Main(string[] args)
        {
            PlayerDraw(10, 10);
           while(gameOver == false)
            {
                
                PlayerUpdate();
                
            }
            
        }
        static void PlayerDraw(int startX, int startY)
        {
            Console.SetCursorPosition(startX, startY);
            Console.Write("G");
            x = startX;
            y = startY;
        }
        static void PlayerUpdate()
        {
            x = x;
            y = y;
            
            ConsoleKeyInfo lastSletion =new ConsoleKeyInfo();
            lastSletion = Console.ReadKey(true);
            if (lastSletion.Key == ConsoleKey.W)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x,y -= 1);
                Console.Write("G");
                if (y > 0)
                {
                    Console.SetCursorPosition(x, y + 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                    
                }
            }
            else if (lastSletion.Key == ConsoleKey.S)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x,y+=1);
                Console.Write("G");
                if (y > 0)
                {
                    Console.SetCursorPosition(x, y - 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
            }
            else if (lastSletion.Key == ConsoleKey.A)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x -=1 , y);
                Console.Write("G");
                if (x > 0)
                {
                    Console.SetCursorPosition(x+1, y);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
            }
            else if (lastSletion.Key == ConsoleKey.D)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(x+=1, y);
                Console.Write("G");
                if (x > 0)
                {
                    Console.SetCursorPosition(x- 1, y);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Game Over");
                gameOver = true;
            }
        }
    }
}
