using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_13
{
    class exercise_13
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter number A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number C: ");
            c = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);

            if (a > b && a > c)
            {
                Console.WriteLine("A is the biggest number.");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is the biggest number.");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("C is the biggest number.");
            }

            Console.ReadLine();
        }
    }
}
