using System;

namespace kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repeat yourself - Kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45 ;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu")
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artş butonunu göster")
            }
            else
            { Console.WriteLine("değişmedi butonu)}
            if (sistemeGirisYapmisMi == true) ;
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("giriş yap butonu");

            }
            Console.WriteLine(kategoriEtiketi);
            {

            }

            
}
