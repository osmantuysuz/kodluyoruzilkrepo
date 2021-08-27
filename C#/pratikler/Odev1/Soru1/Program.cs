using System;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilecekSayiAdedi;
            int[] girilenSayilar;

            Console.WriteLine("****Lütfen pozitif bir sayı giriniz!****");
            Console.WriteLine("Kaç adet sayı gireceksiniz: ");
            girilecekSayiAdedi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anlaşıldı. Gireceğiniz sayılardan çift olanları size göstereceğim...");

            for (int i = 0; i < girilecekSayiAdedi; i++)
            {
                Console.WriteLine(i + ". sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi%2==0){
                    girilenSayilar[i] = sayi;
                }
            }
            
            foreach (var item in girilenSayilar){
                Console.WriteLine(girilenSayilar[item]);
            }
        }
    }
}
