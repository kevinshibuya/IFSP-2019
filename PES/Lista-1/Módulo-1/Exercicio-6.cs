using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_6
{
    class exercicio_6
    {
        static void Main(string[] args)
        {
            double val, dol, real;

            Console.WriteLine("This will convert dollars to reais according to the cotation.\n");
            Console.Write("Enter the dolar cotation: ");
            val = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter how many dolars: ");
            dol = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);

            real = val * dol;

            Console.WriteLine("The Conversion from dollars to reais is {0}.", real);

            Console.ReadLine();
        }
    }
}
