using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        private double radius;
        private const double pi = Math.PI;
        private double circumference;
        private double area;


        public Circle(double radius)
        {
            this.radius = radius;

        }
        public double GetCircumference()
        {
            circumference = 2 * pi * radius;
            return circumference;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public string GetFormattedCircumference()
        {
            //needs a decimal format

            double cir = GetCircumference();
            //string displayString = cir.ToString("0:0.00");
            Console.WriteLine("The circumference of the circle is: ");
            Console.WriteLine(cir.ToString("n2"));
            return "";

        }

        public double GetArea()
        {
            area = pi * (radius * radius);
            return area;
        }

        public void GetFormattedArea()
        {
            //needs decimal format
            double ar = GetArea();
            Console.WriteLine("The area of the circle is: ");
            Console.WriteLine(String.Format("{0:0.00}", ar));
        }
    }
}
