using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RectangleProperties
{
    class _12_RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height= double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            double diagonalx2 = Math.Pow(width, 2) + Math.Pow(height, 2);
            double diagonal = Math.Sqrt(diagonalx2);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);

        }
    }
}
