using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q4
    {
        static void Main()
        {
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = num >= 0 ? "positive":"negative";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
