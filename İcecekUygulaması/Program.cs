using System;
using System.Linq;

namespace İcecekUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Id = "root";
            const string Password = "1234";
            string gId, gPassword; // girilenId veya Password
            int bloke = 3;

            do
            {
                do
                {
                    Console.WriteLine($"Kalan hakkınız:{bloke}");
                    Console.Write($"Kullanıcı Adını Giriniz:");
                    gId = Console.ReadLine();
                    Console.Write("Şifrenizi Giriniz:");
                    gPassword = Console.ReadLine();
                    Console.WriteLine("--------------------");
                    if (gId == "" || gPassword == "")
                    {
                        Console.WriteLine("Boş Değer Girilemez. Tekrar Deneyiniz!");  // şifrenin boş veya yanlış olması denetimi ve 3 yanlış girişten sonra programdan çıkması
                    }

                } while (gId == "" || gPassword == "");

                if (gId != Id || gPassword != Password)
                {
                    if (bloke == 1)
                    {
                        Console.WriteLine("Sistem bloke olmuştur.");
                        return;
                    }
                    Console.WriteLine("Kullanıcı Adı veya Şifre Yanlış Girildi. Lütfen Tekrar Deneyiniz.!");
                    bloke -= 1;
                }

            } while (gId != Id || gPassword != Password);

            string denetim;
            int fiyat = 0;
            string cevap;
            do
            {

                Console.WriteLine("Lütfen Seçim Yapınız"); // içeçek seçimi
                Console.WriteLine("--------------------");
                Console.WriteLine("1 - Coca Cola (5 TL)");
                Console.WriteLine("2 - Limonata (10 TL)");
                Console.WriteLine("3 - İce Tea (7 TL)");
                Console.WriteLine("4 - Turkish Coffee (15 TL)");
                bool dongu;
                do
                {
                    dongu = false;
                    denetim = Console.ReadLine();
                    Console.WriteLine("--------------------");

                    switch (denetim)
                    {
                        case "1":
                            fiyat += 5;
                            break;
                        case "2":
                            fiyat += 10;
                            break;
                        case "3":
                            fiyat += 7;
                            break;
                        case "4":
                            fiyat += 15;
                            break;
                        default:
                            Console.Write("Lütfen Belirlenen Aralıkta Tekrar Deneyiniz:");
                            dongu = true;
                            break;
                    }
                } while (dongu == true);

                Console.WriteLine($"Ödemeniz gereken miktar {fiyat} TL dir.");
                Console.WriteLine("Bir tane daha almak için E tuşuna basınız. Devam etmek içinse herhangi bir tuş giriniz..");
                cevap = Console.ReadLine();
                cevap = cevap.ToLower();
            } while (cevap == "e");

            string cevapIki;
            int nakitOdeme;
            do
            {
                Console.WriteLine("Ödemeniz Nakit mi Kredi Kartı mı olsun ? n/k"); // ödeme
                cevapIki = Console.ReadLine();
                cevapIki = cevapIki.ToLower();

                if (cevapIki == "k")
                {
                    Console.WriteLine($"{fiyat} TL tahsil edilmiştir.!");
                    break;
                }
                else if (cevapIki == "n")
                {
                    Console.Write("Nakit miktarı giriniz:");
                    nakitOdeme = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        if (nakitOdeme >= fiyat)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Ödenen miktar yetersizdir {fiyat - nakitOdeme} daha ödemeniz gerekmektedir. Tekrar Giriş Yapınız:");
                            nakitOdeme += Convert.ToInt32(Console.ReadLine());
                        }
                    } while (nakitOdeme < fiyat);
                    Console.WriteLine($"Para Üstünüz {nakitOdeme - fiyat} TL ' dir. ");
                    break;
                }
                Console.WriteLine("Lütfen doğru seçim yapınız");

            } while (true);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Bizleri Tercih Ettiğiniz İçin Teşekkür Ederiz.. :)");
            Console.WriteLine("Tel: 05394250083");
            Console.WriteLine("Email = yvzsylu@gmail.com");
            Console.WriteLine("Soylu İçecekleri A.Ş");
        }
    }
}

