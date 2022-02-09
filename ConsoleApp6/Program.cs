using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Equipment equipment1 = new Equipment("TV", "Samsung", 12, false);
            Equipment equipment2 = new Equipment("Radio", "Alto", 7, true);
            Equipment equipment3 = new Equipment("TV", "Asus", 19, false);
            Equipment equipment4 = new Equipment("Radio", "Apple", 20, false);

            

            

            Console.WriteLine("Введите оборудование(1 = TV, 2 = Radio) ");

            string a = Console.ReadLine();

            if (a == "1")
            {
                dynamic[] mas = { equipment1, equipment3};
                ArrayUtils arrayUtils = new ArrayUtils();
                ArrayUtils.Print(mas);
            }

            if (a == "2")
            {
                dynamic[] mas = { equipment2, equipment4 };
                ArrayUtils arrayUtils = new ArrayUtils();
                ArrayUtils.Print(mas);
            }



        }
    }
}