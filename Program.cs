using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, yourNumber, check ;
            int number ;

            Console.WriteLine("Hello! Please enter your name before we begin. ");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine(name + " Please enter an integer between 1 and 100.");
                yourNumber = Console.ReadLine();
                number = int.Parse(yourNumber);

                while (number >= 1 && number <= 100)
                {

                    if (number % 2 >= 1)
                    {
                        Console.WriteLine(name + " The number is odd.");
                    }
                    else if (number < 25)
                    {
                        Console.WriteLine(name + " The number is even and less than 25");
                    }
                    else
                    {
                        Console.WriteLine(name + " The number is even.");
                    }
                }

                Console.WriteLine(name + " Would you like to try again? {Y/N}");
                check = Console.ReadLine().ToLower();
                
            }
            while (check == "y");
        }
    }
}
