using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{  
    
    class Program
    {
        static void Main(string[] args)
        {
        List<int> number = new List<int>() { };
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i = 0; a + b < 4000000;i++)
            {
               
                number.Add(b);
                c = b;
                b = a + b;
                a = c;
               
            }
         Console.WriteLine(   number.Sum());
            Console.ReadKey();
        }
    }
}
