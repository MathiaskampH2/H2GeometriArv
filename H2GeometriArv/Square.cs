using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Geometri_Arv
{
    class Square
    {
        protected double side_a;

        // opgave B Set og get methods
        public double Side_a
        {
            get { return side_a; }
            set { side_a = value; }
        }


        public Square(double a)
        {
            this.side_a = a;
        }

        public virtual double calcPerimeter()
        {
            double perimeter = Math.Pow(side_a, 2);
            return perimeter;
        }

        public virtual double calcArea()
        {
            double area = side_a * 4;
            return area;
        }
    }
}
