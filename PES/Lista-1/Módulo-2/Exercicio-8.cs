using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_15
{
    class exercise_15
    {
        static void Main(string[] args)
        {
            double a, b, c;
            bool triangle;

            Console.Write("Entre o valor A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre o valor B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre o valor C: ");
            c = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);

            if (a + b >= c)
            {
                Console.WriteLine("It is a triangle");
                triangle = true;
            }
            else if (a + c >= b)
            {
                Console.WriteLine("It is a triangle");
                triangle = true;
            }
            else if (b + c >= a)
            {
                Console.WriteLine("It is a triangle");
                triangle = true;
            }
            else
            {
                Console.WriteLine("It is not a triangle");
                triangle = false;
            }

            if (triangle && a != b && a != c && b != c)
            {
                Console.WriteLine("It is an Scalene triangle.");
            }
            else if (triangle && a == b && a == c && b == c)
            {
                Console.WriteLine("It is an Equilateral triangle.");
            }
            else if (triangle && a == b || a == c || b == c)
            {
                Console.WriteLine("It is an Isosceles triangle.");
            }

            Console.ReadLine();
        }
    }
}
