using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ConvertSpeedUnits
{
    class _11_ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());


            float hourT = hours + minutes / 60.0f + seconds / 3600.0f;
            float kmV = (distance / 1000.0f) / hourT;
            float metersV = kmV / 3.6f;
            float milesS = (distance / 1609.0f) / hourT;


            Console.WriteLine(metersV);
            Console.WriteLine(kmV);
            Console.WriteLine(milesS);


        }
    }
}
