using System;

namespace MindBoxTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Круг", 12);
            Triangle triangle = new Triangle("Квадрат", 4, 4, 5);
            
            Console.WriteLine("Площадь круга = "+circle.CalcSquare());
            Console.WriteLine("Площадь квадрата = " + triangle.CalcSquare());
            Console.ReadKey();
        }
    }
}
