using System;

namespace _2_lik_tabandan_10_luk_tabana
{
    class Program
    {
        static void Main(string[] args)
        {
            //ikilik sayının okunması
            string ikilikSayi = Console.ReadLine();

            //uzunluğu belirle
            int n = ikilikSayi.Length;

            //her bir basamağın dizide tutulması

            int[] basamaklar = new int[n];

            //onluk karşılığı

            int sayi = 0;
            bool kontrol = true;
            for (int i = 0; i < n; i++)
            {
                if (!(ikilikSayi[i]=='0'|| ikilikSayi[i]=='1'))
                {
                    Console.WriteLine("\aHatalı Giriş");
                    kontrol = false;
                    break;
                }
                basamaklar[i] = (int)(ikilikSayi[i] - '0');
            }
            //2 lik sistemden onluk sisteme geçiş
            if(kontrol)
            {
                for (int i = 0; i < n; i++)
                
                    sayi += (int)Math.Pow(2, n - i - 1) * basamaklar[i];
                Console.WriteLine("({0}) ikilik sayi = {1}",ikilikSayi,sayi);
                
            }
        }
    }
}
