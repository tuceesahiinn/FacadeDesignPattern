using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesign
{
    public class EvFacade
    {
        public EvKontrolSistemi evKontrolSistemi;
        public Isiklar isiklar;
        public Klima klima;
        public MuzikSistemi muzikSistemi;
        public Ocak ocak;
        public TelefonCevapSistemi telefonCevapSistemi;
        public Televizyon televizyon;
        public Utu utu;

        public EvFacade()
        {
            evKontrolSistemi = new EvKontrolSistemi();
            isiklar = new Isiklar();
            klima = new Klima();
            muzikSistemi = new MuzikSistemi();
            ocak = new Ocak();
            telefonCevapSistemi = new TelefonCevapSistemi();
            televizyon = new Televizyon();
            utu = new Utu();
        }
        public void EvdenAyrilma()
        {
            isiklar.IsiklarKapali();
            klima.KlimaKapali();
            muzikSistemi.MuzikSistemiKapali();
            ocak.OcakKapali();
            televizyon.TelevizyonKapali();
            utu.UtuPrizdeDegil();
            evKontrolSistemi.EvKontrolSistemiAktif();
            telefonCevapSistemi.EvdeDegilMesaji();
        }
        public void Evde()
        {
            isiklar.IsiklarAcik();
            klima.KlimaAcik();
            muzikSistemi.MuzikSistemiAcik();
            ocak.OcakAcik();
            televizyon.TelevizyonAcik();
            utu.UtuPrizde();
            evKontrolSistemi.EvKontrolSistemiPasif();
            telefonCevapSistemi.EvdeMesaji();
        }
    }
}
