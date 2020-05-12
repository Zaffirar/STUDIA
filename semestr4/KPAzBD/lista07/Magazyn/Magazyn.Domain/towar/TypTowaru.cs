using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn.Domain.towar
{
    class TypTowaru
    {
        public int Id { get; set; }
        public int Szerokosc { get; set; }
        public int Wysokosc { get; set; }
        public int Dlugosc { get; set; }
        public int Waga { get; set; }
        public string Producent { get; set; }

    }
}
