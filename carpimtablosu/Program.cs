﻿using System;

namespace carpimtablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}*{1}={2}\t",i,j,(i*j));
                }
                Console.WriteLine("----------------------------");
            }
        }
    }
}
