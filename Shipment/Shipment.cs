using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    class Shipment
    {
        ArrayList DbPolozky = new ArrayList();
        private string trackingNumber;
        public delegate void OnShipmentMade(string message);
        public event OnShipmentMade TrackingNumbrePridane;
        public string TrackingNumber
        {
            get
            {
                return trackingNumber;
            }
            set
            {
                trackingNumber = value;
                TrackingNumbrePridane?.Invoke(GetInfo());

            }

        }
        public string GetInfo()
        {
            string message = "";
            foreach (Item balik in DbPolozky)
            {
                message += balik.Nazov + Environment.NewLine;
                message += balik.PocetKusov + Environment.NewLine;
                message += balik.CenaZaKus + Environment.NewLine;  


            }
            return message;
        }

        public void AddItem(Item item)
        {
            DbPolozky.Add(item); 
            
        }


    }
}
