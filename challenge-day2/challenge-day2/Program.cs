using System;
using System.Collections.Generic;

namespace challenge_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong testcases = ulong.Parse(Console.ReadLine());

            Dictionary<String, int> d = new Dictionary<string, int>();
            for(ulong i =0; i < testcases; i++ )
            {
                string n = Console.ReadLine();

                if (d.ContainsKey(n))
                {
                    d[n] += 1;
                    Console.WriteLine(n + d[n]);

                } else
                {
                    d.Add(n, 0);
                    Console.WriteLine("OK");
                }
               
            }
        }
    }
}
