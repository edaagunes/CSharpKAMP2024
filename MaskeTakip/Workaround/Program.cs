using Entities.Concrete;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            int sonuc = Topla(3, 5);

            SelamVer("Eda");

            //Diziler / Arrays

            //string ogrenci1 = "Engin";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Eda";
            person1.LastName = "Güneş";
            person1.DateofBirthYear = 2000;
            person1.NationalIdentity = 123;

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc.ToString());
            return sonuc;
        }
        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 10000; //dbden gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Eda";
            string soyad = "Güneş";
            int dogumYili = 2000;
            long tcNo = 12345678910;


            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}