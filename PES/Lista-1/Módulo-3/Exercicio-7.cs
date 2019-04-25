using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Exibir a tabuada dos valores de um a vinte, no intervalo de um a dez. 
  Entre as tabuadas, solicitar que o usuário pressione uma tecla.
 */


namespace exercicio_29
{
    class exercicio_29
    {
        static void Main(string[] args)
        {
            double x, y, z, count;
            x = 0;
            y = 1;
            z = 0;
            count = 1;

            Console.WriteLine("This code will show the table of 1 to 20 on an interval of 1 to 10.");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();

            while(count <= 20)
            {
                while (y <= 10)
                {
                    z = x * y;
                    Console.WriteLine("{0} vezes {1} eh {2}", x, y1, z);
                    y++;
                    System.Threading.Thread.Sleep(250);

                    if (y == 10)
                    {

                    }
                }
            }
        }
    }
}
