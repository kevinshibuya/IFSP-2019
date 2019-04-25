using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_24
{
    class exercicio_24
    {
        static void Main(string[] args)
        {
            int x, y;


            Console.WriteLine("The second value must be greater than the first: ");
            System.Threading.Thread.Sleep(2000);
            Console.Write("Enter a value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another value: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);

            while (x > y)
            {
                Console.WriteLine("The first value is greater than the second...");
                Console.Write("Enter the second value again: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                System.Threading.Thread.Sleep(2000);
            }

            Console.WriteLine("The second value is greater than the first!");

            Console.ReadLine();
        }
    }
}
