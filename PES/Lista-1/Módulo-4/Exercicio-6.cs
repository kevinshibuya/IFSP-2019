using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[5];
            string[] name = new string[5];

            for(var i = 0; i < 5; i++)
            {
                Console.Write("Enter the name: ");
                name[i] = Console.ReadLine();
                Console.Write("Enter the age: ");
                age[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. Name is " + name[i] + "and age " + age[i] + ".", i + 1);
            }

            Console.ReadLine();
        }
    }
}
