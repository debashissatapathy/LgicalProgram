using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    class PerfectNumber
    {
        public  void Perfect()
        {
            Console.Write("enter the number for getting divisors: ");
            int a = int.Parse(Console.ReadLine());

            int sum = 0,n=a, i;
            
            for(i=1; i<=n; i++)
            {
                if(n%i == 0 && i< a)
                {
                    
                        sum += i;
                        Console.Write(i + " ,");
                    
                                        
                }              
            }
            if (sum == n)
            {
                
                Console.WriteLine(sum +"." + " So " + a +  " is a perfect number");
            }
            else
            {
                Console.WriteLine(sum + "." + " So " + a + " is not a perfect number"); 
            }


        }
    }
}
