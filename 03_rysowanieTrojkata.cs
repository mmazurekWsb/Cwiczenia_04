using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Trójkąt złożony z znaków +:");

        for (int i = 0; i < wysokosc; i++)
        {
            for (int j = 0; j <= 2 * wysokosc - 1; j++)
            {
                if (j >= wysokosc - i - 1 && j <= wysokosc + i - 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}