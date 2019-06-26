using System;
using System.Linq;

namespace Daty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Your dates:");
            string input = Console.ReadLine();

                string[] split = input.Split('.', ' ');
                bool isNumeric = split.All(s => s.All(Char.IsDigit));
                if (isNumeric == false)
                {
                    Console.WriteLine("Dates must be numeric");

                }
               else
            { 
                if (split[1] == split[4] && split[2] == split[5])
                {
                    Console.WriteLine($"{split[0]} - {split[3]}.{split[4]}.{split[5]}");
                }
                if (split[2] == split[5])
                {
                    Console.WriteLine($"{split[0]}.{split[1]} - {split[3]}.{split[4]}.{split[5]}");
                }
                else
                {
                    Console.WriteLine($"{split[0]}.{split[1]}.{split[2]} - {split[3]}.{split[4]}.{split[5]}");
                }
                Console.ReadKey();
            }
        }
    }
}
