using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilo, price;

            price = 23.00;

            Console.WriteLine("A restaurant charges ${0} per kilo.", price);
            Console.Write("Enter how many kilos your plate has: ");
            kilo = Convert.ToDouble(Console.ReadLine());

            price = kilo * price;

            Console.WriteLine("You need to pay ${0} for your food.", price);
            Console.ReadLine();
        }
    }
}
