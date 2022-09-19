using System;
using System.Diagnostics;

namespace Challenge_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split();

            string[] input = Console.ReadLine().Split();

            
            int n = int.Parse(nk[0]);

            int k = int.Parse(nk[1]);

            int kScore = int.Parse(input[k]);

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(input[i]);
                
                if(val>=kScore && val > 0)
                {
                    count++;
                }else
                {
                    break;
                }
            }
            Console.WriteLine(count);


        }

    }
}
