using System;

namespace Упражнение_6
{
    abstract class GeometricFigure
    {
       abstract protected double sFigure();
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
    class Rectangle : GeometricFigure
    {
        double width , height;
        public override string ToString()
        {
            Rectangle r = new Rectangle(width ,height);
            return $"Square: {r.sFigure()}\nwidth: {width}\nheight: {height} ";
        }
        public double Width
        {
            get 
            {
                return width;
            }
            set 
            {
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        protected override double sFigure()
        {
            return width * height;
        }
    }
    class Quadrate : GeometricFigure
    {
        double sidelength;
        public override string ToString()
        {
            Quadrate q = new Quadrate(sidelength);
            return $"Square: {q.sFigure()}\nsidelength: {sidelength}";
        }
        public Quadrate(double sidelength)
        {
            this.sidelength = sidelength;
        }
        protected override double sFigure()
        {
            return sidelength * sidelength;
        }
    }
    class Сircle : GeometricFigure
    {
        double radius;
        const double pi = 3.14;

        public override string ToString()
        {
            Сircle c = new Сircle(radius);
            return $"Square: {c.sFigure()}\nradius: {radius}";
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Сircle(double radius)
        {
            this.radius = radius;
        }
        protected override double sFigure()
        {
            return pi * radius * radius;
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите ширину прямоугольника");
            var width1 = Console.ReadLine();
            Console.WriteLine("Введите высоту прямоугольника");
            var height1 = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(width1, out double width) && double.TryParse(height1, out double height))
            {
                Rectangle rectangle = new Rectangle(width, height);
                Console.WriteLine(rectangle);
                Console.WriteLine();
               // rectangle.Print();
            } else Console.WriteLine("Попробуйте ещё раз");

            Console.WriteLine("Введите длину стороны квадрата");
            var sidelength1 = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(sidelength1, out double sidelength))
            {
                Quadrate quadrate = new Quadrate(sidelength);
                Console.WriteLine(quadrate);
                Console.WriteLine();
              //  quadrate.Print();
            }
            else Console.WriteLine("Попробуйте ещё раз");

            Console.WriteLine("Введите радиус круга");
            var radius1 = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(radius1, out double radius))
            {
                Сircle circle= new Сircle(radius);
                Console.WriteLine(circle);
                Console.WriteLine();
              //  circle.Print();
            }
            else Console.WriteLine("Попробуйте ещё раз");
        }
    }
}
