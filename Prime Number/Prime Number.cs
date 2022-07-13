using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Prime_Number
    {
        static void Main(string[] args)
        {
            bool isprime = true;
            Console.WriteLine("Prime Numbers");
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write("\t" + i);
                }
                isprime = true;
            }
            Console.ReadKey();
        }
    }
}


