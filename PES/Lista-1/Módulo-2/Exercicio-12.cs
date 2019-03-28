using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_19
{
    class exercise_19
    {
        static void Main(string[] args)
        {
            double n1, n2, mf;

            Console.Write("Entre a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre a segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            mf = (n1 + (n2 * 2)) / 3;

            if (mf >= 5)
            {
                Console.WriteLine("Aluno foi aprovado.");
            }
            else if (mf < 5)
            {
                Console.WriteLine("Aluno foi reprovado.");
            }

            Console.ReadLine();
        }
    }
}
