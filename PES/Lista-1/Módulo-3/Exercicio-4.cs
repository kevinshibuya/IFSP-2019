using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_26
{
    class exercicio_26
    {
        static void Main(string[] args)
        {
            int num, mult, res;
            num = 5;            
            res = 0;
            mult = 0;

            Console.WriteLine("A taboada do 5 ate 10 eh: \n");
            System.Threading.Thread.Sleep(1000);

            while (res < 50)
            {
                res = num * mult;
                Console.WriteLine("{0} vezes {1} eh {2}", num, mult, res);
                mult++;
                System.Threading.Thread.Sleep(500);
            }
            

            Console.ReadLine();
        }
    }
}
