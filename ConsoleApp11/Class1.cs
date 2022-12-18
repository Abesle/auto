using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class samochod
    {
        public static int zyskfirmy = 0;
        public int predkosc = 0;
        public string kolor, marka, data;
        public int cena;


        public samochod(string kolor, string marka, int cena, string data)
        {
            


            Console.WriteLine($"kolor {kolor} marka:{marka} koszt:{cena} data produksji:{data} prędkość: {predkosc}");
            zyskfirmy += cena;



            Console.WriteLine($"zysk firmy{zyskfirmy}");


        }
       

            public samochod(int cena , string marka )
        {
            
            Console.WriteLine( $"marka:{marka} koszt:{cena} ");
            zyskfirmy += cena;
            Console.WriteLine($"zysk firmy{zyskfirmy}");
        }
        public void szybkosc(int szybkosc)
        {
            predkosc += szybkosc;
            if (predkosc > 250)
            {
                predkosc -= szybkosc;
                Console.WriteLine("przekroczyłeś prędkość");

            }
            else if (predkosc < 0)
            {
                predkosc -= szybkosc;
                Console.WriteLine("prędkość nie może być minusowa");


            }
            Console.WriteLine($"kolor {kolor} marka:{marka} koszt:{cena} data produksji:{data} prędkość: {predkosc}");

        }
        public void kolo(string zmianakoloru)
        {
            kolor = zmianakoloru;
            Console.WriteLine($"kolor {kolor} marka:{marka} koszt:{cena} data produksji:{data} prędkość: {predkosc}");

        }

    }
        


    
}
    

