using System;

namespace Matemetik
{
    class Program
    {
        static void Main(string[] args)
        {
            //double s1 = Convert.ToDouble(Console.ReadLine());
            //double s2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("{0}^{1}={2}",s1,s2,Matmtk.UstAlma(s1,s2));

            //Console.WriteLine("OKEK({0},{1}) ={2}",s1,s2,Matmtk.Okek((int)s1,(int)s2));
            // Console.WriteLine("OBEB({0},{1}) ={2}", s1, s2, Matmtk.Obeb((int)s1, (int)s2));

            Console.WriteLine("n Sayı değerini giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, Matmtk.Faktöriyel(n));

            int t = 0;
            for (int i = 2; i < 9; i++)
            {
                t += Matmtk.Faktöriyel(i);
                Console.WriteLine("{0}!= {1}",i,Matmtk.Faktöriyel(i));
            }
            Console.WriteLine("Ortalama={0:F2}",(double)t/7);
        }
    }
}
