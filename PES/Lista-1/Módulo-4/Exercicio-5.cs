using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            int quant, check, ask;

            do {
                Console.WriteLine("Enter how many numbers you want the array to have, must be 20 at max.");
                Console.Write("Enter: ");
                quant = Convert.ToInt32(Console.ReadLine());
            } while (quant < 1 || quant > 20);

            int[] nums = new int[quant];

            for (var i = 0; i < quant; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            while (loop)
            {
                Console.Write("Enter a number you want to check where in the array it's: ");
                check = Convert.ToInt32(Console.ReadLine());

                for (var i = 0; i < quant; i++)
                {
                    if (check == nums[i])
                    {
                        Console.WriteLine("The number {0}, is at the index {1} on the array.", check, i);
                    }
                    else
                    {
                        Console.WriteLine("Value not found!");
                    }
                }

                do {
                    Console.Write("Do you want to go again? Type 1 for yes and 0 for no: ");
                    ask = Convert.ToInt32(Console.ReadLine());
                } while (ask != 1 && ask != 0);
                
                if (ask == 0)
                {
                    loop = false;
                }
            }

            Console.WriteLine("You quitted the program!");

            Console.ReadLine();
        }
    }
}
