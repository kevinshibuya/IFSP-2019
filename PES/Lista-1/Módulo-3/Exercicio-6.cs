using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Entrar via teclado com um valor (X) qualquer. Travar a digitação, no sentido de aceitar somente valores positivos. 
Solicitar o intervalo que o programa que deverá calcular a tabuada do valor digitado, sendo que o segundo valor (B), 
deverá ser maior que o primeiro (A), caso contrário, digitar novamente somente o segundo. Após a validação dos dados, 
exibir a tabuada do valor digitado, no intervalo decrescente, ou seja, a tabuada de X no intervalo de B para A.
 */


namespace exercicio_28
{
    class exercicio_28
    {
        static void Main(string[] args)
        {
            double x, y1, y2, z;
            x = -1;
            y1 = 1;
            y2 = 0;
            z = 0;

            Console.WriteLine("Entre um numero positivo qualquer, para saber a sua tabuada!");

            while (x < 0)
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

            while (y1 > y2)
            {
                Console.WriteLine("Agora escolha o intervalo que a tabuada sera realizada.\n");
                Console.Write("Entre o inicio do intervalo: ");
                y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Entre o final do intervalo: ");
                y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);

                while(y1 > y2)
                {
                    if (y1 > y2)
                    {
                        Console.WriteLine("O valor final deve ser maior que o inicial.");
                        Console.WriteLine("Digite novamente.\n");
                        System.Threading.Thread.Sleep(1000);
                    }

                    Console.Write("Entre o final do intervalo: ");
                    y2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(1000);
                }
            }

            Console.WriteLine("O numero {0} multiplicado de {1} a {2} eh: \n", x, y1, y2);
            System.Threading.Thread.Sleep(1000);

            while (y1 <= y2)
            {
                z = x * y1;
                Console.WriteLine("{0} vezes {1} eh {2}", x, y1, z);
                y1++;
                System.Threading.Thread.Sleep(250);
            }

            Console.ReadLine();
        }
    }
}
