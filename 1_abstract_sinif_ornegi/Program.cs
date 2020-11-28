using System;

namespace _1_abstract_sinif_ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Başladı!");

            Kategori u1  = new Kategori("Aksesuar","MXLY2TU/A","Lightning USB Kablo 1M","USA");
            u1.UrunListele();

            Kategori u2 = new Kategori("Elektronik Cihaz", "MD101TU/A", "MacBook Pro 13 i5/2.5GHz", "USA");
            u2.UrunListele();

            Kategori u3 = new Kategori("Giyim", "Trendyol112T", "Lacivert ekose gömlek", "Fransa");
            u3.UrunListele();

        }
    }
}
