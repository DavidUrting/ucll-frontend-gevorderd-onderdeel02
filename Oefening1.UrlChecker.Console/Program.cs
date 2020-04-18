using System;

namespace Oefening1.UrlChecker.Console
{
    class Program
    {
        private static UrlChecker _urlChecker = new UrlChecker();

        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.Write("URL (press Q to quit): ");
                string url = System.Console.ReadLine();
                if (url.ToUpper() == "Q") break;
                if (_urlChecker.CheckUrl(url))
                {
                    System.Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("OK.");
                }
                else
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Not a valid URL.");
                }
                System.Console.ResetColor();
            }
        }
    }
}