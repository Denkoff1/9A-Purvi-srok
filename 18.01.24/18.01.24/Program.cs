using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string biri = "Amstel,Zagorka,Tuborg,Becks.";
            string[] beers = biri.Split(' ', ',', '.');
            Console.WriteLine("Birite sa:");
            foreach (string bira in beers)
            {
                Console.WriteLine(bira);
              
            } 
            string az = "Az,Vanko,obicham,piq,voda.";
                string[] men = az.Split(' ', ',', '.');
            Console.WriteLine("Zavurshih zashtoto:");
            foreach (string ko in men)
                {
                    Console.WriteLine(ko);
                }
            string replace = biri.Replace(",", " ");
            Console.WriteLine(replace);
            string novo = replace.Remove(7, 7);
            Console.WriteLine(novo);
            string loweralpha=novo.ToLower();
            Console.WriteLine(loweralpha);
            string upperalpha=az.ToUpper();
            Console.WriteLine(upperalpha);
            string novo1=az.Replace(",", " ");
            Console.WriteLine(novo1);
            string novo2 = az.Replace("voda","vodka");
            Console.WriteLine(novo2);
            string novo3 = az.Remove(20, 5);
            Console.WriteLine(novo3);
        }
    }
}
