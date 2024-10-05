using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Hello world");
            //Console.Write("ben arzu"); 
            
            #endregion

            #region StringDeğişkenler

            string customerName;
            string customerSurname;
            string customerEmail, district, city;
            string customerPhone;

            customerName = "Arzu";
            customerSurname = "Fırat";
            customerPhone = "0545 903 46 87";
            customerEmail = "af@gmail.com";
            district = "kadıköy";
            city = "istanbul";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Müşteri: " + customerName+ " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("E-mail Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district+ " " + city);
            Console.WriteLine("------------------------------------");


            #endregion

            #region IntDeğişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburger = 300;
            int pizza = 250;
            int kola = 35;
            int limonata = 30;
            int cips = 50;
            int su = 10;

            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---Hamburger: " + hamburger + " TL ");
            Console.WriteLine("---Pizza: " + pizza + " TL "); 
            Console.WriteLine("---Kola: " + kola + " TL "); 
            Console.WriteLine("---Limonata: " + limonata + " TL "); 
            Console.WriteLine("---Cips: " + cips + " TL "); 
            Console.WriteLine("---Su: " + su + " TL ");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            int sayihamburger=3;
            int sayipizza=0;
            int sayikola=3;
            int sayilimonata=0;
            int sayicips=1;
            int sayisu=3;

            int totalhamburgerfiyat;
            int totalpizzafiyat;
            int totalkolafiyat;
            int totallimonatafiyat;
            int totalcipsfiyat;
            int totalsufiyat;

            totalhamburgerfiyat = sayihamburger * hamburger;
            totalcipsfiyat=sayicips * cips;
            totalkolafiyat = sayikola * kola;
            totallimonatafiyat = sayilimonata * limonata;
            totalpizzafiyat = sayipizza * pizza;
            totalsufiyat=sayisu * su;


            Console.WriteLine("Hamburger Tutarı: " + totalhamburgerfiyat + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalpizzafiyat + " TL");
            Console.WriteLine("Cips Tutarı: " + totalcipsfiyat + " TL");
            Console.WriteLine("Kola Tutarı: " + totalkolafiyat + " TL");
            Console.WriteLine("Limonata Tutarı: " + totallimonatafiyat + " TL");
            Console.WriteLine("Su Tutarı: " + totalsufiyat + " TL");
            Console.WriteLine();
            int toplam=totalcipsfiyat+totalhamburgerfiyat+totalkolafiyat+totalpizzafiyat+totallimonatafiyat+totalsufiyat;

            Console.WriteLine("Toplam Ödenecek Tutar: " + toplam + " TL");


            #endregion



            Console.Read();
        }
    }
}
