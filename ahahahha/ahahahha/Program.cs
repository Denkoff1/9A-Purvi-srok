using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahahahha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kak sa vikash?");
            string name=Console.ReadLine();
            string cocktail = "Vodka+Martini+Cherry";
            string a = "Wiski";
            Console.WriteLine(name);
            Console.WriteLine(cocktail);
            Console.WriteLine(a);
            Console.WriteLine(name+"shte pie"+cocktail+"i"+a);
            string replace = cocktail.Replace("+", " ");
            Console.WriteLine(replace);
            string Remove = a.Remove(0,2);
            Console.WriteLine(Remove);
            string glavni = name.ToUpper()+cocktail.ToUpper()+a.ToUpper();
            Console.WriteLine(glavni);
            Console.WriteLine(name + " shte pie " + cocktail + " i shte kara " + Remove );
            string Remove1=cocktail.Remove(13,7);
            Console.WriteLine(Remove1);
        }
    }
}
