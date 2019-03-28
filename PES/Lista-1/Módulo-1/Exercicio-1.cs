using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_1_entrada_processamento_saida
{
    class exercicio_1
    {
        static void Main(string[] args)
        {
            double x, y, r;

            Console.WriteLine("This will calculate the area of a rectangle.\n");
            Console.Write("Enter the base value: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the high value: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);

            r = x * y;

            Console.WriteLine("The area of the rectangle is {0}.", r);

            Console.ReadLine();
        }
    }
}
