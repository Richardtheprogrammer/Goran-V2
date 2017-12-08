using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace Goran
{
    class Program
    {
        private static ResourceSet _resource;
        private static string _currrentLanguage;

        static void Main(string[] args)
        {
            SetLanguage("sv-SE");
            STARTMENU();
           
        }

        private static void Stefan()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            SetLanguage("en-US");
            Console.WriteLine(GetStringValue("Menu_Color"));
            var c = new CultureInfo("sv-SE");
            SetLanguage("sv-SE");
            Console.WriteLine(GetStringValue("Menu_Color"));
            SetLanguage("fr-FR");
            Console.WriteLine(GetStringValue("Menu_Color"));
            SetLanguage("nb-NO");
            Console.WriteLine(GetStringValue("Menu_Color"));

            Console.ReadLine();

        }

        private static void SetLanguage(string language)
        {
            _resource = Goran.Resources.Resources.ResourceManager.GetResourceSet(new CultureInfo(language), true, true);
            _currrentLanguage = language;
        }
   
        private static string GetStringValue(string input)
        {
            return _resource.GetString(input);
        }

       //inställningar/
        static void INSTÄLLNINGARMENU()
        {
            Console.WriteLine("1)Höjd");
            Console.WriteLine("2)Bredd");
            Console.WriteLine("3)Tillbaka");
            ConsoleKeyInfo Usettings;
            Usettings = Console.ReadKey(true);
            INSTÄLLNINGAR(Usettings);
        }

        static void INSTÄLLNINGAR(ConsoleKeyInfo input)
        {
            switch (input.KeyChar)
            {
                case '1':
                    Console.Clear();
                    HHEIGHTMENU();

                    break;

                case '2':
                    Console.Clear();
                    WWIDTHMENU();
                    break;

                case '3':
                    Console.Clear();
                    STARTMENU();

                    break;

            }
        }
        //inställningar slutar
        //HEIGHT STARTS
        static void HHEIGHTMENU()
        {

        }

        static void HHEIGHT()
        {

        }
            //HEIGHT ENDS

            
            //WIDTH STARTS
            static void WWIDTHMENU()
        {
            Console.WriteLine("1)50");
            Console.WriteLine("2)100");
            Console.WriteLine("3)150");
            Console.WriteLine("4)200");
            Console.WriteLine("5)250");
            Console.WriteLine("6)300");
            Console.WriteLine("7)MAX");
            Console.WriteLine("8)Tillbaka");
            ConsoleKeyInfo UWIDTH;
            UWIDTH = Console.ReadKey(true);
            WWIDTH(UWIDTH);

        }

        static void WWIDTH(ConsoleKeyInfo input)
        {
            switch(input.KeyChar)
            {
                case '1':
                    Console.WindowWidth = 50;
                    Console.Clear();
                    WWIDTHMENU();

                    break;

                case '2':
                    Console.WindowHeight = 50;
                    Console.Clear();
                    WWIDTHMENU();
                    break;

                case '3':
                    Console.WindowHeight = 100;
                    Console.Clear();
                    WWIDTHMENU();
                    break;

                case '4':
                    Console.WindowHeight = 150;
                    Console.Clear();
                    WWIDTHMENU();
                    break;

                case '5':
                    Console.WindowHeight = 200;
                    Console.Clear();
                    WWIDTHMENU();
                    break;

                case '6':
                    Console.WindowHeight = 300;
                    Console.Clear();
                    WWIDTHMENU();
                    break;

                case '7':
                    Console.WindowHeight = 320;
                    Console.Clear();
                    WWIDTHMENU();
                    break;

                case '8':
                    Console.Clear();
                    STARTMENU();
                    break;

            }
        }
            //WIDTH ENDS

            //orginalkod för läsa in textfiler//
        static void OrginalKod()
        {
            try
            {


                var lines = File.ReadAllLines("CREDIT_MONGO.txt", Encoding.GetEncoding("windows-1252"));
                lines.ToList().ForEach(line => Console.WriteLine(line));
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.ReadKey(true);
            }

        }
        //ENDS//

        
      

            // WEBB STARTS
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
        //WEB ENDS

        static void MENU()
        {
            Console.WriteLine($"1){GetStringValue("Menu_Color")}");
            Console.WriteLine($"2){GetStringValue("Menu_Settings")}");
            Console.WriteLine($"3){GetStringValue("Menu_Credits")}");
            Console.WriteLine($"4){GetStringValue("Menu_Github")}");
            Console.WriteLine($"5){GetStringValue("Menu_Language")}");
            Console.WriteLine($"6){GetStringValue("Menu_Exit")}");
            var input = Console.ReadLine().Trim();
            MENUUPPDELNINGEN(input);

         

        }

       
        //ändrad nedanför//
        static void MENUUPPDELNINGEN(string input)
        {
            switch (input)
            {
                case "0":
                    Environment.Exit(0);
                    break;

                case "1":
                    Console.Clear();
                    FÄRGMENU();

                    break;

                case "2":
                    Console.Clear();
                    INSTÄLLNINGARMENU();
                    break;

                case "3":
                    Console.Clear();
                    OrginalKod();
                    Console.ReadKey(true);
                    Console.Clear();
                    STARTMENU();
                    break;

                case "4":
                    Console.Clear();
                    WEBBROWSERMENU();
                    break;

                case "5":
                    Console.Clear();
                    if (_currrentLanguage == "en-US")
                    {
                        SetLanguage("sv-SE");
                    }
                    else
                    {
                        SetLanguage("en-US");
                    }
                    STARTMENU();
                    break;
                default: 
                    Console.Clear();
                    Console.WriteLine("använd endast de siffror som står där");
                    Console.ReadKey(true);
                    Console.Clear();
                    STARTMENU();
                    break;
            }
        }
        
        static void STARTMENU()
        {

            Console.Title = "MENU";
            Console.WriteLine("††††††††††††††††††††††††††††††††††††††††††††");
            Console.WriteLine("†                                          †");
            Console.WriteLine("†       0   0                              †");
            Console.WriteLine("†                                          †");
            Console.WriteLine("† 00000  00000  00000   00000  0         0 †");
            Console.WriteLine("† 0   0  0   0  0   0   0   0  0 0       0 †");
            Console.WriteLine("† 0   0  0   0  00000   0   0  0   0     0 †");
            Console.WriteLine("† 00000  0   0  000     00000  0     0   0 †");
            Console.WriteLine("† 0      0   0  0  0    0   0  0       0 0 †");
            Console.WriteLine("† 0      0   0  0   0   0   0  0        00 †");
            Console.WriteLine("† 00000  00000  0    0  0   0  0         0 †");
            Console.WriteLine("†                                          †");
            Console.WriteLine("††††††††††††††††††††††††††††††††††††††††††††");
            MENU();

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
