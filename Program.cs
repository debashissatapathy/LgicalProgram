using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to logical program\nEnter appropriate number to go to your program!");
            Console.Write("1.FibonacciNumber 2.perfectnumber 3.primenumber 4.reversenumber 5.couponnumber 6.StopWatch\n");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    FibonacciNumber fib = new FibonacciNumber();
                    fib.Fibonacci();
                    break;
                case 2:
                    PerfectNumber per = new PerfectNumber();
                    per.Perfect();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime_Number();
                    break;
                case 4:
                    ReverseNumber rev = new ReverseNumber();
                    rev.Reverse_Number();
                    break;
                case 5:
                    CouponNumber num = new CouponNumber();
                    num.couponNumber();
                    break;
                case 6:
                    StopWatch watch = new StopWatch();
                    watch.stopWatch();
                    break;

            }
        }
        
    }
}
