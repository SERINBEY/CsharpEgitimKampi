using Microsoft.CSharp;
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
             #region Doubledegişkenler
            //double number;
            //number = 4.81;
            //Console.WriteLine(number);

            //Console.WriteLine("*****Fiyat Listesi******");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("----Elma Birim Fiyatı:" + applePrice+"TL");
            //Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice+"TL");
            //Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("----Patates Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("----Domates Birim Fiyatı:" + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram , strawberryGram, tomatoGram, patotaGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patotaGram = 4.859;
            //tomatoGram = 3.75;
            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double patotaTotalPrice = patotaGram * potatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - "+"Birim Fiyat : " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar:"+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - "+"Birim Fiyat : " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar:"+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - "+"Birim Fiyat : " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar:"+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: patates - "+"Birim Fiyat : " + potatoPrice + " - Gramaj: " + patotaGram + " - Toplam Tutar:"+patotaTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - "+"Birim Fiyat : " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar:"+tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + patotaTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " Tl ");
            #endregion

            #region char degişkenler


            //char symbol;
            //symbol = 'o';
            //Console.WriteLine("gay" + symbool);



            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("******CSharp Hava Yolları Yolcu Bilgisi  ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict= Console.ReadLine();
            //Console.Write("Şehir Bilgisi:");
            //passengerCity= Console.ReadLine();
            //Console.Write("Yolcu Yaş");
            //passengerAge= Console.ReadLine();
            //Console.Write("yolcu Tc Kimlik No");
            //passengerIdentityNumber= Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Yolcu Tc Kimlik no: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " +passengerName+ " " + passengerSurname+ " " + passengerDistrict+ " / " + passengerCity+ " " + passengerAge );

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler
            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;

          


            //Console.Write("Lütfen aldıgınız ayakkabı sayısını giriniz: ");
            //shoesCount= int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldıgınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldıgınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldıgınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice; ;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+totalPrice);
            



            #endregion

            #region Klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;
            //Console.WriteLine("Lütfen 1. Sınav Notunu Giriniz");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. Sınav Notunu Giriniz");
            //exam2= double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 3. Sınav Notunu Giriniz");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav ortalamanız:" + result);


            #endregion

            #region klavyeden karakter girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Belirtiniz: ");
            //gender = char.Parse(Console.ReadLine());



            #endregion

            Console.Read();

                
               


        }
    }
}
