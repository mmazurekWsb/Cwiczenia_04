using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_wypiszTabliceodTyłu01
{

    class Program
    {
        static void Main()
        {
            int[] tablica = GenerujTablice(10); // Wygenerowanie tablicy z 10 losowymi liczbami

            Console.WriteLine("Zawartość tablicy od tyłu:");
            WypiszTabliceOdTylu(tablica);

            Console.ReadLine();
        }

        static int[] GenerujTablice(int rozmiar)
        {
            Random rand = new Random();
            int[] tablica = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(100); // Losowa liczba z zakresu 0-99
            }

            return tablica;
        }

        static void WypiszTabliceOdTylu(int[] tablica)
        {
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Element {0}: {1}", i, tablica[i]);
            }
        }
    }
}