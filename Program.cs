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

                if (number >= 1 && number <= 100)
                {

                    if (number % 2 >= 1)
                    {
                        Console.WriteLine(name + number + " is odd.");
                    }
                    else if (number < 25)
                    {
                        Console.WriteLine(name + number + " is even and less than 25");
                    }
                    else if (number <= 26 || number >=60)
                    {
                        Console.WriteLine(name + " the number is even");
                    }
                    else
                    {
                        Console.WriteLine(name + number + " is even.");
                    }
                }

                Console.WriteLine(name + " Would you like to try again? {Y/N}");
                check = Console.ReadLine().ToLower();
                
            }
            while (check == "y");
        }
    }
}
