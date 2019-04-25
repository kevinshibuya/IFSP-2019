using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_30
{
    class exercicio_30
    {
        static void Main(string[] args)
        {
            double num1, num2;
            num1 = 1;
            num2 = 0;

            Console.WriteLine("Este programa exibe a soma dos números inteiros de 1 a 100.");
            Console.Write("Pressione qualquer tecla para continuar: ");
            Console.ReadLine();

            while (num1 <= 100)
            {
                num2 = num2 + num1;
                num1++;
            }
            Console.WriteLine("A soma de todos os números inteiros de 1 a 100 é {0}", num2);
            Console.ReadLine();
        }
    }
}
