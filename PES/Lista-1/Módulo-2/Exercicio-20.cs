using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double gas, pay;

            Console.Write("Enter how much the gas is costing per liter: ");
            gas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter how much money you have: ");
            pay = Convert.ToDouble(Console.ReadLine());

            gas = pay / gas;

            Console.WriteLine("You can buy {0} liters of gas.", gas);
            Console.ReadLine();
        }
    }
}
