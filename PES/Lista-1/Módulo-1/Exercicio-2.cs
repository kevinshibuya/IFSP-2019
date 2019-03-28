using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class exercicio_2
    {
        static void Main(string[] args)
        {
            double x;

            Console.WriteLine("This will calculate the area of a square.\n");
            Console.Write("Enter the edge value: ");
            x = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);

            x = x * x;

            Console.WriteLine("The area of the square is {0}.", x);

            Console.ReadLine();
        }
    }
}
