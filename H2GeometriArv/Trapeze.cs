using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Geometri_Arv
{
    class Trapeze : Square
    {
        private double side_b;

        public double Side_b
        {
            get { return side_b; }
            set { side_b = value; }
        }

        private double side_c;

        public double Side_c
        {
            get { return side_c; }
            set { side_c = value; }
        }

        private double side_d;

        public double Side_d
        {
            get { return side_d; }
            set { side_d = value; }
        }

        public Trapeze(double side_a, double side_b, double side_c, double side_d) :base (side_a)
        {
            this.side_b = side_b;
            this.side_c = side_c;
            this.side_d = side_d;
        }

        public double calcSTrapeze()
        {
            double s_trapeze = (side_a + side_b - side_c + side_d) / 2;

            return s_trapeze;
        }

        public double calcHTrapeze()
        {
            double s_trapeze = calcSTrapeze();
            double h_trapeze = (2 / (side_a - side_c)) * Math.Sqrt(s_trapeze * ((s_trapeze - side_a + side_c) * (s_trapeze -side_b) * (s_trapeze - side_d)));

            return h_trapeze;
        }


        public override double calcArea()
        {
            
            double h_trapeze = calcHTrapeze();


            double area = 0.5 * (side_a + side_c) * h_trapeze;
            return area;
        }


        public override double calcPerimeter()
        {
            double h_trapeze = calcHTrapeze();
            double perimeterTrapeze = (side_a + side_b + h_trapeze) * (1 / Math.Sin(side_a) + (1 / Math.Sin(side_b)));
            return perimeterTrapeze;
        }
    }
}
