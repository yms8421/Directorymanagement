using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call(5);
            var number = 5;
            Console.WriteLine("{0} Sayısının Faktöriyeli {1}",number, GetFactorial(number));
            Console.WriteLine("{0} Sayısının Kendine Kadar Olan Sayıların Toplamı {1}",number, GetSummary(number));
            Console.ReadLine();
        }

        static void Call(int a)
        {
            Console.WriteLine(a);
            if (a <= 0)
            {
                return;
            }
            Call(--a);
        }

        static int GetFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * GetFactorial(--number);
        }

        static int GetSummary(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            return number + GetSummary(--number);
        }
    }
}
