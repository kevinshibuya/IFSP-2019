using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_9
{
    class exercise_9
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter number A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("A is less than B.");
            }
            else if (a > b)
            {
                Console.WriteLine("B is less than A.");
            }

            Console.ReadLine();
        }
    }
}
