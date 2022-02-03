using System;

namespace _1_100e
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 100; i++)
            //{
            //    Console.WriteLine("{0} sayısının Karesi={1} ", i, i * i);
            //}

            int ttoplam = 0;
            int ctoplam = 0;
            int toplam = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("{0} sayısı çift sayıdır ",i);
                    ctoplam += i;
                    
                }
                else
                {
                    Console.WriteLine("{0} sayısı tek sayıdır",i);
                    ttoplam += i;
                    
                }
                toplam += i;
            }
            Console.WriteLine("1 den 100'e kadar sayıların toplamı : " + toplam);
            Console.WriteLine(ctoplam);
            Console.WriteLine(ttoplam);

        }
    }
}
