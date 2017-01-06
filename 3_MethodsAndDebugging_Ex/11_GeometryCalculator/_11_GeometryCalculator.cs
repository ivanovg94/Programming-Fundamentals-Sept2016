using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GeometryCalculator
{
    class _11_GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    PrintTriangleArea();
                    break;
                case "square": PrintSquareArea(); break;
                case "rectangle": PrintRectangleArea(); break;
                case "circle": PrintCircleArea(); break;
            }
        }

         static void PrintCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(Math.PI*radius*radius,2));
        }

        static void PrintRectangleArea()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((sideA*sideB),2));
        }

        static void PrintSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((side * side), 2));
        }

        static void PrintTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = Math.Round((side * height) / 2, 2);
            Console.WriteLine(area);

        }
    }
}
