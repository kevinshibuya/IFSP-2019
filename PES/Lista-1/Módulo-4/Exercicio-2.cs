using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int high;
            int[] nums = new int[10];

            for (var i = 0; i <= 9; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            high = nums[0];

            for (var i = 0; i <= 9; i++)
            {
                if (nums[i] > high)
                {
                    high = nums[i];
                }
            }

            Console.WriteLine("The highest number is {0}.", high);
            Console.ReadLine();
        }
    }
}
