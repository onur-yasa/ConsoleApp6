using System;

namespace _1000_den_0_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            
            for (int i = 1000; i >= 0; i--)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("{0} sayısı 5'in katıdır.", i);
                    t += 1;
                }
                

            }
            Console.WriteLine("Adeti : " +t);
            
        }
    }
}
