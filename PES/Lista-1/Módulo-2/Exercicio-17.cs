using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_24
{
    class exercicio_24
    {
        static void Main(string[] args)
        {
            int days, year, month, day, div;

            Console.WriteLine("Enter how many days of life certain person have.");
            Console.Write("Days: ");
            days = Convert.ToInt32(Console.ReadLine());
                
            div = days % 365;
            year = days / 365;
            month = div / 30;
            day = div % 30;
            
            Console.WriteLine("The person have lived {0} years, {1} months and {2} days.", year, month, day);
            Console.ReadLine();
        }
    }
}
