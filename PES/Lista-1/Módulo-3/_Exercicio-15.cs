using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_37
{
    class exercicio_37
    {
        static void Main(string[] args)
        {
            double n, number, count, lower, higher, average, add, positivePercentage, negativePercentage;
            add = 0;
            higher = 0;
            average = 0;
            lower = 10000000000000000000;
            positivePercentage = 0;
            negativePercentage = 0;
            number = 0;
            count = 1;

            Console.Write("Enter how many times the loop will repeat: ");
            number = Convert.ToDouble(Console.ReadLine());

            while (number <= 0)
            {
                Console.WriteLine("Number must be greater than 0.");
                Console.Write("Enter number again: ");
                number = Convert.ToDouble(Console.ReadLine());
            }

            while (count <= number)
            {
                Console.Write("Enter the number {0}: ", count);
                n = Convert.ToDouble(Console.ReadLine());

                if (n > higher)
                {
                    higher = n;
                }
                if (n < lower)
                {
                    lower = n;
                }

                add = add + n;

                average = add / number;

                if (n >= 0)
                {
                    positivePercentage += 1;
                }
                else
                {
                    negativePercentage += 1;
                }

                count++;
            }
            positivePercentage = (positivePercentage / number) * 100;
            negativePercentage = (negativePercentage / number) * 100;

            Console.WriteLine("The highest number is {0}.", higher);
            Console.WriteLine("The lowest number is {0}.", lower);
            Console.WriteLine("The addition of all numbers is {0}.", add);
            Console.WriteLine("The average of all {0} numbers is {1}.", number, average);
            Console.WriteLine("The positive numbers percentage is {0}%.", positivePercentage);
            Console.WriteLine("The negative numbers percentage is {0}%.", negativePercentage);
            Console.ReadLine();
        }
    }
}
