using System;

namespace EvEsyaları
{
    class Program
    {
        static void Main(string[] args)
        {
            EvOdalari esya = new EvOdalari();
            esya.yatak = 5;
            esya.masa = -5;
                esya.dolap = -1;
                esya.tablo = -6;
                esya.bilgisiyar = 5;
                esya.telefon = 4;
                esya.televizyon = 7;


            if (esya.yatak < 0)
            {
                Console.WriteLine("Yatak Sayısı Hatalı Giriş Yapılmıştır");
            }
             if (esya.masa < 0)
            {
                Console.WriteLine("Masa Sayısı Hatalı Giriş Yapılmıştır");
            }
             if (esya.dolap < 0)
            {
                Console.WriteLine("Dolap Sayısı Hatalı Giriş Yapılmıştır");
            }
             if (esya.tablo < 0)
            {
                Console.WriteLine("Tablo Sayısı Hatalı Giriş Yapılmıştır");
            }
             if (esya.bilgisiyar < 0)
            {
                Console.WriteLine("Bilgisiyar Sayısı Hatalı Giriş Yapılmıştır");
            }
             if (esya.telefon < 0)
            {
                Console.WriteLine("Telefon Sayısı Hatalı Giriş Yapılmıştır");
            }
             if (esya.televizyon < 0)
            {
                Console.WriteLine("Televizyon Sayısı Hatalı Giriş Yapılmıştır");
            }
         
            
            

            
        }
    }
}
