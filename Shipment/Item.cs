using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    struct Item
    {
        public string Nazov;
        public int PocetKusov;
        public double CenaZaKus;

        public Item(string Nazov, int PocetKusov, double CenaZaKus)
        {
            this.Nazov = Nazov;
            this.PocetKusov = PocetKusov;
            this.CenaZaKus = CenaZaKus;
        }
    }
}
