using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesign
{
    public class TelefonCevapSistemi
    {
        public void EvdeMesaji()
        {
            Console.WriteLine("Telefon Cevap Sistemi ---> Aradiginiz Kisi Evde. Lutfen Bekleyiniz.");
        }
        public void EvdeDegilMesaji()
        {
            Console.WriteLine("Telefon Cevap Sistemi ---> Aradiginiz Kisi Evde Degil! Lutfen Daha Sonra Tekrar Arayiniz.");
        }
    }
}
