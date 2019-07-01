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
            int firstDay = Convert.ToInt32(split[0]);
            int secondDay = Convert.ToInt32(split[3]);
            int firstMonth = Convert.ToInt32(split[1]);
            int secondMonth = Convert.ToInt32(split[4]);
            int firstYear = Convert.ToInt32(split[2]);
            int secondYear = Convert.ToInt32(split[5]);

            if (isNumeric == false)
            {
                Console.WriteLine("Dates must be numeric");
            }
            else if (firstDay < 1 || firstDay > 31 || secondDay < 1 || secondDay > 31)
            {
                Console.WriteLine("Date is incorrect");
            }
            else if (firstMonth < 1 || firstMonth > 12 || secondMonth < 1 || secondMonth > 12)
            {
                Console.WriteLine("Date is incorrect");
            }
            else if (firstYear < 1 || firstYear > 9999 || secondYear < 1 || secondYear > 9999)
            {
                Console.WriteLine("Date is incorrect");
            }
            else
            {
                if (split[1] == split[4] && split[2] == split[5])
                {
                    Console.WriteLine($"{split[0]} - {split[3]}.{split[4]}.{split[5]}");
                }
                else if (split[2] == split[5])
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
