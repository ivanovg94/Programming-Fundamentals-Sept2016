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

        private static bool FindArea(double side)
        {
            throw new NotImplementedException();
        }

        private static bool FindVolume(double side)
        {
            throw new NotImplementedException();
        }

        private static bool FindSpace(double side)
        {
            throw new NotImplementedException();
        }

        private static double FindFace(double side)
        {
            return
        }
    }
}
