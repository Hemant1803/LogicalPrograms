using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void Perfectnumber() {
            Console.WriteLine("enter a number");
            int num =Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                     sum = sum + i;
                    Console.Write(i + "," );
                }
            }
            if (sum == num)
            {
                Console.WriteLine("\n Entered number is a perfect number");
               
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
               
            }

        }
    }
}
