using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Entrar via teclado com um valor qualquer. Travar a digitação, no sentido de aceitar somente valores positivos. 
 Após a digitação, exibir a tabuada do valor solicitado, no intervalo de um a dez.
*/

namespace exercicio_27
{
    class exercicio_27
    {
        static void Main(string[] args)
        {
            double x, y, z;
            x = -1;
            y = 0;
            z = 0;

            Console.WriteLine("Entre um numero positivo qualquer, para saber a sua tabuada do 0 ao 10!");

            while(x < 0)
            {
                Console.Write("Entre um numero positivo: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);

                if (x < 0)
                {
                    Console.WriteLine("{0} nao eh um numero positivo, por favor, repetir o processo.\n", x);
                    System.Threading.Thread.Sleep(1000);
                }
            }

            Console.WriteLine("A tabuada do {0} multiplicado ate 10 eh: \n", x);
            System.Threading.Thread.Sleep(1000);

            while (y < 11)
            {
                z = x * y;
                Console.WriteLine("{0} vezes {1} eh {2}", x, y, z);
                y++;
                System.Threading.Thread.Sleep(500);
            }

            Console.ReadLine();
        }
    }
}
