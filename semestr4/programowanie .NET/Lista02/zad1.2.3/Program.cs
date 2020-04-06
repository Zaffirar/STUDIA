using System;
using System.Collections.Generic;

namespace zad1._2._3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Mamy listę liczb typu double: ");
            List<double> ListaF = new List<double>
            {
                2.434,
                -21345.32456,
                6.3423,
                -56,123
            };
            ListaF.ForEach(delegate (double liczba) {
                Console.WriteLine(liczba);
            });
            Console.WriteLine("Po użyciu ConvertALL otzymujemy listę intów: ");
            List<int> ListaI = ListaF.ConvertAll<int>(delegate (double l) { return (int)l; });
            ListaI.ForEach(delegate (int liczba) {
                Console.WriteLine(liczba);
            });
            List<int> sublist = ListaI.FindAll(delegate (int l) { return l < 0 ? true : false; });
            Console.WriteLine("Przy użyciu FindAll znajduję wszystkie inty < 0.");
            sublist.ForEach(delegate (int l) { Console.WriteLine(l); });
            Console.WriteLine("Usuwam z listy intów wszystkie liczby < 0, a było ich {0}.",
            ListaI.RemoveAll(delegate (int l) { return l < 0 ? true : false; }));
            Console.WriteLine("Teraz lista intów wygląda tak:");
            ListaI.ForEach(delegate (int liczba) {
                Console.WriteLine(liczba);
            });
        }
    }
}
