/// give credits or gay

using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using vitalpaste4u;

namespace vitalpaste4u
{
    /// Imagine need help pasting a simple ass c# spoofer dickhead
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Welcome to 6locc 6a6y Spoofer. If you paid for this you were scammed";
            string title = "vitalcheats4u.com";
            MessageBox.Show(message, title);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Process.Start("https://discord.gg/aaACUux2bB");  
            Console.WriteLine("Press [Enter] to start");
            Console.WriteLine();
            Console.ReadKey();

            ShowSimplePercentage();

            Console.ReadKey();
        }

        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" \rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\r Done!          ");
            Console.Clear();
        Menu:
            Console.ForegroundColor = ConsoleColor.Cyan;  
            Console.WriteLine();
            String Header = "                ██████  ██       ██████   ██████  ██████      ██████   █████   ██████ ██    ██     \n               ██       ██      ██    ██ ██      ██          ██       ██   ██ ██       ██  ██    \n               ███████  ██      ██    ██ ██      ██          ███████  ███████ ███████   ████     \n               ██    ██ ██      ██    ██ ██      ██          ██    ██ ██   ██ ██    ██   ██      \n                ██████  ███████  ██████   ██████  ██████      ██████  ██   ██  ██████    ██           \n  ";
            Console.Title = "[vitalcheats4u.com] Public Spoofer [Source : https://github.com/VITAL9999l/spoofer]"; /// your skidded shit title here 
            Console.WriteLine(Header);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                          ========================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                              vitalcheats4u.com");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                          ========================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                           [1] Spoof  |  [2] Clean");  /// start cleaning or spoofing 
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" [+] Select your option :  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string option = Console.ReadLine();

            if (option == "1")
            {
                MessageBox.Show(" Spoofing");
                Spoofer.Spoof();
                MessageBox.Show(" Done!"); 
                goto Menu;
            }
            else if (option == "2")
            {
                MessageBox.Show(" Cleaning"); 
                Spoofer.Clean();
                MessageBox.Show(" Done!");
                goto Menu;

            }
            else
            {
                Console.Clear();
                Console.WriteLine(" Wrong button try again!");
                Thread.Sleep(2000);
                Console.Clear();
                goto Menu;
            }
        }
    }
}
