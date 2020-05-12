using System;
using System.Collections.Generic;
using System.Text;
using Magazyn.Domain.magazyn;
using Magazyn.Domain.towar;
using Magazyn.Domain.zamowienie;


namespace Magazyn.Application
{
    interface IMagazynService
    {
        public void DodajDoMagazynu(Magazyn M, KonkretnyTowrat T);
        public void WyslijPomiedzyMagazynami(Magazyn M1, Magazyn M2, KonkretnyTowar T);
        public void PrzygotujZamowienie(Magazyn M, Zmowienie Z);
        public IList<KonkretnyTowar> Zwrocstan(Magazny M);
        public void OdbierzTowary(Magazyn M, IList<KonkretnyTowar>);

    }
}
