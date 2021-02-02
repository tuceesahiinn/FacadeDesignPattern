using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesign
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string kullaniciAdi="TugceSahin";
            const string sifre="123456";
            const int denemeHakki = 3;
            int deneme = 0;
            string girilenKullaniciAdi, girilenSifre,girilenEvdeOlmaDurumu;
            EvFacade evFacade = new EvFacade();
            while (deneme < denemeHakki)
            {
                Console.WriteLine("------------->>>GUVENLIK SISTEMINE HOSGELDINIZ!<<<------------\n");
                Console.WriteLine("KULLANICI ADI: ");
                girilenKullaniciAdi = Console.ReadLine();
                Console.WriteLine("SİFRE: ");
                girilenSifre = Console.ReadLine();
                if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == sifre)
                {
                    Console.WriteLine("------------->>>GIRIS BASARILI<<<-------------");
                    Console.WriteLine("EVDE--->1 EVDE DEGIL--->0");
                    Console.WriteLine("EVDE OLMA DURUMUNUZ: ");
                    girilenEvdeOlmaDurumu = Console.ReadLine();
                    if (girilenEvdeOlmaDurumu == "1")
                    {
                        Console.WriteLine("\n-------------->>>EVDE KALMA KONTROL<<<--------------\n");
                        evFacade.Evde();
                        Console.WriteLine("\n------------->>>CIKMAK ICIN HERHANGI BIR TUSA BASINIZ...<<<-------------\n");
                    }
                    else if (girilenEvdeOlmaDurumu == "0")
                    {
                        Console.WriteLine("------------->>>EVDEN AYRILMA KONTROL<<<-------------\n");
                        evFacade.EvdenAyrilma();
                        Console.WriteLine("\n------------->>>CIKMAK ICIN HERHANGI BIR TUSA BASINIZ...<<<-------------\n");
                    }
                    else
                    {
                        Console.WriteLine("\n------------->>>GECERSIZ DEGER GIRDINIZ!<<<-------------");
                        Console.WriteLine("\n------------->>>SISTEM ERISIMINIZE ENGELLENDİ!<<<-------------");
                        Console.WriteLine("\n------------->>>CIKMAK ICIN HERHANGI BIR TUSA BASINIZ...<<<-------------");
                    }
                    break;
                }
                Console.WriteLine("------------->>>GIRIS BASARILI DEGIL! LUTFEN TEKRAR DENEYINIZ<<<-------------");
                deneme++;
                Console.WriteLine("KALAN DENEME HAKKINIZ ");
                Console.WriteLine(denemeHakki - deneme);
            } 
            Console.ReadLine();
        }
    }
}
