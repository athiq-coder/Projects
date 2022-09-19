using System;
using System.Collections.Generic;

namespace arrays_with_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Check if two arrays are same

            //int[] arr = createArray();

            //readInputs(arr);

            //int[] arr2 = createArray();

            //readInputs(arr2);

            //Dictionary<int, int> unsorted = new Dictionary<int, int>();


            //bool isSame = true;


            //for(int i =0; i < arr.Length; i++)
            //{
            //    unsorted.Add(i, arr[i]);

            //}

            //for(int i=0; i < arr.Length; i++)
            //{
            //    if(!unsorted.ContainsValue(arr2[i]))
            //    {
            //        isSame = false;
            //        break;
            //    }
            //}

            //if(isSame)
            //{
            //    showInConsole("Two arrays are same ");
            //}
            //else
            //{
            //    showInConsole("Two arrays are not same");
            //}

            #endregion

            #region Print distinct elements

            //int[] arr = createArray();

            //readInputs(arr);

            //HashSet<int> distinct = removeDuplicates(arr);

            //foreach (int i in distinct)
            //{
            //    Console.Write(i + " ");
            //}


            #endregion

            #region Duplicates removed array

            //int[] arr = createArray();

            //readInputs(arr);

            //HashSet<int> noDuplicates = removeDuplicates(arr);

            //foreach(int i in noDuplicates)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Subset sum pair with indexes

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the target value: ");

            //int x = getInt(Console.ReadLine());


            //Dictionary<int, int> dist = new Dictionary<int, int>();



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int temp = x - arr[i];

            //    if (dist.ContainsValue(temp))
            //    {
            //        showInConsole("(" + temp + "," + arr[i] + ")");


            //        foreach (KeyValuePair<int, int> iter in dist)
            //        {

            //            if (temp == iter.Value)
            //            {
            //                showInConsole("Index: " + iter.Key+","+i);
            //            }
            //        }
            //    }

            //    dist.Add(i, arr[i]);
            //}

            #endregion

            #region reverse elements using stack

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Array before reversing: ");

            //Display(arr);

            //showInConsole("Array after reversing: ");

            //Reverse(arr);

            //Display(arr);

            #endregion

        }

        #region I/O functions
        public static void showInConsole(string message)
        {
            Console.WriteLine("" + message);
        }

        public static uint getUint(string val)
        {
            return uint.Parse(val);
        }

        public static int getInt(string val)
        {
            return int.Parse(val);
        }
        #endregion

        #region Array Functions

        #region Create

        public static int[] createArray()
        {
            uint n;

            showInConsole("Enter the size of an array: ");
            n = getUint(Console.ReadLine());

            int[] arr = new int[n];

            return arr;

        }

        #endregion

        #region readInputs

        public static void readInputs(int[] arr)
        {
            showInConsole("Enter elements one by one: ");

            for (int i = 0; i < arr.Length; i++)
                arr[i] = getInt(Console.ReadLine());
        }

        #endregion

        #region userInput

        public static int getUserInput(string message)
        {
            showInConsole(message);
            int x = getInt(Console.ReadLine());

            return x;
        }
        #endregion

        #region DisplayArray

        public static void Display<T>(T[] a)
        {
            string index = "";
            Console.Write("The Elements are: ");
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
                index += i + " ";
            }
            Console.Write("\b \b");
            Console.WriteLine("]");
            Console.Write("Index:\t");
            Console.Write("\t   " + index);
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion


        #endregion

        #region Remove duplicates

        public static HashSet<int> removeDuplicates(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();

            for(int i=0; i < arr.Length; i++)
            {
                if(!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }
            }

            return set;
        }

        #endregion

        #region reverse elements - stack

        public static void Reverse(int [] arr)
        {
            Stack<int> stk = new Stack<int>();

            for(int i=0; i < arr.Length; i++)
            {
                stk.Push(arr[i]);
            }


            int k = 0;
            while(stk.Count!=0)
            {
                arr[k++] = stk.Pop(); 
            }

        }

        #endregion

    }
}
