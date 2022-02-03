using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetik_Ortalama
{
    public class Dizi

    {
        public int[] Olustur(int limit)
        {
            int[] sayilar = new int[limit];
            Console.WriteLine("");
            for (int i = 0; i < limit; i++)
                
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.Write("{0,3}",sayilar[i]);
            }
            Console.WriteLine("");
            return sayilar;
        }
        public static double AritmetikOrtalama(int[] X)
        {
            double toplam = 0;
            for (int i = 0; i < X.Length;
                i++)

                toplam += X[i];
            return toplam / X.Length;
        }
        public static double StandartSapma(int[] X)
        {
            double aritmetikOrtalama = AritmetikOrtalama(X);
            double t = 0, f = 0;

            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmetikOrtalama;
                t += Math.Pow(f, 2);
            }
            return Math.Sqrt(t / (X.Length - 1));


        }
        public int TekSayilarinSayisi(int[] X)
        {
            int tekSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                    tekSayilarinSayisi++;
            }
            return tekSayilarinSayisi;
        }
        public int CiftSayilarinSayisi(int[] X)
        {
            int ciftSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                    ciftSayilarinSayisi++;
            }
            return ciftSayilarinSayisi;
        }

        public int[] TekdiziOlustur(int[] X)
        {
            
            int[] tekDizi = new int[TekSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i]%2==1)
                {
                    tekDizi[y] = X[i];
                    y++;
                }
                
            }
            return tekDizi;
        }
        public int[] CiftdiziOlustur(int[] X)
        {

            int[] ciftDizi = new int[CiftSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftDizi[y] = X[i];
                    y++;
                }

            }
            return ciftDizi;
        }
        public static void Yazdir (int[] X)
        {
            Console.WriteLine("");
            for (int i = 0; i < X.Length; i++)
            
                Console.Write("{0,3}",X[i]);
            Console.WriteLine("");
            
        }
    }
}
