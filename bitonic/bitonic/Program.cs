using System;

namespace bitonic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int even = 0;
            int odd = 1;

            while(even < arr.Length && odd < arr.Length -1)
            {
                int oddIndex = odd;
                int evenIndex = even;

                for (int j = even, k = odd; j < arr.Length && k < arr.Length-1; j += 2,k+=2)
                {
                    if(arr[j] > arr[evenIndex])
                    {
                        evenIndex = j;
                    }

                    if(arr[k] < arr[oddIndex])
                    {
                        oddIndex = k;
                    }
                }
                swap(even, evenIndex, arr);
                swap(odd, oddIndex, arr);
                even += 2;
                odd += 2;
            }

            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }
        }
        public static void swap(int index1,int index2,int[] arr)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}