using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    class FibonacciNumber
    {
        public  void Fibonacci()
        {
            int a = 0, b = 1, c, i, number;
            Console.Write("enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 2; i < number; ++i)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
