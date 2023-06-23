using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SortowaniePrzezWybieranie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] tablica = GenerujTablice(10); // Wygenerowanie tablicy z 10 losowymi liczbami

            Console.WriteLine("Tablica przed sortowaniem:");
            WypiszTablice(tablica);

            SortowaniePrzezWybieranie(tablica);

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

        static void SortowaniePrzezWybieranie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int indeksMin = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (tablica[j] < tablica[indeksMin])
                    {
                        indeksMin = j;
                    }
                }

                ZamienElementy(tablica, i, indeksMin);
            }
        }

        static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
        {
            int temp = tablica[indeks1];
            tablica[indeks1] = tablica[indeks2];
            tablica[indeks2] = temp;
        }
    }
}
