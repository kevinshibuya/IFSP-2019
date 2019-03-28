using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_21
{
    class exercise_21
    {
        static void Main(string[] args)
        {
            double x, y, z;
            int choose;

            Console.Write("Entre o valor de X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre o valor de Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("\nEscolha uma das opções abaixo: \n1–Multiplicação\n2–Adição\n3–Divisão\n4–Subtração\n5–Fim de processo\n");
            Console.Write("Opção: ");
            choose = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(" ");

            if (choose == 1)
            {
                z = x * y;
                Console.WriteLine("Resultado = " + z);
                System.Threading.Thread.Sleep(2000);
            }
            else if (choose == 2)
            {
                z = x + y;
                Console.WriteLine("Resultado = " + z);
                System.Threading.Thread.Sleep(2000);
            }
            else if (choose == 3 && y == 0)
            {                
                Console.WriteLine("Não há divisão por zero.");
                System.Threading.Thread.Sleep(2000);
            }
            else if (choose == 3)
            {
                z = x / y;
                Console.WriteLine("Resultado = " + z);
                System.Threading.Thread.Sleep(2000);
            }
            else if (choose == 4)
            {
                z = x - y;
                Console.WriteLine("Resultado = " + z);
                System.Threading.Thread.Sleep(2000);
            }
            else if (choose == 5)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid option.");
                System.Threading.Thread.Sleep(2000);
            }

            Console.ReadLine();
        }
    }
}
