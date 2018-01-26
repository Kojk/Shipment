using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipment s = new Shipment();
            Item item = new Item();
            item.Nazov = "polozka1";
            item.PocetKusov = 3;
            item.CenaZaKus = 5.6;
            s.AddItem(item);

            item = new Item();
            item.Nazov = "polozka2";
            item.PocetKusov = 4;
            item.CenaZaKus = 1.6;
            s.AddItem(item);

            item = new Item("polozka3", 4, 2.3);    // pouzity konstructor (struct)
            s.AddItem(item);

            //priradenie notifikacni metody udalosti(eventu)
            Notifikace n = new Notifikace();
            s.TrackingNumbrePridane += n.Notify;

            s.TrackingNumber = "122156hgj";


            Console.ReadLine();
        }
       
    }
}
