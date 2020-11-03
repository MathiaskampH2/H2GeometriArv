using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2GeometriArv;

namespace H2GeometriArv
{
    /// <summary>
    /// Assignment D)
    /// Paralellogram class inherits from square class
    /// it has its own constructor and overrides the calcArea and calcPerimeter methods from square
    /// </summary>
    class Parallelogram : Square
    {
        private double side_b;

        public double Side_b
        {
            get { return side_b; }
            set { side_b = value; }
        }

        private double angle;

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }


        public Parallelogram(double side_a, double side_b, double angle) : base(side_a)
        {
            this.side_b = side_b;
            this.side_a = side_a;
            this.angle = angle;
        }

        public override double calcArea()
        {
            double convertToRadian = (angle * (Math.PI)) / 180;

            double area = side_a * side_b * Math.Sin(convertToRadian);

            return area;
        }

        public override double calcPerimeter()
        {
            double perimeter = (2 * side_a) + (2 * side_b);
            return perimeter;
        }
    }
}