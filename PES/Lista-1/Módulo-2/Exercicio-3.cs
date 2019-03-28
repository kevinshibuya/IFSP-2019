using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_10
{
    class exercise_10
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter number A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A is greater than B.");
            }
            else if (a < b)
            {
                Console.WriteLine("B is greater than A.");
            }
            else
            {
                Console.WriteLine("Both numbers are identical.");
            }

            Console.ReadLine();
        }
    }
}
