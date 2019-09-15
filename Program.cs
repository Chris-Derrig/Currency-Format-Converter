using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            double dollar1;
            double dollar2;
            double dollar3;

            double total;
            double average;
            double min;
            double max;

            //Ask User for Input
            Console.WriteLine("Enter 3 Dollar Amounts");
            
            //Get User Input
            dollar1 = double.Parse(Console.ReadLine());
            dollar2 = double.Parse(Console.ReadLine());
            dollar3 = double.Parse(Console.ReadLine());

            //Get Total
            total = (dollar1 + dollar2 + dollar3);
            
            //Get Average
            average = (dollar1 + dollar2 + dollar3) / 3;

            //Get Max
            max = Math.Max(dollar1, Math.Max(dollar2, dollar3));

            //Get Min
            min = Math.Min(dollar1, Math.Min(dollar2, dollar3));

            //Display OutPut
            Console.WriteLine("");
            Console.WriteLine("The Total is " + total);
            Console.WriteLine("The Average is " + average);
            Console.WriteLine("The Max is " + max);
            Console.WriteLine("The Min is " + min);


            //Print Total in US, Swedish, Japanese, and Tai

            Console.WriteLine("");
            Console.WriteLine("US Total is " + total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Swedish Total is " + total.ToString("C2", CultureInfo.CreateSpecificCulture("SV-SE")));
            Console.WriteLine("Japanese Total is " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Tai Total is " + total.ToString("C2", CultureInfo.CreateSpecificCulture("th-TH")));

            Console.ReadLine();
        }
    }
}
