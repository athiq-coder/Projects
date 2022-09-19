using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "12345";

            for(int i=0; i < num.Length; i++)
            {
                int k = num.Length - 1 - i;
                for (int j=0; j < num.Length; j++)
                {
                   if(j==i || j==k)
                    {
                        Console.Write(num[j]);
                    }else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
