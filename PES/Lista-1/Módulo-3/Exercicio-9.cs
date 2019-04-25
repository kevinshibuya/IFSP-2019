using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_31
{
    class exercicio_31
    {
        static void Main(string[] args)
        {
            double num1, num2, count;
            num1 = 1;
            num2 = 0;
            count = 1;

            Console.WriteLine("Este programa demonstra a sequência de Fibonacci de 1 a 20.");

            while (count <= 30)
            {
                num2 = num2 + num1;
                num1 = num2 - num1;
                Console.WriteLine("O número {0} da sequência é {1}", count, num2);
                count++;
            }
            Console.ReadLine();
        }
    }
}
