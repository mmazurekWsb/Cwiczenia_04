using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_wypiszLiczby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pierwsze " + n + " liczb pierwszych:");

            int liczba = 2; // Początkowa liczba do sprawdzenia
            int licznik = 0; // Licznik znalezionych liczb pierwszych

            while (licznik < n)
            {
                if (CzyLiczbaPierwsza(liczba))
                {
                    Console.WriteLine(liczba);
                    licznik++;
                }

                liczba++;
            }
        }

        static bool CzyLiczbaPierwsza(int liczba)
        {
            if (liczba < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                    return false;
            }

            return true;
        }
    }
}
    }
}
