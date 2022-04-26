using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    class ReverseNumber
    {
        public  void Reverse_Number()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine(reverse + " is reverse order");



        }
    }
}
