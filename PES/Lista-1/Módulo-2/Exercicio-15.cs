using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_22
{
    class exercicio_22
    {
        static void Main(string[] args)
        {
            double x, y, d, r;
            double pi = 3.1415;
            int choose;

            Console.WriteLine("Escolha uma das opções abaixo: \n1–Triangulo\n2–Quadrado\n3–Retangulo\n4–Circulo\n5–Fim de processo\n");
            Console.Write("Opção: ");
            choose = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(" ");

            switch (choose)
            {
                case 1:
                    Console.WriteLine("Calcule a area de um triangulo!\n");
                    Console.Write("Entre o valor de X: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Entre o valor de Y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    r = (x * y) / 2;
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(" ");

                    Console.WriteLine("A area do triangulo eh: {0}cms", r);

                    break;
                case 2:
                    Console.WriteLine("Calcule a area de um quadrado!\n");
                    Console.Write("Entre o valor de X: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Entre o valor de Y: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    if (x == y)
                    {
                        r = x * y;
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine(" ");

                        Console.WriteLine("A area do quadrado eh: {0}", r);
                    }
                    else if (x != y)
                    {
                        Console.WriteLine("Entre dois valores identicos.");
                    }

                    break;
                case 3:
                    Console.WriteLine("Calcule a area de um retangulo!\n");
                    Console.Write("Entre o valor de X: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Entre o valor de Y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    r = x * y;
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(" ");

                    Console.WriteLine("A area do retangulo eh: {0}cms", r);

                    break;
                case 4:
                    Console.WriteLine("Calcule a area de um circulo!\n");
                    Console.Write("Entre o valor do diametro: ");
                    d = Convert.ToDouble(Console.ReadLine());

                    r = d / 2;

                    r = r * pi;

                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(" ");

                    Console.WriteLine("A area do circulo eh: {0}cms", r);

                    break;
                case 5:
                    Environment.Exit(0);

                    break;
            }

            Console.ReadLine();
        }
    }
}
