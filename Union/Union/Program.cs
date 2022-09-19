using System;
using System.Collections.Generic;

namespace Union
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5 };
            int[] b = {1,2,3};

            HashSet<int> set = new HashSet<int>();

            for(int i=0; i < a.Length; i++)
            {
                set.Add(a[i]);
            }

            set.UnionWith(b);

            foreach(int x in set)
            {
                Console.Write(x + " ");
            }

        }
    }
}
