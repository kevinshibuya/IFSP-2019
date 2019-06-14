using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3];
            string[] sex = new string[3];
            int[] age = new int[3];
            int count = 0;

            for (var i = 0; i < 3; i++)
            {
                Console.Write("Enter a name: ");
                name[i] = Console.ReadLine();
                do
                {
                    Console.Write("Enter the sex: ");
                    sex[i] = Console.ReadLine().ToUpper();
                    if (sex[i] != "M" && sex[i] != "F")
                    {
                        Console.WriteLine("Enter a valid sex.");
                    }
                }
                while (sex[i] != "M" && sex[i] != "F");
                do
                {
                    Console.Write("Enter the age: ");
                    age[i] = Convert.ToInt32(Console.ReadLine());
                    if(age[i] <= 0)
                    {
                        Console.WriteLine("Age must be greater than 0.");
                    }
                }
                while (age[i] <= 0);
            }
            Console.WriteLine("Checking only +20s...");
            for (var i = 0; i < 3; i++)
            {
                if(age[i] >= 20)
                {
                    Console.WriteLine("The name is {0}, sex is {1} and has {2} years.", name[i], sex[i], age[i]);
                    count++;
                }
            }
            Console.WriteLine("There is a total of {0} 20+.", count);
            Console.ReadLine();
        }
    }
}
