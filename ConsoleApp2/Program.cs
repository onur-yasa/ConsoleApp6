using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Nasuh Onur yAŞA.";
            int nWords = 0;
            s1 = s1.Trim();
            for (int i = 0; i < s1.Length; i++)
            {
                if (Char.IsPunctuation(s1[i]) | Char.IsWhiteSpace(s1[i]))
                    nWords++;
            }
            Console.WriteLine("The sentence\n {0}\n has {1} words.",s1,nWords);


        }
    }
}
