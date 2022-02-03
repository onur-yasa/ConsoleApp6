using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matemetik
{
    public class Matmtk
    {
        public static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
                s *= taban;
            return s;
        }
        public static int Okek(int s1, int s2)
        {
            int s = 1;
            while (s1 != 1 && s2 != 1)
            {
                int bol = 2;
                for (int i = 1; i <= (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        s *= bol;
                        if (s1 % bol == 0)
                            s1 = s1 / bol;
                        if (s2 % bol == 0)
                            s2 = s2 / bol;
                    }
                    else
                        bol++;

                }
            }
            return s;
        }
        public static int Obeb(int s1, int s2)
        {
            int s = 1;
            int bolen = 2;
            while (s1 != 1 && s2 != 1)
            {
                for (int i = 0; i <= (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bolen == 0 || s2 % bolen == 0)
                    {
                        if (s1 % bolen == 0 && s2 % bolen == 0)
                            s *= bolen;
                        if (s1 % bolen == 0)
                            s1 /= bolen;
                        if (s2 % bolen == 0)
                            s2 /= bolen;


                    }
                    else
                        bolen++;
                }
            }
            return s;
        }
        public static int Faktöriyel(int n)
        {
            if (n <= 1)
                return 1;
            int f= 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            return f;
        }
    }
}
