using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    class PrimeNumber
    {
        public  void Prime_Number()
        {
            int m, n, i, flag=0;
            Console.WriteLine("Enter a number to find prime or not");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for(i=2; i<=m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }
                
                   
            }
            if (flag == 0)
                Console.WriteLine("NUmber is prime");

        }
    }
}
