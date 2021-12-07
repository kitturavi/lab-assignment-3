using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
                Console.WriteLine($"{num} is a positve number");
            else if(num < 0)
                Console.WriteLine($"{num} is a negative number");
            else
                Console.WriteLine($"{num} is a zero");
            Console.ReadLine();
        }
    }
}
