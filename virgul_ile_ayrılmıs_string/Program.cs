using System;

namespace virgul_ile_ayrılmıs_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //konsaldan ifadenin okunması
            string ifade = Console.ReadLine();
            string[] bolunmusifade = ifade.Split(",");
            int n = bolunmusifade.Length;

            //sayısal dizi
            int[] sayisalDizi = new int[n];

            //ayrıştırma işlemi

            for (int i = 0; i < n; i++)
            {
                sayisalDizi[i] = Convert.ToInt32(bolunmusifade[i]);
                Console.WriteLine("dizi[{0}]={1}",i+1,sayisalDizi[i]);
            }
        }
    }
}
