using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    class CouponNumber
    {
        public void couponNumber()
        {

            Console.WriteLine("Enter number of coupon");
            int number = int.Parse(Console.ReadLine());
            string coupon = string.Empty;
            while (number>0)
            {
                int k = new Random().Next(1,123);
                coupon += (char)k;
                number--;

            }
       
            Console.WriteLine("Your coupon number is: " + coupon);

        }
       
            
            
        
    }
}
