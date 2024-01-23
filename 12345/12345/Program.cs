using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string text=Console.ReadLine();
            double sum = 0;
            while (text != "no")
            {
                double instal = double.Parse(text);
                if (instal < 0)
                {
                    Console.WriteLine("Nevalidna operaciq!");
                    break;
                }
                Console.WriteLine(instal);
                sum = sum + instal;
                text = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
