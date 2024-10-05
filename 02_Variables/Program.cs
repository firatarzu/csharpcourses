using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDeğişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //double appleprice, orangeprice, strawberryprice, potatoprice, tomatoprice;

            //appleprice = 14.85;
            //orangeprice = 20.95;
            //strawberryprice = 45;
            //potatoprice = 9.74;
            //tomatoprice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + appleprice  + " TL " );
            //Console.WriteLine("---- Portakal Birim Fiyatı: " +orangeprice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryprice +" TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoprice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoprice + " TL");

            //double applegram, orangegram, strawberrygram,potatogram, tomatogram;
            //applegram = 1.245;
            //orangegram = 2.650;
            //strawberrygram = 0.750;
            //potatogram = 4.859;
            //tomatogram=3.745;

            //double appletotalprice = applegram * appleprice;
            //double orangetotalprice= orangegram * orangeprice;
            //double strawberrytotalprice= strawberrygram * strawberryprice;
            //double potatototalprice= potatogram * potatoprice;
            //double tomatototalprice=tomatogram * tomatoprice;
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün: Elma - " + " Birim Fiyatı => " + appleprice + " - Gramaj: " + applegram + " Ödenecek Tutar: " + appletotalprice + " TL ");
            //Console.WriteLine("Alınan ürün: Portakal - " + " Birim Fiyatı => " + orangeprice + " - Gramaj: " + orangegram + " Ödenecek Tutar: " + orangetotalprice + " TL ");
            //Console.WriteLine("Alınan ürün: Elma - " + " Birim Fiyatı => " + strawberryprice + " - Gramaj: " + strawberrygram + " Ödenecek Tutar: " + strawberrytotalprice + " TL ");
            //Console.WriteLine("Alınan ürün: Elma - " + " Birim Fiyatı => " + potatoprice + " - Gramaj: " + potatogram + " Ödenecek Tutar: " + potatototalprice + " TL ");
            //Console.WriteLine("Alınan ürün: Elma - " + " Birim Fiyatı => " + tomatoprice + " - Gramaj: " + tomatogram + " Ödenecek Tutar: " + tomatototalprice + " TL ");
           
            //double shoppingtotalprice=appletotalprice+orangetotalprice+tomatototalprice+potatototalprice+strawberrytotalprice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingtotalprice + " Tl");

            #endregion

            #region CharDeğişkenler

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);

            #endregion

            #region KlavyedenVeriGirişleriStringDeğişkenler
            //Console.WriteLine();
            //Console.WriteLine("***** Csharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengercity, passengerAge, passengerID;

            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname=Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict=Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengercity=Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge=Console.ReadLine();

            //Console.Write("Kimlik: ");
            //passengerID=Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("İkamet: " + passengerDistrict + "/" + passengercity);
            //Console.WriteLine("Yolcu Yaş: " + passengerAge);
            //Console.WriteLine("Kimlik Bilgisi: "+ passengerID);

            #endregion

            #region KlavyedenTamSayıGirişleriveDönüşümler

            //int shoesPrice, computerPrice, chairPrice,tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice =12000;

          
            //int shoesCount, computerCount,chairCount,tvCount;

            //Console.Write("Ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Sandalye sayısını giriniz: ");
            //chairCount=int.Parse(Console.ReadLine());
            
            //Console.Write("Televizyon sayısını giriniz: ");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerPrice*computerCount+chairPrice*chairCount+tvPrice*tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice);


            #endregion

            #region KlavyedenOndalıklıSayıİşlemleri

            //double exam1, exam2,exam3,result;

            //Console.Write("1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region KlavyedenKarakterGirişleri

            char gender;
            Console.Write("Cinsiyet Seçiniz: " );
            gender=char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();

        }
    }
}
