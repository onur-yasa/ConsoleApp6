using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desen_uygulama
{
    class katarlar
    {
        public static void Desen1(char c,int n = 5)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0,10}", 
                    new string(c, i));
            }
        }
        public static void Desen2(char c = '-', int n = 4)
        {
            for (int i = n; i >= 0; i--)
                Console.WriteLine("{0}",
                    new string(c,i));
        }
        public static void KarakterSeti(int basalangicIndisi=65,int bitisIndisi=90,int satirKarakterSayisi=5)
        {
            for (int i = basalangicIndisi; i <= bitisIndisi; i++)
            {
                Console.Write("{0,10}",(char)i);
                if (i%5==0)
                    Console.WriteLine();
            }
        }
    }
}
