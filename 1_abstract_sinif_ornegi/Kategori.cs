using System;
using System.Collections.Generic;
using System.Text;

namespace _1_abstract_sinif_ornegi
{
    class Kategori : Urun
    {
        public string kategoriAdi;
        public string urunKodu;
        public string urunAdi;
        public string urunMensei;

        public void UrunListele()
        {
            Console.WriteLine("Kategori Adı : "+this.kategoriAdi);
            Console.WriteLine("Ürün Kodu : "+ this.urunKodu);
            Console.WriteLine("Ürün Adı : "+this.urunAdi);
            Console.WriteLine("Ürün Menşei : "+ this.urunMensei);
            Console.WriteLine("------------------------------------");
        }

        public Kategori(string kategoriAdi, string urunKodu, string urunAdi, string urunMensei)
        {
            this.kategoriAdi = kategoriAdi;
            this.urunKodu = urunKodu;
            this.urunAdi = urunAdi;
            this.urunMensei = urunMensei;
        }

    }
}
