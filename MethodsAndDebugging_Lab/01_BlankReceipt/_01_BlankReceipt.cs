using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BlankReceipt
{
    class _01_BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }
    }
}
