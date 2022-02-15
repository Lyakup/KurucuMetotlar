using System;

namespace KurucuMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Burak", "Layık", "Muhasebe", 758869);
            calisan1.CalisanBilgileri();

            Console.WriteLine("");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Meryem";
            calisan2.Soyad = "Layık";
            calisan2.Departman = "Pazarlama";
            calisan2.No = 46493;

            calisan2.CalisanBilgileri();

            Console.WriteLine("");

            Calisan calisan3 = new Calisan("Berkan", "Layık");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public string Departman;
        public int No;

        public Calisan(string ad, string soyad, string departman, int no)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Departman = departman;
            this.No = no;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : " + Ad);
            Console.WriteLine("Çalışan Soyadı : " + Soyad);
            Console.WriteLine("Çalışan Departmanı : " + Departman);
            Console.WriteLine("Çalışan Numarası : " + No);
        }
    }
}