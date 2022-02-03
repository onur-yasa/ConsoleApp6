using System;

namespace diziolusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] number = new int[5];

            //int[] square = new int[5];

            //int n = number.GetLength(0);

            //for (int i = 0; i < n; i++)
            //{
            //    number[i] = new Random().Next(15, 30);
            //    square[i] = number[i] * number[i];
            //    Console.WriteLine("{0} karesi={1}",number[i],square[i]);
            //}
            //Console.ReadLine();

            //------------------------------------------------------------------
            Console.WriteLine("n değerini giriniz.");
            int limit = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new Dizi().Olustur(limit);
            Console.WriteLine("\n Dizinin en büyük elemanı:{0}",Dizi.EnBuyuk(sayilar));
            Console.WriteLine("\n Dizinin en küçük elemanı:{0}",Dizi.EnKucuk(sayilar));

        }
        
        
    }
}
