using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência com " + valores + " valores");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores -1)
                {
                    Console.Write(Fibonacci(i) + ", ");
                }
                else
                {
                    Console.Write(Fibonacci(i));
                }
            }

            Console.ReadKey();
        }

        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
