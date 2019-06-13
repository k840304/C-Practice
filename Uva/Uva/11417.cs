using System;

namespace Uva
{
    class uva11417
    {
        static void Main(string[] args)
        {
            string num;
            int N;
            while ((num = Console.ReadLine()) != null && num != "0")
            {
                N = Convert.ToInt32(num);
                int i, j, G = 0;
                for (i = 1; i < N; i++)
                {
                    for (j = i + 1; j <= N; j++)
                    {
                        G += GCD(i, j);
                    }
                }
                Console.WriteLine(G);
            }
        }
    
        public static int GCD(int a, int b)
        {
            int temp;
            while (b != 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            return a;
        }
   }
}