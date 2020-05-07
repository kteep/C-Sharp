using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Squareroot sqr1 = new Squareroot();
            sqr1.num = 0;

            Console.WriteLine ("Welcome To Squaroot Calculator!");
            Console.WriteLine("You are required to input any number of your choice");
            Console.WriteLine();
            
            {
                Console.Write("Please enter your first preferred number: ");
                sqr1.num = double.Parse(Console.ReadLine());
                double sqrt1 = Math.Sqrt(sqr1.num);

                Console.WriteLine(sqrt1);
            }
            
           

            Squareroot sqr2 = new Squareroot();
            sqr2.num = 0;

            {
                Console.Write("Please enter your second preferred number: ");
                sqr2.num = double.Parse(Console.ReadLine());
                double sqrt2 = Math.Sqrt(sqr2.num);

                Console.WriteLine(sqrt2);
            }

            

            if (sqr1.num < 0  || sqr2.num < 0)
            {
                Console.WriteLine("Error!!! you can't find square root of a negative number, Please enter new values: ");
                Main(args);
            }
            else if (sqr1.num < sqr2.num)
            {
                Console.WriteLine(sqr2.num + " has a higher square root");
            }
            else if (sqr1.num == sqr2.num)
            {
                Console.WriteLine("They both have the same square root, Please enter new values: ");
                Console.WriteLine();
                Main(args);
            }
            else if (sqr1.num > sqr2.num)
            {
                Console.WriteLine(sqr1.num + " has a higher square root"); 
            }
            else
            {
               Console.WriteLine("Try again"); 
            }

            Console.WriteLine("Would you like to start again? yes/no: ");
            string UserChoice;
            UserChoice = Console.ReadLine();

            if (UserChoice == "no")
                Environment.Exit(0);
            else if (UserChoice == "yes")
                Main(args);
            

                Console.ReadLine();
        }
    }
}
