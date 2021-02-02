using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesign
{
    public class EvKontrolSistemi
    {
        public void EvKontrolSistemiAktif()
        {
            Console.WriteLine("Ev Kontrol Sistemi ---> Aktif!");
        }
        public void EvKontrolSistemiPasif()
        {
            Console.WriteLine("Ev Kontrol Sistemi ---> Kapali.");
        }
    }
}
