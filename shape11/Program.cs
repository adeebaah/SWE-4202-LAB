using System;


namespace Shape
{
    public interface shape

    {
        public string whoAmI();

    }
    public class Two_Dimensional : shape
    {
        public virtual double area(double radius_or_length)
        {
            return -1;
        }
        public virtual double area(double length, double width)
        {
            return -2;
        }
        public virtual double area(double side1, double side2, double side3)
        {
            return 1;
        }

        public virtual double perimeter(double radius_or_length)
        {
            return 2;
        }
        public virtual double perimeter(double length, double width)
        {
            return -2;
        }
        public virtual double perimeter(double side1, double side2, double side3)
        {
            return -2;
        }
        public string whoAmI()
        {
            return "";
        }


        public class Three_Dimensional : shape
        {
            public virtual double surface_area(double radius_or_length)
            {
                return -6;
            }
            public virtual double volume(double radius_or_length)
            {
                return -5;
            }
            public virtual double surface_area(double radius, double height)
            {
                return 1;

            }
            public virtual double volume(double radius, double height)
            {
                return -1;

            }
            public string whoAmI()
            {
                return "";
            }

            public class Circle : Two_Dimensional
            {
                public double radius;

                public Circle(double radius)
                {
                    this.radius = radius;
                }

                public override double area(double radius)
                {
                    return (3.1416 * radius * radius);
                }

                public override double perimeter(double radius)
                {
                    return (2 * 3.1416 * radius);
                }

                public string whoAmI()
                {
                    return "I am Circle. I am a two-dimensional shape.";
                }



            }

        }
        public class Square : Two_Dimensional
        {
            public double length;

            public Square(double length)
            {
                this.length = length;
            }

            public override double area(double length)
            {
                return (length * length);
            }
            public override double perimeter(double length)
            {
                return (4 * length);
            }
            public string whoAmI()
            {
                return "Im a Square and a member of 2D class";
            }
        }


        public class Triangle : Two_Dimensional
        {
            public double side_a;
            public double side_b;
            public double side_c;
            public Triangle(double side_a, double side_b, double side_c)
            {
                this.side_a = side_a;
                this.side_b = side_b;
                this.side_c = side_c;
            }


            public override double area(double side_a, double side_b, double side_c)
            {
                double s;
                s = (side_a + side_b + side_c) / 2;
                return Math.Sqrt(s * (s - side_a) * (s - side_b) * (s - side_c));
            }
            public override double perimeter(double side_a, double side_b, double side_c)
            {
                return (side_a + side_b + side_c);
            }

            public string whoAmI()
            {
                return "Hi Im a triangle and a member of 2D family";
            }
        }

        public class rectangle : Two_Dimensional
        {
            public double length;
            public double width;

            public rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public override double area(double length, double width)
            {
                return (length * width);
            }
            public override double perimeter(double length, double width)
            {
                return (2 * (length + width));
            }
            public string whoAmI()
            {
                return "Hi Im a rectangle and a member of 2D family";
            }
        }
        public class Sphere : Three_Dimensional

        {
            public double radius;

            public Sphere(double radius)
            {
                this.radius = radius;
            }

            public override double surface_area(double radius)
            {
                return (4 * 3.1416 * radius * radius);
            }
            public override double volume(double radius)
            {
                return ((4 / 3) * 3.1415 * radius * radius * radius);
            }
            public string whoAmI()
            {
                return "Im a member of 3D class";
            }
        }
        public class cube : Three_Dimensional
        {
            public double side;

            public cube(double side)
            {
                this.side = side;
            }
            public override double surface_area(double side)
            {
                return (6 * side * side);
            }
            public override double volume(double side)
            {
                return (side * side * side);
            }
            public string whoAmI()
            {
                return "Im a 3D class Member";
            }

        }
        public class Cylinder : Three_Dimensional
        {
            public double radius;
            public double height;

            public Cylinder(double radius, double height)
            {
                this.radius = radius;
                this.height = height;
            }
            public override double surface_area(double radius, double height)
            {
                return ((2 * 3.1416 * radius * height) + (2 * 3.1416 * radius * radius));
            }
            public override double volume(double radius, double height)
            {
                return (3.1416 * radius * radius * height);
            }
            public string whoAmI()
            {
                return "Im a 3D class Member";
            }
        }
        public class cone : Three_Dimensional
        {
            public double radius;
            public double height;

            public cone(double radius, double height)
            {
                this.radius = radius;
                this.height = height;
            }

            public override double surface_area(double radius, double height)
            {
                return (((3.1416 * radius) * (radius + (Math.Sqrt((height * height) + (radius * radius))))));
            }
            public override double volume(double radius, double height)
            {
                return ((1 / 3) * (3.1416) * radius * radius * height);
            }
            public string whoAmI()
            {
                return "Im a member of 3D class hehe";
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    //Circle

                    Console.WriteLine("Enter the value of radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    Circle dummy_circle = new Circle(radius);
                    Console.WriteLine("Area: " + Convert.ToString(dummy_circle.area(radius)));
                    Console.WriteLine("Perimeter " + Convert.ToString(dummy_circle.perimeter(radius)));
                    Console.WriteLine(dummy_circle.whoAmI() + "\n _________________________");


                    //Square
                    Console.WriteLine("Enter the value of length: ");
                    double length = Convert.ToDouble(Console.ReadLine());

                    Square dummy_square = new Square(radius);
                    Console.WriteLine("Area: " + Convert.ToString(dummy_square.area(length)));
                    Console.WriteLine("Perimeter " + Convert.ToString(dummy_square.perimeter(length)));
                    Console.WriteLine(dummy_square.whoAmI() + "\n _________________________");

                    //triangle
                    Console.WriteLine("Enter the value of side 1: ");
                    double side_a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the value of side 2: ");
                    double side_b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the value of side 3: ");
                    double side_c = Convert.ToDouble(Console.ReadLine());


                    Triangle dummy_triangle = new Triangle(side_a, side_b, side_c);
                    Console.WriteLine("Area: " + Convert.ToString(dummy_triangle.area(side_a, side_b, side_c)));
                    Console.WriteLine("Perimeter: " + Convert.ToString(dummy_triangle.perimeter(side_a, side_b, side_c)));
                    Console.WriteLine(dummy_triangle.whoAmI() + "\n _________________________");


                    //Rectangle

                    Console.WriteLine("Enter the length of rectanle: ");
                    double length1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the width of rectanle: ");
                    double width1 = Convert.ToDouble(Console.ReadLine());

                    rectangle dummy_rec = new rectangle(length1, width1);
                    Console.WriteLine("Area: " + Convert.ToString(dummy_rec.area(length1, width1)));
                    Console.WriteLine("Perimeter: " + Convert.ToString(dummy_rec.perimeter(length1, width1)));
                    Console.WriteLine(dummy_rec.whoAmI() + "\n_____________");

                    //Sphere

                    Console.WriteLine("Enter the radius: ");
                    double radius1 = Convert.ToDouble(Console.ReadLine());

                    Sphere dummy_s = new Sphere(radius1);
                    Console.WriteLine("Surface Area: " + dummy_s.surface_area(radius1));
                    Console.WriteLine("Volume: " + dummy_s.volume(radius1));
                    Console.WriteLine(dummy_s.whoAmI());

                    //Cylinder
                    Console.WriteLine("Enter the radius: ");
                    double radius2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the Height: ");
                    double height2 = Convert.ToDouble(Console.ReadLine());

                    Cylinder dummy_cylinder = new Cylinder(radius2, height2);
                    Console.WriteLine("Surface Area:" + dummy_cylinder.surface_area(radius2, height2));
                    Console.WriteLine("Volume:" + dummy_cylinder.volume(radius2, height2));
                    Console.WriteLine(dummy_cylinder.whoAmI());

                    //CONE
                    Console.WriteLine("Enter the radius of Cone: ");
                    double radius3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Height of Cone: ");
                    double height3 = Convert.ToDouble(Console.ReadLine());

                    cone dummy_cone = new cone(radius3, height3);
                    Console.WriteLine("Surface Area:" + dummy_cone.surface_area(radius3, height3));
                    Console.WriteLine("Volume:" + dummy_cone.volume(radius3, height3));
                    Console.WriteLine(dummy_cone.whoAmI());

                    //Cube

                    Console.WriteLine("Enter the value of Side: ");
                    double side = Convert.ToDouble(Console.ReadLine());

                    cube dummy_cube = new cube(side);

                    Console.WriteLine("Surface Area:" + dummy_cube.surface_area(side));
                    Console.WriteLine("Volume:" + dummy_cone.volume(side));
                    Console.WriteLine(dummy_cube.whoAmI());





                }

                

            }
        }
        
    }
}
