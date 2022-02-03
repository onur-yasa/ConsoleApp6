using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Sayıyı Girin:");
            //double sayi = Convert.ToInt32(Console.ReadLine());
            //double faktoriyel = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel = faktoriyel * i;
            //}

            //Console.WriteLine("{0} sayısının faktöriyeli={1}", sayi, faktoriyel);
            //Console.ReadKey();

            double boy, kilo, indeks = 0;
            Console.Write("Boyunuzu m cinsinden Giriniz (Ör:1,65)  : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            indeks = kilo / (boy * boy);
            Console.WriteLine("------------------------");
            Console.WriteLine("Vücut kitle indeksi"+indeks);

            if(indeks<18)
            {
                Console.WriteLine("Zayıf");
            }
            else if (indeks>=18 && indeks<25 )
            {
                Console.WriteLine("Normal");
            }
            else if (indeks >= 25 && indeks < 30)
            {
                Console.WriteLine("Kilolu");
            }
            else if (indeks >=30&& indeks <35)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Ciddi");
            }
            Console.ReadKey();






           // Console.WriteLine("Bir sayı gir");
           //int  s = Convert.ToInt32(Console.ReadLine());
           // int i = 1;
           // int toplam = 0;
           // while (i <= s)
           // {
           //     if (i % 2 != 0)
           //     {
           //         toplam = toplam + i;

           //     }
           //     i = i + 1;
           // }
           // Console.WriteLine("çift sayıların toplamı :" + toplam);
        }
    }
}
