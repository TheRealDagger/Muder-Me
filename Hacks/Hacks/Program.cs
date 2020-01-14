using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           


            Console.WriteLine("Welcome to the Hacks for school BAT\r");
            Console.WriteLine("------------------------\n");


            Console.WriteLine("What is your name");
            String Name = (Console.ReadLine());


            Console.WriteLine("Student ID number");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("a - Free School Browsing\ns - Wsfcs login\nm - Discord\nd - Website to buy stuff");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: https://chrome.google.com/webstore/detail/croxyproxy-free-web-proxy/lmmpgfjnchldhcieiiegcpdmaidkaanb?hl=en");
                    break;
                case "s":
                    Console.WriteLine($"Your result: wskadmin:wKs@dm1n! ");
                    break;
                case "m":
                    Console.WriteLine($"Your result: https://discord.gg/Er4v4je");
                    break;
                case "d":
                    Console.WriteLine($"Your result: Sorry Not done ");
                    break;
            }
            Console.Write("Press any key to close the Hacks app.......");
            Console.ReadKey();
        }
    }
}
