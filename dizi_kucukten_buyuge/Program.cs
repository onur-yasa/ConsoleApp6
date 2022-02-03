using System;

namespace dizi_kucukten_buyuge
{
    class Program
    {
        static void Main(string[] args)
        {
            int gecici;
            int[] dizi = { 2, 7, 99, 15, 13, 3, 22, 42, 21 };
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[j]>dizi[i])
                    {
                        gecici = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = gecici;
                    }
                }
            }
            foreach (int item in dizi)
            {
                Console.Write("{0},",item);
            }
            Console.ReadLine();
        }
    }
}
