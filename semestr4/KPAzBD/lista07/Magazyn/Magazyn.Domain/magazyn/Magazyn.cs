using Magazyn.Domain.towar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn.Domain.magazyn
{
    class Magazyn
    {
        public int Id { get; set; }
        public string Adres { get; set; }
        public int Pojemnosc { get; set; }
        public IList<KonkretnyTowar> Towary { get; set; }
        public IList<KonkretnyTowar> TowaryDoWysylki { get; set; }
        public bool IsFull();
        public bool Dodaj(KonkretnyTowar T);
        public int DoWysylki(TypTowaru T);
        public bool Wyslano(KonkretnyTowar T);
        public int StanDanegoTowaru(TypTowaru T);
    }
}
