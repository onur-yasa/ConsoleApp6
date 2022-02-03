using System;

namespace Aritmetik_Ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n değerini giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new Dizi().Olustur(n);
            //Console.WriteLine("Dizinin aritmetik ortalaması : {0:F2}",Dizi.StandartSapma(X));
            Dizi dizi = new Dizi();
            int[] tekSayilarDizisi = dizi.TekdiziOlustur(X);
            Dizi.Yazdir(tekSayilarDizisi);
            Console.WriteLine("Tek Sayilarin Sayisi : {0,5}",dizi.TekSayilarinSayisi(X));

            int[] ciftSayilarDizisi = dizi.CiftdiziOlustur(X);
            Dizi.Yazdir(ciftSayilarDizisi);
            Console.WriteLine("Cift Sayilarin Sayisi : {0,5}", dizi.CiftSayilarinSayisi(X));
        }
    }
}
