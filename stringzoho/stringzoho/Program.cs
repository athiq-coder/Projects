using System;

namespace stringzoho
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "testing12";
            string find = "1234";
            int resultIndex=0;
            int j=0;

           for(int i=0; i < input.Length && j < find.Length; i++)
            {
                if(input[i] == find[0])
                {
                    resultIndex = i;
                    j++;
                }

                if(input[i] == find[j])
                {
                    j++;
                }
            }

           if(j == find.Length)
            {
                Console.WriteLine(resultIndex);
            }
           else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
