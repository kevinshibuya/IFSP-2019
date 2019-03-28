using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_14
{
    class exercise_14
    {
        static void Main(string[] args)
        {
            double p, a, r;
            int num = 0;
            string sex;

            Console.Write("Entre o peso da pessoa: ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre a altura da pessoa: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre o sexo da pessoa: ");
            sex = Console.ReadLine();
            System.Threading.Thread.Sleep(2000);

            if (sex == "masculino")
            {
                Console.WriteLine("Sexo masculino.");
                num = 0;
                System.Threading.Thread.Sleep(2000);
            }
            else if (sex == "feminino")
            {
                Console.WriteLine("Sexo feminino.");
                num = 1;
                System.Threading.Thread.Sleep(2000);
            }

            a = a * a;
            r = p / a;

            if (num == 0 && r < 20)
            {
                Console.WriteLine("Está abaixo do peso.");
            }
            else if (num == 0 && 20 <= r && r < 25)
            {
                Console.WriteLine("Está no peso ideal.");
            }
            else if (num == 0 && r >= 25)
            {
                Console.WriteLine("Está acima do peso.");
            }

            if (num == 1 && r < 19)
            {
                Console.WriteLine("Está abaixo do peso.");
            }
            else if (num == 1 && 19 <= r && r < 24)
            {
                Console.WriteLine("Está no peso ideal.");
            }
            else if (num == 1 && r >= 24)
            {
                Console.WriteLine("Está acima do peso.");
            }

            Console.ReadLine();
        }
    }
}
