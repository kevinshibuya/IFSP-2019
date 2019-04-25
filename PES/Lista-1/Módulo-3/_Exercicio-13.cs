using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_35
{
    class exercicio_35
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, res, count1, count;

            count1 = 1;
            count = -1;
            num1 = 2;
            num2 = 3;
            num4 = 1;
            num3 = 1;
            res=0;

            while (count <= 0 || count > 50)
            {
                Console.Write("Entre o número de valores da sequência entre 1 a 50: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count <= 0 || count > 50)
                {
                    Console.WriteLine("Número invalido.");
                }
            }

            while (count1 <= count)
            {
                num3 = Math.Pow(num4, 3);
                num4++;

                Console.WriteLine("O numero {0} da sequência é {1}/{2}", count1, num1, num3);

                num1 = num1 + num2;
                num2 = num2 + 2;

                count1++;
            }

            Console.ReadLine();
        }
    }
}
