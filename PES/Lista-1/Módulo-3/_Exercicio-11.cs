using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_33
{
    class exercicio_33
    {
        static void Main(string[] args)
        {
            double num1, num3, count, count1;
            num1 = 2;
            num3 = 3;
            count = -1;
            count1 = 1;

            while (count < 0 || count > 100)
            {
                Console.Write("Entre o número de valores da sequência entre 1 a 100: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count < 0 || count > 100)
                {
                    Console.WriteLine("Número invalido.");
                }
            }
            while (count1 <= count)
            {
                Console.WriteLine("O numero {0} da sequência é {1}", count1, num1);
                num1 = num1 + num3;
                num3 = num3 + 2;
                count1++;
            }
            Console.ReadLine();
        }
    }
}
