using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_23
{
    class exercicio_23
    {
        static void Main(string[] args)
        {
            double year, month, day, days;

            Console.WriteLine("Enter how many years, months, and days of life certain person have.");
            Console.Write("Years: ");
            year = Convert.ToDouble(Console.ReadLine());
            Console.Write("Months: ");
            month = Convert.ToDouble(Console.ReadLine());
            Console.Write("Days: ");
            day = Convert.ToDouble(Console.ReadLine());

            year = year * 365;
            month = month * 30;

            days = year + month + day;

            Console.WriteLine("The person have lived {0} days.", days);
            Console.ReadLine();
        }
    }
}
