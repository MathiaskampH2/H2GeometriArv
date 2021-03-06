﻿using System;

namespace H2GeometriArv
{
    /// <summary>
    /// Assignment F)
    /// RightAngledTriangle Class inherits from Square class
    /// OVerrides calcArea and calcPerimeter methods
    /// </summary>
    class RightAngledTriangle : Square
    {
        private double side_b;

        public double Side_b
        {
            get { return side_b; }
            set { side_b = value; }
        }


        public RightAngledTriangle(double side_a, double side_b) : base(side_a)
        {
            this.side_b = side_b;
            this.side_a = side_a;
        }

        public override double calcArea()
        {
            double t_right_angled_Triangle = 0.5 * side_a * side_b;
            return t_right_angled_Triangle;
        }

        public override double calcPerimeter()
        {
            double side_c = Math.Sqrt(Math.Pow(side_a, 2) + Math.Pow(side_b, 2));

            double perimeter = side_a + side_b + side_c;
            return perimeter;
        }
    }
}