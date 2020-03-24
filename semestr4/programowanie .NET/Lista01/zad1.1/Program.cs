using System;
using System.Collections.Generic;

namespace zad1._1
{

    public class CMain
    {
        public static List<int> ListaISumaCyfr(int a)
        {
            List<int> wynik = new List<int>();
            int suma = 0;
            while (a > 0)
            {
                int modu = a % 10;
                if (modu != 0)
                {
                    wynik.Add(modu);
                    suma += modu;
                }
                a /= 10;
            }
            wynik.Add(suma);
            return wynik;
        }
        public static void Main()
        {
            List<int> wynik = new List<int>();
            bool dobrze;
            for (int i = 1; i <= 100000; i++)
            {
                dobrze = true;
                foreach (int x in ListaISumaCyfr(i))
                {
                    if (i % x != 0)
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