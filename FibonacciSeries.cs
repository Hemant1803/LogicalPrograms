using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter The First Number :- ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number :-");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the no. of Elements to print ");
            int numofelements = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < numofelements; i++)
            {
                int num3 = num1 + num2;
                Console.Write(num3+" ");
                num1 = num2;
                
                num2 = num3;
               
            }


        }
    }
}
