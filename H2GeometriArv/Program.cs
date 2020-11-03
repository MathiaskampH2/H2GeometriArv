using System;
using System.Collections.Generic;

namespace H2GeometriArv
{

    class Program
    {
        static void Main(string[] args)
        {

            Square s = new Square(10);
            Square s2 = new Square(7);


            Console.WriteLine($"The area of a square with a side = {s.Side_a} is : " + s.calcArea());
            Console.WriteLine($"The perimeter of a square with a side = {s.Side_a} is :" + s.calcPerimeter());
            Console.WriteLine($"The area of a square with a side = {s2.Side_a} is : " + s2.calcArea());
            Console.WriteLine($"The perimeter of a square with a side = {s2.Side_a} is :" + s2.calcPerimeter());

            Trapeze t = new Trapeze(10, 9, 8, 9);
            Trapeze t2 = new Trapeze(12, 9, 9, 9);

            Console.WriteLine(
                $"The area of the trapeze with a sides of:{t.Side_a}, b side of: {t.Side_b}, c side of: {t.Side_c}, d side of :{t.Side_d} is: " +
                t.calcArea());
            Console.WriteLine(
                $"The perimeter of the trapeze with a sides of:{t.Side_a}, b side of: {t.Side_b}, c side of: {t.Side_c}, d side of :{t.Side_d} is: " +
                t.calcPerimeter());

            Console.WriteLine(
                $"The area of the trapeze with a sides of:{t2.Side_a}, b side of: {t2.Side_b}, c side of: {t2.Side_c}, d side of :{t2.Side_d} is: " +
                t2.calcArea());
            Console.WriteLine(
                $"The perimeter of the trapeze with a sides of:{t.Side_a}, b side of: {t.Side_b}, c side of: {t.Side_c}, d side of :{t.Side_d} is: " +
                t2.calcPerimeter());

            Parallelogram p = new Parallelogram(3, 5, 20);
            Parallelogram p2 = new Parallelogram(5, 7, 69);
            Console.WriteLine(
                $"The area of the Parallelogram with a sides of:{p.Side_a}, b side of: {p.Side_b}, angle of {p.Angle} is: " +
                p.calcArea());
            Console.WriteLine(
                $"The perimeter of the Parallelogram with a sides of:{p.Side_a}, b side of: {p.Side_b} is: " +
                p.calcPerimeter());

            Console.WriteLine(
                $"The area of the Parallelogram with a sides of:{p2.Side_a}, b side of: {p2.Side_b}, angle of {p2.Angle} is: " +
                p2.calcArea());
            Console.WriteLine(
                $"The perimeter of the Parallelogram with a sides of:{p2.Side_a}, b side of: {p2.Side_b} is: " +
                p2.calcPerimeter());

            Rectangle r = new Rectangle(5, 7);
            Rectangle r2 = new Rectangle(12, 17);

            Console.WriteLine($"The area of the Rectangle with a sides of:{r.Side_a}, b side of: {r.Side_b} is: " + r.calcArea());
            Console.WriteLine($"The perimeter of the Parallelogram with a sides of:{r.Side_a}, b side of: {r.Side_b} is : " + r.calcPerimeter());
            Console.WriteLine($"The area of the Rectangle with a sides of:{r2.Side_a}, b side of: {r2.Side_b} is: " + r2.calcArea());
            Console.WriteLine($"The perimeter of the Parallelogram with a sides of:{r2.Side_a}, b side of: {r2.Side_b} is : " + r2.calcPerimeter());

            RightAngledTriangle right = new RightAngledTriangle(5,7);
            RightAngledTriangle right2 = new RightAngledTriangle(10,17);
            Console.WriteLine($"The area of the right angled triangle with a sides of:{right.Side_a}, b side of: {right.Side_b} is :" + right.calcArea());
            Console.WriteLine($"The perimeter of the right angled triangle with a sides of:{right.Side_a}, b side of: {right.Side_b} is: " + right.calcPerimeter());

            Console.WriteLine($"The area of the right angled triangle with a sides of:{right2.Side_a}, b side of: {right2.Side_b} is :" + right2.calcArea());
            Console.WriteLine($"The perimeter of the right angled triangle with a sides of:{right2.Side_a}, b side of: {right2.Side_b} is: " + right2.calcPerimeter());

            Console.Clear();
            
            
            // Assignment G
            List<Shapes> shapes = new List<Shapes>();

            // add shapes to the shapes list
            shapes.Add(s);
            shapes.Add(t);
            shapes.Add(p);
            shapes.Add(r);
            shapes.Add(right);

            for (int i = 0; i < shapes.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"The area of a square with a side = {s.Side_a} is : " + s.calcArea());
                        Console.WriteLine($"The perimeter of a square with a side = {s.Side_a} is :" + s.calcPerimeter());
                        break;

                    case 1:
                        Console.WriteLine($"The area of the trapeze with a sides of:{t.Side_a}, b side of: {t.Side_b}, c side of: {t.Side_c}, d side of :{t.Side_d} is: " + t.calcArea());
                        Console.WriteLine($"The perimeter of the trapeze with a sides of:{t.Side_a}, b side of: {t.Side_b}, c side of: {t.Side_c}, d side of :{t.Side_d} is: " + t.calcPerimeter());
                        break;
                    case 2:
                        Console.WriteLine($"The area of the Parallelogram with a sides of:{p.Side_a}, b side of: {p.Side_b}, angle of {p.Angle} is: " + p.calcArea());
                        Console.WriteLine($"The perimeter of the Parallelogram with a sides of:{p.Side_a}, b side of: {p.Side_b} is: " + p.calcPerimeter());
                        break;
                    case 3:
                        Console.WriteLine($"The area of the Rectangle with a sides of:{r.Side_a}, b side of: {r.Side_b} is: " + r.calcArea());
                        Console.WriteLine($"The perimeter of the Parallelogram with a sides of:{r.Side_a}, b side of: {r.Side_b} is : " + r.calcPerimeter());
                        break;

                    case 4:
                        Console.WriteLine($"The area of the right angled triangle with a sides of:{right.Side_a}, b side of: {right.Side_b} is :" + right.calcArea());
                        Console.WriteLine($"The perimeter of the right angled triangle with a sides of:{right.Side_a}, b side of: {right.Side_b} is: " + right.calcPerimeter());
                        break;
                }
            }
        }
    }
}