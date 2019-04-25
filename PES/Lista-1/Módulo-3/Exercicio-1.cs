using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_3
{
    class exercicio_23
    {
        static void Main(string[] args)
        {
            int x = -1;

            while (x < 0)
            {
                Console.Write("Enter a positive number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (x < 0)
                {
                    Console.WriteLine("That is not a positive number.\n");
                }
                else if(x >= 0)
                {
                    Console.WriteLine("That is indeed a positive number.\n");
                }

            }
            Console.WriteLine("You entered a positive number, great job!");

            Console.ReadLine();
        }
    }
}
