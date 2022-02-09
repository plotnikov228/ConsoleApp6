using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class ArrayUtils 
    {
        

        public static void Print(dynamic[] mas)
            {
                Console.WriteLine("[");
                for (int i = 0; i<mas.Length; i++)
                {
                    Console.WriteLine(mas[i]);

                    if (mas.Length - i != 1)
                    {
                        Console.WriteLine(",");
                    }
                }
                Console.WriteLine("]");
            }
        
        
        public static void Fill(int mass)
        {

        }
    }
}
