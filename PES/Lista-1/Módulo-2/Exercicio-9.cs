using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_16
{
    class exercise_16
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool triangle;

            Console.Write("Entra um lado: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entra outro lado: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entra mais um lado: ");
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

            if (triangle && a + b == c || a + c == b || b + c == a)
            {
                Console.WriteLine("It is an equilateral triangle.");
            }
            else
            {
                Console.WriteLine("It is not and equilateral triangle.");
            }

            Console.ReadLine();
        }
    }
}
