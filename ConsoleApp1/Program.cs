using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı değerini giriniz");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.WriteLine("{0}",sayilar[i]);
            }
            Console.WriteLine("en büyükk{0}", enbuyuk(sayilar));
        }

        public static int enbuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                    eb = dizi[i];
            }
            return eb;
            
            
        }
    }
}
