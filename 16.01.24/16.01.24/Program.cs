using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napishi si imeto:");
            string name=Console.ReadLine();
            Console.WriteLine("Hi,"+name);
            string str = "Hello,9a";
            string str1 = new string(new char[] { 's', 't', 'r' });
            char[]charArr=str.ToCharArray();
            Console.WriteLine(charArr);
            string str2=string.Concat(str1,str1);
            Console.WriteLine(str2);

        }
    }
}
