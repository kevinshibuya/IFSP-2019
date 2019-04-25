using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_32
{
    class exercicio_32
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, res, count;
            num1 = 1;
            num2 = 1;
            num3 = -1;
            count = 1;

            while (count <= 20)
            {
                res = num1 + num2 + num3;
                num1 = num2;
                num2 = num3;
                num3 = res;
                Console.WriteLine("O número {0} da sequência é {1}", count, res);
                count++;
            }
            Console.ReadLine();
        }
    }
}
