using System;

namespace array_set3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comparisons and swaps

            #region Q62- swap two elements with index

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the first index: ");

            //uint x = getUint(Console.ReadLine());

            //showInConsole("Enter the Second index: ");

            //uint y = getUint(Console.ReadLine());

            //showInConsole("The Contents of array before swapping: ");

            //Display(arr);

            //showInConsole("The Contents of array after swapping: ");

            //Swap(arr, x, y);

            //Display(arr);

            #endregion


            #region Q63- Check if array is in ascending order

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole(checkAscending(arr));


            #endregion


            #region Q64- Check if two arrays are same

            //int[] arr1 = createArray();

            //readInputs(arr1);

            //int[] arr2 = createArray();

            //readInputs(arr2);

            //showInConsole(isIdentical(arr1, arr2));

            #endregion


            #region Q65,Q66- Reversed array

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("The original array is: ");

            //Display(arr);

            //showInConsole("The reversed array is: ");

            //reverseArray(arr);

            //Display(arr);

            #endregion


            #region Q67- return index upto which they are identical

            //int[] arr1 = createArray();

            //readInputs(arr1);

            //int[] arr2 = createArray();

            //readInputs(arr2);

            //int[] index = getIdenticalIndex(arr1, arr2);

            //int start = index[0];

            //int end = index[1];

            //showInConsole("The index from which they are identical is: "+start+" to "+(end-1));

            //showInConsole("The identical elements are: ");

            //for(int i = start; i < end ; i++)
            //{
            //    Console.Write(arr1[i] + ",");
            //}
            //Console.Write("\b \b");
            #endregion


            #region Q68- Print distinct elements

            //int[] arr = createArray();

            //readInputs(arr);



            //Bubblesort(arr);


            //Display(arr);

            //Console.Write("The distinct elements are: ");

            //int i;

            //for (i = 0; i < arr.Length-1; i++)
            //{
            //    if (arr[i] != arr[i + 1])
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //}
            //Console.Write(arr[i] + " ");


            #endregion


            #region Q69- Array without duplicates

            //int[] arr = createArray();

            //readInputs(arr);

            //int j = 0;

            //Bubblesort(arr);

            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    if (arr[i] != arr[i + 1])
            //    {
            //        arr[j++] = arr[i];
            //    }
            //}
            //arr[j] = arr[arr.Length - 1];//include last element 


            //showInConsole("The array without duplicates are: ");

            ////display

            //for (int i = 0; i <= j; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}


            #endregion


            #region Q70- Kth largest/smallest

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the K value: ");

            //uint k = getUint(Console.ReadLine());

            //int kthLargest = arr[Klargest(arr, k)];

            //int kthSmallest = arr[Ksmallest(arr,k)];

            //showInConsole("The " + k + " largest element is: " + kthLargest);

            //showInConsole("The " + k + " smallest element is: " + kthSmallest);


            #endregion


            #region Q71- Count of values less than x

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the x value: ");

            //int x = getInt(Console.ReadLine());

            //int count = 0;

            //for(int i=0; i<arr.Length; i++)
            //{
            //    if(arr[i] <= x)
            //    {
            //        count++;
            //    }
            //}

            //showInConsole("The count of values less than " + x + " is " + count);

            #endregion


            #region Q72- Count of values greater than x

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the x value: ");

            //int x = getInt(Console.ReadLine());

            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] >= x)
            //    {
            //        count++;
            //    }
            //}

            //showInConsole("The count of values greater than " + x + " is " + count);

            #endregion



            //Rotation

            #region Q73,Q75,Q76,Q77- Rotate array by right by k position

            //approach

            //1. Partition the array into two halves
            //2. reverse the elements till (array length - k)
            //3. reverse the elements from k to array length
            //4. Reverse total array.

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the K value: ");

            //int k = getInt(Console.ReadLine());

            //if(k > arr.Length)
            //{
            //    k %= arr.Length;
            //}

            //if(k < 0)
            //{
            //    k %= arr.Length;
            //    k += arr.Length;
            //}

            //Reverse(arr, 0, arr.Length - k);

            //Reverse(arr, arr.Length - k, arr.Length);

            //Reverse(arr,0,arr.Length);

            //Display(arr);

            #endregion


            #region Q74,Q76,Q77- Rotate array by left by k position

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the K value: ");

            //int k = getInt(Console.ReadLine());

            //if (k > arr.Length)
            //{
            //    k %= arr.Length;
            //}

            //if (k < 0)
            //{
            //    k %= arr.Length;
            //    k += arr.Length;
            //}

            //Reverse(arr, k, arr.Length);

            //Reverse(arr, 0, k);

            //Reverse(arr, 0, arr.Length);

            //Display(arr);

            #endregion


            #region Q79,Q81 - Index after rotation by left

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the K value: ");

            //int k = getInt(Console.ReadLine());

            //showInConsole("Enter the Index value: ");

            //uint index = getUint(Console.ReadLine());

            //if (k > arr.Length)
            //{
            //    k %= arr.Length;
            //}

            //if (k < 0)
            //{
            //    k %= arr.Length;
            //    k += arr.Length;
            //}

            //Reverse(arr, k, arr.Length);

            //Reverse(arr, 0, k);

            //Reverse(arr, 0, arr.Length);

            //showInConsole("The value at index " + index + " is " + arr[index]);


            #endregion


            #region Q78,Q80 - Index after rotation by right

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the K value: ");

            //int k = getInt(Console.ReadLine());

            //showInConsole("Enter the Index value: ");

            //uint index = getUint(Console.ReadLine());

            //if (k > arr.Length)
            //{
            //    k %= arr.Length;
            //}

            //if (k < 0)
            //{
            //    k %= arr.Length;
            //    k += arr.Length;
            //}

            //Reverse(arr, 0, arr.Length - k);

            //Reverse(arr, arr.Length - k, arr.Length);

            //Reverse(arr, 0, arr.Length);

            //showInConsole("The value at index " + index + " is " + arr[index]);

            #endregion



            //Subset

            #region Q82- Check for subset

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the sum: ");

            //int sum = getInt(Console.ReadLine());

            //showInConsole(isSubsetThere(arr,sum));

            #endregion


            #region Q83,Q84- Print indexes and pairs

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the sum: ");

            //int sum = getInt(Console.ReadLine());

            //showInConsole(getSubsetPair(arr, sum));


            #endregion


            #region Q85- Pair closest to X

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the sum: ");

            //int x = getInt(Console.ReadLine());

            //showInConsole(getClosestPair(arr,x));

            #endregion


        }

        //Business Logics

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


        #region Check if array elements are in ascending order

        public static string checkAscending(int[] arr)
        {
            for(int i=1; i < arr.Length; i++)
            {
                int last_element = arr[i-1];

                if (arr[i] < last_element)
                {
                    return "Not ascending ";
                }

            }
            return "Ascending ";
        }
        #endregion


        #region Check if two arrays are same

        public static string isIdentical(int[] arr1, int[] arr2)
        {

            if(arr1.Length != arr2.Length)
            {
                return "Invalid size of array ";
            }

            for(int i=0; i<arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    return "Not same";
                }
            }
            return "Same";
        }
        #endregion


        #region swap two elements in an array(given indices)

        public static void Swap(int[]arr, uint index1 , uint index2)
        {
            Swap(ref arr[index1-1], ref arr[index2-1]);
        }

        #endregion


        #region swap two elements

        public static void Swap(ref int val1 , ref int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }

        #endregion


        #region Reverse array

        public static int[] reverseArray(int[] arr)
        {
            int length = arr.Length;

            int[] temp = new int[length];

            int j = length-1;

            for(int i=0 ; i < j; i++)
            {
                Swap(ref arr[i], ref arr[j--]);
            }

            return temp;
        }

        #endregion


        #region Sort
        public static void Bubblesort(int[] arr)
        {
            for(int i=0; i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        #endregion


        #region Kth-largest

        public static int Klargest(int[] arr, uint k)
        {


            if (k == 0 || k > arr.Length)
            {
                return -1;
            }

            int largest = 0;

            int l = 0;

            for(int i=0; i < k; i++)
            {
                largest = i;

                for(int j=i+1; j < arr.Length; j++)
                {
                    if(arr[j] > arr[largest] && j != largest)
                    {
                        largest = j;
                    }
                }
                Swap(ref arr[l++], ref arr[largest]);
            }

            return largest;

        }

        #endregion


        #region Kth-Smallest

        public static int Ksmallest(int[] arr, uint k)
        {


            if (k == 0 || k > arr.Length)
            {
                return -1;
            }

            int smallest = 0;

            int l = 0;

            for (int i = 0; i < k; i++)
            {
                smallest = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest] && j != smallest)
                    {
                        smallest = j;
                    }
                }
                Swap(ref arr[l++], ref arr[smallest]);
            }

            return smallest;

        }

        #endregion


        #region Reverse Elements (given index)

        public static void Reverse(int[]arr,int index,int n)
        {
            int j = n - 1;

            for(int i=index; i<j ;i++)
            {
                Swap(ref arr[i], ref arr[j--]);
            }

        }

        #endregion


        #region return index of the elements that are identical

        #region getStartIndex

        public static int getStartIndex(int[] arr1, int[] arr2)
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2[i] == arr1[i])
                    return i;
            }
            return -1;
        }

        #endregion


        public static int[] getIdenticalIndex(int[] arr1, int[] arr2)
        {

            int[] startToEnd = new int[2];

            int i = getStartIndex(arr1, arr2);

            startToEnd[0] = i;

            for(int j = i; j < arr1.Length; j++)
            {
                if(arr1[j] != arr2[j])
                {
                    startToEnd[1] = j;
                    break;
                }
            }

            return startToEnd;
        }

        #endregion


        #region checkForSubset

        public static string isSubsetThere(int[] arr,int sum)
        {


            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == sum)
                    {
                        return "Subset exists ";
                    }
                }
            }
            return "Subset doesn't exists ";
        }

        #endregion


        #region get pairs of subset

        public static string getSubsetPair(int[] arr, int sum)
        {


            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        return "The pairs of subset is: "+"["+arr[i]+","+arr[j]+"]"+" "+","+"The indexes are: "+i+" "+j;
                    }
                }
            }
            return "-1 ";
        }

        #endregion


        #region get pairs closest to X

        public static string getClosestPair(int[]arr,int x)
        {
            int temp = x;

            while(temp > int.MinValue)
            {
                temp--;
                for (int i=0;i<arr.Length-1;i++)
                {
                    for(int j=i+1;j<arr.Length;j++)
                    {
                        if(arr[i]+arr[j] == temp)
                        {
                            return "The Closest pair is: " + "[" + arr[i] + "," + arr[j] + "]";
                        }
                    }
                }
            }
            return "Not found ";
        }

        #endregion
    }
}
