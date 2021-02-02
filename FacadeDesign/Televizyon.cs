using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesign
{
    public class Televizyon
    {
        public void TelevizyonAcik()
        {
            Console.WriteLine("Televizyon ---> Acik!");
        }
        public void TelevizyonKapali()
        {
            Console.WriteLine("Televizyon ---> Kapali.");
        }
    }
}
