using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_18
{
    class exercise_18
    {
        static void Main(string[] args)
        {
            double a, v0, t, vf;

            Console.Write("Entre a velocidade inicial: ");
            v0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre a aceleração: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre o tempo: ");
            t = Convert.ToDouble(Console.ReadLine());

            vf = v0 + (a * t);

            if (vf <= 40)
            {
                Console.WriteLine("Velocidade muito lenta.");
            }
            else if (40 < vf && vf <= 60)
            {
                Console.WriteLine("Velocidade permitida.");
            }
            else if (60 < vf && vf <= 80)
            {
                Console.WriteLine("Velocidade de cruzeiro.");
            }
            else if (80 < vf && vf <= 120)
            {
                Console.WriteLine("Veículo rápido.");
            }
            else if (vf > 120)
            {
                Console.WriteLine("VEÍCULO RAPIDO PRA KRL");
            }

            Console.ReadLine();
        }
    }
}
