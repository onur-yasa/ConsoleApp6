using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_carpan
{
   public class asal
    {
        public static int[] AsalCarpanlar (int n)
        {
            string carpanListesi = "";
            int i = 2;
            //asal carpanları bulalaım
            while (n>1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else
                    i++;

            }
            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(",");

            string s = carpanlar[0];
            
            string y = s;

            for ( i = 0; i < carpanlar.Length; i++)
            {
                if (!(s==carpanlar[i]))
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }
            carpanlar = y.Split(',');
            int[] asalCarpanlar = new int[carpanlar.Length];
            for (i = 0; i < asalCarpanlar.Length; i++)
                asalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);
            return asalCarpanlar;
        }
        public static int AsalCarpanlarToplami(int n)
        {
            int[] asalCarpanlar = AsalCarpanlar(60);
            int t = 0;
            for (int i = 0; i < asalCarpanlar.Length; i++)
            
                t += asalCarpanlar[i];
            
            return t;
        }
        public static int AsalCarpanlarCarpimi (int n)
        {
            int[] asalCarpanlar = AsalCarpanlar(60);
            int c = 1;
            for (int i = 0; i < asalCarpanlar.Length; i++)
            
                c *= asalCarpanlar[i];
            
            return c;
        }
    }
}
