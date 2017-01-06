using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.*?href.*?=.*?(""\S * "")>(.*?)<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";

            string text = "<ul> <li> <a href=\"http://softuni.bg\">SoftUni</a></ li > </ ul >";



        }
    }
}
