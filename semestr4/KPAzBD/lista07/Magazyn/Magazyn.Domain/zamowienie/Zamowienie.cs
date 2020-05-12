using Magazyn.Domain.towar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn.Domain.zamowienie
{
    class Zamowienie
    {
        public int Id { set; get; }
        public IList<KeyValuePair<TypTowaru, int>> TrescZamowienia { get; set; }
        public string status { get; set; }
        public int IdKuriera { get; set; }

    }
}
