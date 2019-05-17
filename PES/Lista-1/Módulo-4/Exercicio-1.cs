using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_04
{
    class exercicio_1
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(var i = 0; i <= 9; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (var i = 9; i >= 0; i--)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadLine();
        }
    }
}
