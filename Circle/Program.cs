using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Circle Tester");
            bool repeat = true;
            do
            {
                double radius;
                Console.WriteLine("Enter the radius of the circle");
                radius = Convert.ToDouble(Console.ReadLine());

                Circle myCircle = new Circle(radius);

                myCircle.GetFormattedArea();
                myCircle.GetFormattedCircumference();

                Console.WriteLine("Would you like to enter another radius? (yes or no)");
                string input = Console.ReadLine();
                input = input.ToLower();

                if (input == "y" || input == "yes")
                {
                    repeat = true;
                }
                else if (input == "n" || input == "no")
                {
                    Console.WriteLine("Goodbye");
                    
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("You must answer yes or no. Try again: ");

                }

            } while (repeat == true);
        }

    }
}
