using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double pp, pm, pg, cp, cm, cg, qp, qm, qg, vp, vc;

            Console.Write("Enter the price of the P t-shirt: ");
            pp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price of the M t-shirt: ");
            pm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price of the G t-shirt: ");
            pg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the cost of the P t-shirt: ");
            cp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the cost of the M t-shirt: ");
            cm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the cost of the G t-shirt: ");
            cg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter how many P t-shirt sold on this month: ");
            qp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter how many M t-shirt sold on this month: ");
            qm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter how many G t-shirt sold on this month: ");
            qg = Convert.ToDouble(Console.ReadLine());

            pp = pp * qp;
            pm = pm * qm;
            pg = pg * qg;

            cp = cp * qp;
            cm = cm * qm;
            cg = cg * qg;

            vp = pp + pm + pg;
            vc = cp + cm + cg;

            Console.WriteLine("You spent {0} on the t-shirts this month.", vc);
            Console.WriteLine("You profitted {0} with the t-shirts this month.", vp);

            Console.ReadLine();
        }
    }
}
