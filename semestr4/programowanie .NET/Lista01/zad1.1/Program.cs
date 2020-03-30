using System;
using System.Collections.Generic;

namespace zad1._1
{
    /// <summary>
    /// Główna klasa programu
    /// </summary>
    public class CMain
    {
        /// <summary>
        /// Metoda przyjmuje liczbę i zwraca listę jej cyfr i na koniec listy dodaje sumę cyfr tej liczby 
        /// </summary>
        /// <param name="a">liczba do rozłożenia</param>
        /// <returns>Lista cyfr i sumy cyfr liczby a</returns>
        public static List<int> ListaISumaCyfr(int a)
        {
            List<int> wynik = new List<int>();
            int suma = 0;
            while (a > 0)
            {
                int modu = a % 10;
                wynik.Add(modu);
                suma += modu;
                a /= 10;
            }
            wynik.Add(suma);
            return wynik;
        }
        /// <summary>
        /// Główna metoda programu
        /// </summary>
        public static void Main()
        {
            List<int> wynik = new List<int>();
            bool dobrze;
            for (int i = 1; i <= 100000; i++)
            {
                dobrze = true;
                foreach (int x in ListaISumaCyfr(i))
                {
                    if (x == 0 || i % x != 0)
                    {
                        dobrze = false;
                        break;
                    }
                }
                if (dobrze) wynik.Add(i);
            }
            foreach (int liczba in wynik)
            {
                Console.Write(liczba.ToString() + ", ");
            }
        }
    }
}