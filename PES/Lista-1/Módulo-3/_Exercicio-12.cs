using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_34
{
    class exercicio_34
    {
        static void Main(string[] args)
        {
            double num1, num2, res, count, count1;
            count = -1;
            count1 = 1;
            num1 = 1;
            num2 = 2;
            res = 0;
            while (count < 0 || count > 50)
            {
                Console.Write("Entre o número de valores da sequência entre 1 a 50: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count < 0 || count > 50)
                {
                    Console.WriteLine("Número invalido.");
                }
            }

            while (count1 <= count)
            {
                res = num1 / num2;
                Console.WriteLine("O numero {0} da sequência é {1}", count1, res);
                num1 = num2;
                num2 = num1 + 1;
                count1++;
            }

            Console.ReadLine();
        }
    }
}
