using System;

namespace RakamlarToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} sayının rakamları toplamı ={1}",n, RakamlarToplami(n));
            Console.ReadLine();
        }
        public static int RakamlarToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n>0)
            {
              rakam = n % 10;
                n = n / 10;
                toplam = toplam + rakam;
            }
            return toplam;
        }
    }
}
