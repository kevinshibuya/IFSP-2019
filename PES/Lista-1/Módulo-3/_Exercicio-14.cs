using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_36
{
    class exercicio_36
    {
        static void Main(string[] args)
        {
            double n, higher, average, add;
            add = 0;
            higher = 0;
            average = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter the number {0}: ", i);
                n = Convert.ToDouble(Console.ReadLine());

                while (n < 0)
                {
                    Console.WriteLine("Number must be greater than or equal 0.");
                    Console.Write("Enter number again: ");
                    n = Convert.ToDouble(Console.ReadLine());
                }

                if (n > higher)
                {
                    higher = n;
                }

                add = add + n;

                average = add / 10;
            }

            Console.WriteLine("The higher number is {0}.", higher);
            Console.WriteLine("The addition of all numbers is {0}.", add);
            Console.WriteLine("The average of all 10 numbers is {0}.", average);
            Console.ReadLine();
        }
    }
}
