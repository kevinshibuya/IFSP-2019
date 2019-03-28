using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, res, ft;

            Console.Write("Write student first grade: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write student second grade: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write student third grade: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            res = ((n1 * 4) + (n2 * 5) + (n3 * 6)) / 15;

            if (res < 3)
            {
                Console.WriteLine("You have been reproved.");
            }
            else if (res >= 3 && res < 6)
            {
                Console.WriteLine("You must do final test.");

                Console.Write("Enter your final test grade: ");
                ft = Convert.ToInt32(Console.ReadLine());

                res = (res + ft) / 2;

                if (res >= 6)
                {
                    Console.WriteLine("You have been approved.");
                }
                else
                {
                    Console.WriteLine("You have been reproved.");
                }
            }
            else
            {
                Console.WriteLine("You have been approved.");
            }

            Console.ReadLine();
        }
    }
}
