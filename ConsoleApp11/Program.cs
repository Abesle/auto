using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            samochod auto1 = new samochod("toyota", "niebieski", 150, "2000");
            Console.WriteLine(auto1);
            samochod auto2 = new samochod(400,"subaru" );
            Console.WriteLine(auto1);
           

        }
    }
}
