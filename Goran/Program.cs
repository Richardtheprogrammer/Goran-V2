using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Goran
{
    class Program
    {
        static void Main(string[] args)
        {

           

            STARTMENU();

        }

        
   

       
        static void INSTÄLLNINGARMENU()
        {

        }

        static void INSTÄLLNINGAR()
        {

        }


        static void CREDIT()
        {
            try
            {
                using (StreamReader sr = new StreamReader("CREDIT_MONGO.txt", Encoding.GetEncoding("windows-1252")))
                {
                    string line;

                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                     
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.ReadKey(true);
            }
        }

        static void WEBBROWSERMENU()
        {
            Console.WriteLine("1)chrome");
            Console.WriteLine("2)firefox");
            Console.WriteLine("3)opera");
            Console.WriteLine("4)tillbaka");
            ConsoleKeyInfo webbs;
            webbs = Console.ReadKey(true);
            WEBBROWSERS(webbs);

        }

        static void WEBBROWSERS(ConsoleKeyInfo input)
        {
            switch (input.KeyChar)
            {
                case '1':
                    var cprs = new ProcessStartInfo("chrome.exe");
                    cprs.Arguments = "https://github.com/Richardtheprogrammer";
                    Process.Start(cprs);
                    Console.Clear();
                    STARTMENU();
                    break;

                case '2':
                    Console.Title = "Firefox";
                    var fprs = new ProcessStartInfo("firefox.exe");
                    fprs.Arguments = "https://github.com/Richardtheprogrammer";
                    Process.Start(fprs);
                    Console.Clear();
                    STARTMENU();
                    break;

                case '3':
                    Console.Title = "Opera";
                    var oprs = new ProcessStartInfo("opera.exe");
                    oprs.Arguments = "https://github.com/Richardtheprogrammer";
                    Process.Start(oprs);
                    Console.Clear();
                    STARTMENU();
                    break;

                case '4':
                    Console.Clear();
                    STARTMENU();
                    break;

            }
        }

        static void UPPDELNING()
        {
            Console.WriteLine("1)FÄRG");
            Console.WriteLine("2)INSTÄLLNINGAR");
            Console.WriteLine("3)CREDITS");
            Console.WriteLine("4)GITHUB");
            ConsoleKeyInfo Muppspelning;
            Muppspelning = Console.ReadKey(true);
            MENUUPPDELNINGEN(Muppspelning);

         

        }




        //ändrad nedanför//
        static void MENUUPPDELNINGEN(ConsoleKeyInfo input)
        {
            switch (input.KeyChar)
            {
                case '1':
                    Console.Clear();
                    FÄRGMENU();

                    break;

                case '2':
                    Console.Clear();
                    INSTÄLLNINGARMENU();
                    break;

                case '3':
                    Console.Clear();
                    CREDIT();
                    Console.ReadKey(true);
                    Console.Clear();
                    STARTMENU();
                    break;

                case '4':
                    Console.Clear();
                    WEBBROWSERMENU();
                    break;
            }
        }
        
        static void STARTMENU()
        {
            Console.Title = "MENU";
            Console.WriteLine("       0   0");
            Console.WriteLine("                                        ");
            Console.WriteLine("00000  00000  00000   00000  0         0");
            Console.WriteLine("0   0  0   0  0   0   0   0  0 0       0");
            Console.WriteLine("0   0  0   0  00000   0   0  0   0     0");
            Console.WriteLine("00000  0   0  000     00000  0     0   0");
            Console.WriteLine("0      0   0  0  0    0   0  0       0 0");
            Console.WriteLine("0      0   0  0   0   0   0  0        00");
            Console.WriteLine("00000  00000  0    0  0   0  0         0");
            UPPDELNING();
        }

        static void FÄRGER(ConsoleKeyInfo input)
        {
          
            switch(input.KeyChar)
            {
                case '1':
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    STARTMENU();
                    break;

                case '2':
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    STARTMENU();
                    break;

                case '3':
                    Console.ResetColor();
                    Console.Clear();
                    STARTMENU();
                    break;

                case '4':
                    Console.Clear();
                    STARTMENU();
                    break;

            }
        }

        static void FÄRGMENU()
        {
            Console.WriteLine("1)mörk");
            Console.WriteLine("2)ljus");
            Console.WriteLine("3)återställ");
            Console.WriteLine("4)tillbaka");
            ConsoleKeyInfo Gfärger;
            Gfärger = Console.ReadKey(true);
            FÄRGER(Gfärger);
        }
    }
}
