using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_losowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            //Przygotuj losowanie
            Random random = new Random();

            //PRzygotuj Licznik
            int licznikLosowan = 0;
            int iloscLiczbDoWylosowania = n;

            //Losowanie
            for (int iloscLiczbWylosowanych = 0; iloscLiczbWylosowanych < iloscLiczbDoWylosowania; iloscLiczbWylosowanych++)
            {
                int wylosowanaLiczba;
                wylosowanaLiczba = random.Next(-4, 5);
                licznikLosowan++;
                wylosowanaLiczba *= 2;


                Console.Write(wylosowanaLiczba);
                if (iloscLiczbWylosowanych < iloscLiczbDoWylosowania - 1)
                {

                    Console.Write(", ");
                }
            }
            Console.WriteLine("\nlicznik liczb wylosowanych " + licznikLosowan);
            Console.ReadKey();


        }
    }
}
