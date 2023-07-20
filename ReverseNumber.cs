using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reversenumber()
        {
            int s = 0;
            Console.WriteLine("numnber");
            int num = Convert.ToInt32(Console.ReadLine());
            
            while (num !=0)
            {
               int r = num % 10;               
               s = s * 10 + r;
                num = num / 10;
                //Console.WriteLine(s);
                Console.WriteLine(r);
               // Console.WriteLine(n);

            }
            Console.WriteLine(s);
        }
    }
}
