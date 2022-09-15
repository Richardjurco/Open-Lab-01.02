using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKTIK
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Napiš čislo: ");
            int čislo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Napiš 2 čislo: ");
            int čislo2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("vysledok je :  ");
            Console.WriteLine( čislo1 + čislo2);
        }
    }
}
