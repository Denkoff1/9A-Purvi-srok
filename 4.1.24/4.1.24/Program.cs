using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко сте в час?:");
             int broi=int.Parse(Console.ReadLine());
            Console.Write("Кой час е сега?:");
            int chas=int.Parse(Console.ReadLine());
            Console.Write("Колко момичета има?:");
            int g=int.Parse(Console.ReadLine());
            //izhod
            Console.Write("Нормален изход:");
            Console.Write(broi+"/"+chas+"/"+g);

            Console.WriteLine("Момчетата са:"+(broi-g));
            if (broi - g > 5)
            {
                Console.WriteLine("Ние сме супер ггерой!");
            }
            else
            {
                Console.WriteLine("Ние сме ботове!");
            }
        }
    }
}
