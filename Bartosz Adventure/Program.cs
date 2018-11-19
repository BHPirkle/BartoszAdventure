using System;
using System.Data.Common;
using System.Threading;

namespace Bartosz_Adventure
{
    internal class Program
    {
        static void setColor(string color)
        {
            // Same thing here, maybe try and loop this instead of all these switch cases?
            
            switch (color.ToLower())
            {
                case "ba":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "bu":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "c":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "gy":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "gn":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "m":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "r":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "w":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "y":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "db":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "dc":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "dgy":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "dgn":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "dm":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "dr":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dy":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        
        static void display(string input) // Making rich text module
        {
            char[] text = input.ToCharArray();
            
            // Perhaps try and create a loop to check which color to use instead of all these if statements? Kinda messy.
            
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '\\':
                        // Yellow
                        if (text[i + 1] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            setColor("y");
                        }
                        
                        // Blue
                        if (text[i + 1] == 'B')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            setColor("bu");
                        }
                        
                        // Red
                        if (text[i + 1] == 'R')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            setColor("r");
                        }
                        
                        // Green
                        if (text[i + 1] == 'G')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            setColor("g");
                        }

                        // Dark Yellow
                        if (text[i + 1] == 'D' && text[i + 2] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            setColor("dy");
                        }
                        
                        // Dark Red
                        if (text[i + 1] == 'D' && text[i + 2] == 'R')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            setColor("dr");
                        }
                        
                        // White
                        if (text[i + 1] == 'W')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            setColor("w");
                        }
                        
                        // Longer pause, seconds based on number after \L (example: \L1 will extend the wait by 1 second)
                        if (text[i + 1] == 'L' && int.Parse(text[i + 2].ToString()) > 0)
                        {
                            int customSleep = int.Parse(text[i + 2].ToString());
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            Thread.Sleep(customSleep * 100);
                        }

                        break;
                    case '.':
                        Console.Write(text[i]);
                        Thread.Sleep(150);

                        break;
                    case ',':
                        Console.Write(text[i]);
                        Thread.Sleep(150);

                        break;
                    default:
                        if (text[i] != '\0')
                        {
                            Console.Write(text[i]);
                            Thread.Sleep(35);
                        }
                        
                        break;
                }
            }
        }
        
        public static void Main(string[] args)
        {
        }
    }
}