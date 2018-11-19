using System;
using System.ComponentModel;
using System.Data.Common;
using System.Threading;

namespace Bartosz_Adventure
{
    internal class Program
    {
        static void textColor(string color)
        {
            // Same thing here, maybe try and loop this instead of all these switch cases?
            
            switch (color)
            {
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "darkBlue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkCyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "darkGray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "darkGreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkMagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkRed":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkYellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        
        static void lineColor(string color)
        {
            switch (color)
            {
                case "black":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case "gray":
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "magenta":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "white":
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case "darkBlue":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkCyan":
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    break;
                case "darkGray":
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case "darkGreen":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkMagenta":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkRed":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkYellow":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }
        }
        
        static void display(string input) // Making rich text module
        {
            char[] text = input.ToCharArray();
            string color = "b";
            string[] colors = new string[] {"black", "blue", "cyan", "gray", "green", "magenta", "red", "white", "yellow", "darkBlue", "darkCyan", "darkGray", "darkGreen", "darkMagenta", "darkRed", "darkYellow"};
            
            // Perhaps try and create a loop to check which color to use instead of all these if statements? Kinda messy. It's hard though, I'll look into it later?
            
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '`':
                        // Black
                        if (text[i + 1] == 'B' && text[i + 2] == 'A')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("black");
                        }
                        
                        // Blue
                        if (text[i + 1] == 'B' && text[i + 2] == 'U')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("blue");
                        }
                        
                        // Cyan
                        if (text[i + 1] == 'C')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            lineColor("cyan");
                        }
                        
                        // Gray
                        if (text[i + 1] == 'G' && text[i + 2] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("gray");
                        }
                        
                        // Green
                        if (text[i + 1] == 'G' && text[i + 2] == 'N')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("green");
                        }
                        
                        // Magenta
                        if (text[i + 1] == 'M')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            lineColor("magenta");
                        }
                        
                        // Red
                        if (text[i + 1] == 'R')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            lineColor("red");
                        }
                        
                        // White
                        if (text[i + 1] == 'W')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            lineColor("white");
                        }
                        
                        // Yellow
                        if (text[i + 1] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            lineColor("yellow");
                        }
                        
                        // Dark Blue
                        if (text[i + 1] == 'D' && text[i + 2] == 'B')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("darkBlue");
                        }
                        
                        // Dark Cyan
                        if (text[i + 1] == 'D' && text[i + 2] == 'C')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("darkCyan");
                        }
                        
                        // Dark Gray
                        if (text[i + 1] == 'D' && text[i + 2] == 'G' && text[i + 3] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            text[i + 3] = '\0';
                            lineColor("darkGray");
                        }
                        
                        // Dark Green
                        if (text[i + 1] == 'D' && text[i + 2] == 'G' && text[i + 3] == 'N')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            text[i + 3] = '\0';
                            lineColor("darkGreen");
                        }
                        
                        // Dark Magenta
                        if (text[i + 1] == 'D' && text[i + 2] == 'M')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("darkMagenta");
                        }
                        
                        // Dark Red
                        if (text[i + 1] == 'D' && text[i + 2] == 'R')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("darkRed");
                        }
                        
                        // Dark Yellow
                        if (text[i + 1] == 'D' && text[i + 2] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            lineColor("darkYellow");
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
                    
                    case '\\':
                        // Black
                        if (text[i + 1] == 'B' && text[i + 2] == 'A')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("black");
                        }
                        
                        // Blue
                        if (text[i + 1] == 'B' && text[i + 2] == 'U')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("blue");
                        }
                        
                        // Cyan
                        if (text[i + 1] == 'C')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            textColor("cyan");
                        }
                        
                        // Gray
                        if (text[i + 1] == 'G' && text[i + 2] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("gray");
                        }
                        
                        // Green
                        if (text[i + 1] == 'G' && text[i + 2] == 'N')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("green");
                        }
                        
                        // Magenta
                        if (text[i + 1] == 'M')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            textColor("magenta");
                        }
                        
                        // Red
                        if (text[i + 1] == 'R')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            textColor("red");
                        }
                        
                        // White
                        if (text[i + 1] == 'W')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            textColor("white");
                        }
                        
                        // Yellow
                        if (text[i + 1] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            textColor("yellow");
                        }
                        
                        // Dark Blue
                        if (text[i + 1] == 'D' && text[i + 2] == 'B')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("darkBlue");
                        }
                        
                        // Dark Cyan
                        if (text[i + 1] == 'D' && text[i + 2] == 'C')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("darkCyan");
                        }
                        
                        // Dark Gray
                        if (text[i + 1] == 'D' && text[i + 2] == 'G' && text[i + 3] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            text[i + 3] = '\0';
                            textColor("darkGray");
                        }
                        
                        // Dark Green
                        if (text[i + 1] == 'D' && text[i + 2] == 'G' && text[i + 3] == 'N')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            text[i + 3] = '\0';
                            textColor("darkGreen");
                        }
                        
                        // Dark Magenta
                        if (text[i + 1] == 'D' && text[i + 2] == 'M')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("darkMagenta");
                        }
                        
                        // Dark Red
                        if (text[i + 1] == 'D' && text[i + 2] == 'R')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("darkRed");
                        }
                        
                        // Dark Yellow
                        if (text[i + 1] == 'D' && text[i + 2] == 'Y')
                        {
                            text[i] = '\0';
                            text[i + 1] = '\0';
                            text[i + 2] = '\0';
                            textColor("darkYellow");
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
            display("`DR\\WThis is a test.");

            Console.ReadLine();
        }
    }
}