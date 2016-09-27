using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BooleanVariable
{
    class _05_BooleanVariable
    {
        static void Main(string[] args)
        {
         
            bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());
            if (trueOrFalse==false)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
