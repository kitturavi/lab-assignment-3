using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q2
    {
        static void Main()
        {
            Console.WriteLine("enter your percentage:");
            double percent= Convert.ToDouble(Console.ReadLine());
            if (percent > 60 && percent <= 100)
                Console.WriteLine("A");
            else if (percent > 60 && percent < 70)
                Console.WriteLine("B");
            else if (percent > 50 && percent < 60) 
                Console.WriteLine("C");
            else if (percent > 40 && percent <50)
                Console.WriteLine("D");
            else
                Console.WriteLine("NA");
            Console.ReadLine();
        }
    }
}
