using System;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "0";
            int k = 8;
            for(int i=0; i < 17; i++)
            {
                for(int j=0; j < 17; j++)
                {
                    if (j == k && i == 0)
                    {
                        Console.Write(" 0");
                    }
                   else if (j == k)
                    {
                        p = i + p + i;
                        Console.Write(p);
                        k--;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
