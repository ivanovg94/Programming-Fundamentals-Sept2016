using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CenterPoint
{
    class _08_CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

           
            double centerX = 0;
            double centerY = 0;
            if (Math.Abs(x1)<=Math.Abs(x2))
            {
                centerX = x1;
            }
            else if (Math.Abs(x1) > Math.Abs(x2))
            {
                centerX = x2;
            }
            if (Math.Abs(y1)<=Math.Abs(y2))
            {
                centerY = y1;
            }
            else if (Math.Abs(y1) > Math.Abs(y2))
            {
                centerY = y2;
            }

            Console.WriteLine("({0}, {1})",centerX,centerY);

        }
    }
}
