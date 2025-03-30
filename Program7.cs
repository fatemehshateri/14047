using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,sum=0;
            char r;
            a = int.Parse(Console.ReadLine());
            r = Console.ReadKey().KeyChar;
            b= int.Parse(Console.ReadLine());
            if (r == '*')
                sum = a * b;
            else if (r == '/')
                sum = a / b;
            else if (r == '+')
                sum = a + b;
            else if (r == '-')
                sum = a - b;
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
