using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CubeProperties
{
    class _10_CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face": Console.WriteLine(FindFace(side)); break;
                case "space": Console.WriteLine(FindSpace(side)); break;
                case "volume": Console.WriteLine(FindVolume(side)); break;
                case "area": Console.WriteLine(FindArea(side)); break;
            }
        }

         static double FindArea(double side)
        {
            return Math.Round( 6 * Math.Pow(side, 2),2);
        }

         static double FindVolume(double side)
        {
            return Math.Round(Math.Pow(side, 3),2);
        }

         static double FindSpace(double side)
        {
            return Math.Round(Math.Sqrt(3 * Math.Pow(side, 2)),2);
        }

         static double FindFace(double side)
        {
            return Math.Round(Math.Sqrt(2*Math.Pow(side,2)),2);
        }
    }
}
