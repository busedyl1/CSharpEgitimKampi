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
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // ₺ gibi karakterleri gösterebilmek için yazdığımız kod satırıdır

            // Alt+F ile aynı yazdığımız kelimelerin hepsini başka bir kelimeyle değiştirebiliriz

            #region Double Değişkenler 
            double number;
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            patatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "₺");
            Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "₺");
            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "₺");
            Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice + "₺");
            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "₺");

            double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            patatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double patatoTotalPrice = patatoGram * patatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyat: " + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + " Birim Fiyat: " + orangePrice + " - Gramaj:" + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + " Birim Fiyat: " + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates - " + " Birim Fiyat: " + patatoPrice + " - Gramaj:" + patatoGram + " - Toplam Tutar: " + patatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + " Birim Fiyat: " + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "₺");
            #endregion

            #region Char Değişkenler

            //stringler " ile tanımlanırken char ' ile tanımlanır.

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişenler

            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("İl: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("TC Kimlik Numarası: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Yolcu Bilgileri");
            Console.WriteLine("TC Kimlik Numarası: " + passengerIdentityNumber + "  Ad Soyad: " + passengerName + " " + passengerSurname
                + "  Yaş: " + passengerAge + "   Adres" + passengerDistrict + "/" + passengerCity);

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //Başta girilen değerler string olarak kabul edilir bu yüzden sayısal kullanacaksak int a dönüştürmeliyiz

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfenaldığınız tv sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount +
                chairPrice * chairCount + tvPrice * tvCount;

            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalaması: " + result);

            #endregion

            #region Klavyeden Karakter Girişi

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            //Tek karakter girişi yapılabilir

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
