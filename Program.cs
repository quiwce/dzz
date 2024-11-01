using System;

namespace GeometryShapes
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circle: Radius = {Radius}, Area = {GetArea()}, Circumference = {GetCircumference()}";
        }
    }

    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public override string ToString()
        {
            return $"Rectangle: Length = {Length}, Width = {Width}, Area = {GetArea()}, Perimeter = {GetPerimeter()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine(circle);

            Console.WriteLine("Введите длину и ширину прямоугольника (разделите пробелом):");
            string[] dimensions = Console.ReadLine().Split();
            double length = Convert.ToDouble(dimensions[0]);
            double width = Convert.ToDouble(dimensions[1]);
            Rectangle rectangle = new Rectangle(length, width);
            Console.WriteLine(rectangle);

            // Ожидание ввода пользователя, чтобы консоль не закрылась
            Console.WriteLine("Нажмите Enter, чтобы завершить программу.");
            Console.ReadLine();
        }
    }
}