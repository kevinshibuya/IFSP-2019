using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_3
{
    class exercicio_17
    {
        static void Main(string[] args)
        {
            int num1, res, num2;
            string rep;
            bool loop;
            res = 0;
            loop = true;
            rep = "Y";

            while(loop)
            {
                do {
                    Console.Write("Enter the factorial number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                } while (num1 <= 0);

                num2 = num1;

                while(loop) {
                    res = num1;
                    num2 = num2 - 1;
                    num1 = num1 * num2;
                    if(num2 == 0)
                    {
                        loop = false;
                    }
                }

                Console.WriteLine("The factorial of the number is {0}", res);

                do {
                    Console.WriteLine("Want to repeat the proccess?");
                    Console.WriteLine("Y - yes\nN - no");
                    rep = Console.ReadLine();
                } while (rep != "Y" && rep != "N");
                
                if(rep == "Y") {
                    loop = true;
                }
            }
            Console.WriteLine("Proccess ended.");
            Console.ReadLine();
        }
    }
}
