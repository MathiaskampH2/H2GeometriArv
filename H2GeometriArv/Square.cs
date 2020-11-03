using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace H2GeometriArv
{
    /// <summary>
    /// Assignment A)
    /// Class Square, has purpose of beeing a superclass
    /// where i can inherit its methods and properties.
    /// </summary>
    public class Square : Shapes
    {
        // Assignment B) create set and get 
        protected double side_a;

        public double Side_a
        {
            get { return side_a; }
            set { side_a = value; }
        }


        public Square(double a)
        {
            this.side_a = a;
        }

        // calculates the Perimeter for a square
        public virtual double calcPerimeter()
        {
            double perimeter = Math.Pow(side_a, 2);
            return perimeter;
        }

        // calculate the area of a square        
        public virtual double calcArea()
        {
            double area = side_a * 4;
            return area;
        }
    }
}