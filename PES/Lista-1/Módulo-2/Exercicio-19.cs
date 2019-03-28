using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, op1, op2, op3, choose;

            Console.WriteLine("Ms. Maria wants to buy a purse.");
            Console.Write("Enter how much the purse will cost: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ms. Maria had 3 options to buy her purse.");
            Console.WriteLine("1 - In cash with 10% discount.");
            Console.WriteLine("2 - Parcelled 3 times with no discount.");
            Console.WriteLine("3 - Parcelled 10 times with 5% interest on the total value.");
            Console.Write("Choose the best option for Ms. Maria: ");
            choose = Convert.ToInt32(Console.ReadLine());

            op1 = p * 0.9;
            op2 = p / 3;
            op3 = (p * 1.05) / 10;

            if (choose == 1)
            {
                Console.WriteLine("Ms. Maria will pay {0} on her purse", op1);
            }
            else if (choose == 2)
            {
                Console.WriteLine("Ms. Maria will pay 3 parcels of {0} on her purse.", op2);
            }
            else if (choose == 3)
            {
                Console.WriteLine("Ms. Maria will pay 10 parcels of {0} on her purse.", op3);
            }
            else
            {
                Console.WriteLine("Invalid operation.");
            }

            Console.ReadLine();
        }
    }
}
