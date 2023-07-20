using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void Primenumber() 
        {
           int flag = 0;
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 2; i <= num / 2; ++i)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;

                }
              
            }
            if (flag == 1)
            {
                Console.WriteLine("not prime"+num);
            }
            else
            {
                Console.WriteLine("number is prme" + num);
            }




        }
    }
}
