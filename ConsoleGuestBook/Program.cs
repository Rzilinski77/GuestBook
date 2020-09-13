using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGuestBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Event!");
            List<string> guestList = new List<string>();
            int guestCount = 0;
            string cont = "y";
            Console.WriteLine();
            do
            {
                guestList.Add(GetName());
                guestCount = GetGuestCount(guestCount);
                Console.Write("Do you want to continue(y/n): ");
                cont = Console.ReadLine();
            } while (cont.ToLower() == "y");
            Console.WriteLine();
            PrintGuestList(guestList);
            Console.WriteLine();
            PrintGuestCount(guestCount);
            Console.WriteLine();
        }

        private static string GetName()
        {
            Console.Write("Hello, what is your name: ");
            string name = Console.ReadLine();

            return name;
        }

        private static int GetGuestCount(int guestCount)
        {
            Console.Write("How many people do you have in your party (ex: 5): ");
            string num = Console.ReadLine();

            bool check = int.TryParse(num, out int newnum);


            if (check == true)
            {
                guestCount += newnum;
                return guestCount;
            }
            else
            {
                Console.WriteLine("Please call ahead for further assistance");
                return guestCount;
            }
        }

        private static void PrintGuestList(List<string> guestList)
        {
            foreach  (string name in guestList)
            {
                Console.WriteLine(name);
            }
        }
        
        private static void PrintGuestCount(int guestCount)
        {
            Console.WriteLine($"Total Guestcount: {guestCount}");
        }
    }
}
