using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_25
{
    class exercicio_25
    {
        static void Main(string[] args)
        {
            string sex;

            sex = "";            

            while(sex != "M" && sex != "F")
            {
                Console.WriteLine("Enter your sex down below.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Only 'M' and 'F' are accepted.");
                System.Threading.Thread.Sleep(1000);
                Console.Write("Enter your sex: ");
                sex = Console.ReadLine();
                sex = sex.ToUpper();
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);

                if (sex != "M" && sex != "F")
                {
                    Console.WriteLine("Tha is not valid, enter again.");
                    System.Threading.Thread.Sleep(1000);
                }
            }

            if(sex == "M")
            {
                sex = "Male";
            }
            else if(sex == "F")
            {
                sex = "Female";
            }

            Console.WriteLine("Your sex is {0}", sex);

            Console.ReadLine();
        }
    }
}
