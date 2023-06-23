using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SortowaniePrzezWstawianie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] tablica = GenerujTablice(10); // Wygenerowanie tablicy z 10 losowymi liczbami

            Console.WriteLine("Tablica przed sortowaniem:");
            WypiszTablice(tablica);

            SortowaniePrzezWstawianie(tablica);

            Console.WriteLine("Tablica po sortowaniu:");
            WypiszTablice(tablica);

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

        static void WypiszTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Element {0}: {1}", i, tablica[i]);
            }
        }

        static void SortowaniePrzezWstawianie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 1; i < n; i++)
            {
                int element = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > element)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = element;
            }
        }
    }
}
