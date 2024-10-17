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
            //Console.WriteLine("selam");
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("***** Yemek Kategorileri ********");
            //Console.WriteLine();
            //Console.WriteLine("1 - Çorbalar");
            //Console.WriteLine("2 - Ana Yemekler");
            //Console.WriteLine("3 - Soguk Başlangıçlar");
            //Console.WriteLine("4 - Salatalar");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("6 - İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri ******");
            #endregion
            #region StringDeğişkenler



            //String name;
            //name = "Hasan";
            //Console.WriteLine(name);
            //string customerName;
            //string customerSurname;
            //string customerPhone    ;
            //string customerEmaiş,disrict,city   ;
            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmaiş = "deneme@gmail.com";
            //disrict = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("***** REZARVASYON KARTI *******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Müşteri:"+customerName+" "+customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmaiş);
            //Console.WriteLine("adres:" + disrict + "/" + city);
            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine();

            //customerName = "Aysegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 200 41 41";
            //customerEmaiş = "test@gmail.com";
            //disrict = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmaiş);
            //Console.WriteLine("adres:" + disrict + "/" + city);
            //Console.WriteLine("--------------------------------------------");

            #endregion
            #region IntDegişkenler



          
            //int
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice =10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int LemonadePrice = 30;

            Console.WriteLine("****** Restoran Menü Fiyatı ******");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("-----pizza:" + pizzaPrice + "TL");
            Console.WriteLine("-----kola:" + cokePrice + "TL");
            Console.WriteLine("-----limonata:" + LemonadePrice + "TL");
            Console.WriteLine("-----Kızartma:" + friesPrice + "TL");
            Console.WriteLine("-----Su:" + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("****** Restoran Menü Fiyatı ******");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalhamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
             hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount= 1;
            pizzaCount = 0;
            lemonadeCount=0;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice= cokeCount * cokePrice;
            totalWaterPrice= waterCount * waterPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalFriesPrice= friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * LemonadePrice;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalhamburgerPrice +"TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + "TL");
            Console.WriteLine("kızartma Tutarı:" + totalFriesPrice + "TL");
            Console.WriteLine("kola Tutarı:" + totalCokePrice + "TL");
            Console.WriteLine("limonata Tutarı:" + totalLemonadePrice + "TL");
            Console.WriteLine("su Tutarı:" + totalWaterPrice + "TL");

            Console.WriteLine();

            int totalPrice=totalCokePrice+totalWaterPrice+totalPizzaPrice+totalLemonadePrice+totalhamburgerPrice+totalFriesPrice+totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + "Tl");
            #endregion

            Console.Read();
                
        }
    }
}
