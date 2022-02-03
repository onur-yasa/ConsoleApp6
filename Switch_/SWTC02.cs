using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_
{
   public static class SWTC02
    {
        public enum Renkler { Kirmizi, Yesil, Mavi }
        public static void AnaKod()
        {
            Renkler r = (Renkler)(new Random()).Next(0, 3);
            switch (r)
            {
                case Renkler.Kirmizi:
                    Console.WriteLine("Renk kırmızıdır");
                    break;
                case Renkler.Mavi:
                    Console.WriteLine("Renk mavidir");
                    break;
                case Renkler.Yesil:
                    Console.WriteLine("Reank Yeşildir");
                    break;
                default:
                    Console.WriteLine("Reank Bilinmiyor");
                    break;
            }
        }
    }
}
