using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming covertion
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Ekledi : " + urun.Adi );
        }
        public void Ekle2(string urunAdi, string acıklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :"+ urunAdi);
        }

        }
    }
}
