using System;

namespace değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 2;
            string metin = "2";

            int degistirTopla = sayi + Convert.ToInt32(metin);
            Console.WriteLine(degistirTopla);
        }
    }
}
