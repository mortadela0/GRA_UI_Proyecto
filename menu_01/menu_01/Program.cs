using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace menu_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x_v = Console.WindowWidth;
            int y_v = Console.WindowHeight;

            int x = x_v / 2;
            int y = y_v / 2;

            int steps = 1;
            int direction = 0;


            Console.WriteLine($"Ancho de la ventana: {x_v}");
            Console.WriteLine($"Altura de la ventana: {y_v}");
            do
            {
                Thread.Sleep(100);
                for (int i = 0; i < steps; i++)
                {
                    if (x >= 0 && x < x_v && y >= 0 && y < y_v)
                    {
                        
                        switch ((x + y) % 5)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                        }

                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        Console.ResetColor();
                    }
                    else
                    {
                    }
                    switch (direction)
                    {
                        case 0: 
                            x++;
                            break;
                        case 1:
                            y++;
                            break;
                        case 2: 
                            x--;
                            break;
                        case 3: 
                            y--;
                            break;
                    }
                }
                direction = (direction + 1) % 4;
           
                if (direction == 0 || direction == 2)
                {
                    steps = steps + 3;
                }

            } while (x >= 0 && x < x_v && y >= 0 && y < y_v);








        }
    }
}
