using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7
{
    class exercicio_7
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, pay, change;

            Console.WriteLine("This will calculate the change of a purchase.\n");
            Console.Write("Enter the first value: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second value: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third value: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fourth value: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fifth value: ");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);

            e = a + b + c + d + e;

            Console.WriteLine("You will need to pay {0} dollars.", e);
            Console.Write("How much money entered: ");
            pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);

            change = pay - e;

            Console.WriteLine("The change of your purchase is {0} dollars.", change);

            Console.ReadLine();
        }
    }
}
