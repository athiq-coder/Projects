using System;
using System.Collections.Generic;

namespace Array_set2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q36- Check if array contains the required element

            //int[] arr = createArray();

            //readInputs(arr);

            //int x = getUserInput();

            //bool isElementFound = false;

            //for (int i = 0; i < arr.Length; i++)
            //    isElementFound = isTargetValue(arr, i, x);


            //showInConsole(isElementFound ? "Element found " : "Not found ");

            #endregion

            #region Q37- Check if array contains the required element and print the index

            //int[] arr = createArray();

            //readInputs(arr);

            //int x = getUserInput();

            //int indexOfX = -1;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (isTargetValue(arr, i, x))
            //    {
            //        indexOfX = i;
            //        break;
            //    }
            //}

            //showInConsole(indexOfX != -1 ? "Element found at " + indexOfX : "Not found ");

            #endregion

            #region Q38- Check if X is found twice


            //int[] arr = createArray();

            //readInputs(arr);

            //int x = getUserInput();

            //showInConsole(getOccurence(arr, x, 2) != -1 ? "The element " + x + " has found twice " : "Not found twice");

            #endregion

            #region Q39- Check for the second occurence and print index

            //int[] arr = createArray();

            //readInputs(arr);

            //int x = getUserInput();

            //int secondOccur = getOccurence(arr, x , 2);

            //showInConsole(secondOccur != -1 ? "The index of second occurence of target value " + x + " is: " + secondOccur : "Second occurence not found ");

            #endregion

            #region Q40- Get Kth occurence and print index

            //int[] arr = createArray();

            //readInputs(arr);

            //int x = getUserInput();

            //showInConsole("Enter the Kth value: ");

            //uint k = getUint(Console.ReadLine());

            //int kthIndex = getOccurence(arr, x, k);

            //showInConsole(kthIndex != -1 ? "The index of " + k + " occurence of target value " + x + " is: " + kthIndex : "Kth occurence not found ");

            #endregion

            #region Q41- Count occurences

            //int[] arr = createArray();

            //readInputs(arr);

            //int x = getUserInput();

            //showInConsole("The count of x found in array is: "+countOccurences(arr, x));

            #endregion

            #region Q42- Find Indexes of the target value

            //int[] arr = createArray();

            //readInputs(arr);

            //int x = getUserInput();

            //Console.Write("The indexes are: ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int foundindex = getIndexOfX(arr, x, i); // returns -1 if not found

            //    Console.Write(foundindex != -1 ? foundindex : "");
            //}


            #endregion

            #region Q43- Remove occurences of k from array

            //int[] arr = createArray();

            //readInputs(arr);

            //int x = getUserInput();

            //int[] modarr = popKvalues(arr, x);

            //Display(modarr);

            #endregion

            #region Q44- Replace x in the given index

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter target location to replace: ");

            //int Targetlocation = getInt(Console.ReadLine());

            //int Targetelement = getUserInput();

            //int[] modarr = replaceElement(arr,Targetlocation,Targetelement);

            //Display(modarr);

            #endregion

            #region Q45- Remove element from the given location

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the location to remove element: ");

            //int Targetlocation = getInt(Console.ReadLine());

            //int[] modarr = popElement(arr, Targetlocation);

            //Display(modarr);

            #endregion

            #region Q46,Q47,Q48- Find smallest number, number of comparisons, print smallest number index

            //int[] arr = createArray();

            //readInputs(arr);

            //int[] smallest = getSmallest(arr);//0th index->smallestnumber, 1st index-> index of smallest, 2nd index-> comparisons made to find smallest

            //showInConsole("The smallest element is: " + smallest[0]);

            //showInConsole("The index of the smallest element is: " + smallest[1]);

            //showInConsole("The number of comparisons made to find smallest element is: " + smallest[2]);

            #endregion

            #region Q49- Find largest

            //int[] arr = createArray();

            //readInputs(arr);

            //int largest = getLargest(arr);

            //showInConsole("The largest element in the array is: " + largest);

            #endregion

            #region Q50- Find Second Largest

            int[] arr = createArray();

            readInputs(arr);

            showInConsole("The second largest in the array is: " + getSecondLargest(arr));

            #endregion

            #region Q51- Find largest and second largest

            //int[] arr = createArray();

            //readInputs(arr);

            //int largest = getLargest(arr);

            //int Secondlargest = getSecondLargest(arr);

            //showInConsole("The largest and second largest in the array is: " + largest + " , " + Secondlargest);

            #endregion

            #region Q52- Find maximum pair product in array

            //int[] arr = createArray();

            //readInputs(arr);

            //int[] Maxpair = getMaxPair(arr);

            //Display(arr);

            //Console.WriteLine();

            //showInConsole("The pair is: " + "[" + Maxpair[0] + "," + Maxpair[1] + "]");

            //showInConsole("The product of maximum pair is: " + (Maxpair[0] * Maxpair[1]));

            #endregion

            #region Q53- Number of times smallest element occurs

            //int[] arr = createArray();

            //readInputs(arr);

            //int[] smallarr = getSmallest(arr);//smallest element is in 0th index

            //int smallest = smallarr[0];

            //int count = 0;

            //for(int i=0 ; i<arr.Length ; i++)
            //{
            //    if (arr[i] == smallest)
            //        count++;
            //}

            //showInConsole("The number of times smallest element is found: " + count);

            #endregion

            #region Q54- Number of times Largest element occurs

            //int[] arr = createArray();

            //readInputs(arr);

            //int largest = getLargest(arr);

            //int count = 0;

            //for(int i=0 ; i < arr.Length ; i++)
            //{
            //    if (arr[i] == largest)
            //        count++;
            //}

            //showInConsole("The number of times largest element is found: " + count);

            #endregion

            #region Q55- Find missing element in distinct array

            //int[] arr = createArray();

            //readInputs(arr);

            ////approach 1
            //showInConsole("The missing element in the distinct array is: " + missingElement(arr));

            ////approach 2
            //showInConsole("The missing element in the distinct array is: "+ missingElement2(arr));

            #endregion

            #region Q56- Count of elements within range

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("Enter the x range: ");

            //int x = getInt(Console.ReadLine());

            //showInConsole("Enter the Y range: ");

            //int y = getInt(Console.ReadLine());

            //int count = 0;


            ////find count within range

            //for(int i=0; i < arr.Length; i++)
            //{
            //    if (arr[i] < y && arr[i] >= x)
            //        count++;
            //}


            ////store values of range

            //int[] values = new int[count];//create array with the size of the count


            //for(int i=0,j=0; i < arr.Length ;i++)
            //{
            //    if (arr[i] < y && arr[i] >= x)
            //        values[j++] = arr[i];
            //}


            //Display(values);

            //Console.WriteLine();

            //showInConsole("The count of elements lie between "+x+" and "+y+ " is " +count);


            #endregion

            #region Q57- Find unique elements

            //int [] arr = createArray();

            //readInputs(arr);

            //Display(arr);


            ////for any range and any type of values
            //showInConsole("The number of distinct elements are: " + countDistinct(arr));

            ////for 0-9 range only
            //showInConsole("The number of distinct elements are: " + countUnique(arr));


            #endregion

            #region Q58- Find element that occurs most

            //int[] arr = createArray();

            //readInputs(arr);

            //showInConsole("The most occured element is : " + mostOccuredElement(arr));

            #endregion

            #region Q59- Find element that occurs least

            //int[] arr = createArray();

            //readInputs(arr);

            //int[] res = leastOccuredElement(arr);

            //showInConsole("The least occured element is : " + res[0]);

            //showInConsole("The count of least Occured element is : " + res[1]);

            #endregion

            #region Q60- Find missing elements

            //int[] arr = createArray();

            //readInputs(arr);

            //int[] res = getMissing(arr);

            //showInConsole("The missing elements are: ");

            //Display(res);

            #endregion

            #region Q61- Count occurence of every element

            //int[] arr = createArray();

            //readInputs(arr);

            //int[] res = Occurence(arr);

            //showInConsole("The occurence of every element: ");

            //Display(res);

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
        {            return int.Parse(val);
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

            for(int i=0; i<arr.Length; i++)
            arr[i] = getInt(Console.ReadLine());
        }

        #endregion

        #region userInput

        public static int getUserInput()
        {
            showInConsole("Enter the target value: ");
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
        }

        #endregion


        #endregion


        #region check if the target value is there

        public static bool isTargetValue(int[] arr,int i,int x)
        {
            return arr[i] == x;
        }

        #endregion


        #region Count occurences

        public static int countOccurences(int[] arr , int x)
        {
            int count = 0;

            for(int i=0;i<arr.Length;i++)
            {
                if (isTargetValue(arr, i, x))
                    count++;
            }

            return count;
        }
        #endregion


        #region get index of the target x

        public static int getIndex(int[] arr,int x,int i)
        {
            return isTargetValue(arr, i, x) ? i : -1;
        }

        #endregion


        #region get index of any occurence of the target x

        public static int getOccurence(int[] arr, int x, uint occur)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (isTargetValue(arr, i, x))
                    count++;

                if (count == occur)
                    return i;
            }
            return -1;
        }

        #endregion


        #region Remove occurences and return new array

        public static int[] popKvalues(int[] arr , int x)
        {
            int sizeOfNewArr = arr.Length - countOccurences(arr, x);

            int[] arrnew = new int[sizeOfNewArr];

            int j = 0;

            for (int i = 0; i < arr.Length ; i++)
            {
                if (!isTargetValue(arr, i, x))
                    arrnew[j++] = arr[i];
            }

            return arrnew;
        }
        #endregion


        #region Replace Element in the given location
        public static int[] replaceElement(int[] arr , int location , int element)
        {
            int[] modarr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
                modarr[i] = arr[i];

            modarr[location] = element;

            return modarr;
        }
        #endregion


        #region Remove element from the given location

        public static int[] popElement(int[] arr,int location)
        {
            int[] modarr = new int[arr.Length - 1];

            int j = 0;

            for(int i=0 ; i<arr.Length ; i++)
            {
                if (i != location)
                    modarr[j++] = arr[i]; 
            }
            return modarr;
        }
        #endregion


        #region get Smallest element in the array

        public static int getSmallestElement(int[] arr)
        {
            int[] temp = getSmallest(arr);

            return temp[0];
        }
        #endregion


        #region get Second smallest element in the array

        public static int getSecondsmallest(int[] arr)
        {
            int smallest = getSmallestElement(arr);

            int sec_smallest = int.MaxValue;

            for(int i=0; i < arr.Length; i++)
            {
               if(sec_smallest < arr[i] && arr[i] != smallest)
                {
                    sec_smallest = arr[i];
                }
            }
            return sec_smallest;
        }

        #endregion


        #region Smallest element in the array, smallest index, comparisons
        public static int[] getSmallest(int[] arr)
        {
            int[] smallestArr = new int[3];

            smallestArr[0] = arr[0];

            smallestArr[2] = 0;

            for(int i=0; i<arr.Length; i++)
            {
                if (smallestArr[0] > arr[i])
                {
                    smallestArr[0] = arr[i];
                    smallestArr[1] = i;
                    smallestArr[2] = smallestArr[2] + 1;
                }
            }

            return smallestArr;
        }

        #endregion


        #region getLargest element from array
        public static int getLargest(int []arr)
        {


            int largest = arr[0];

            for(int i=0; i < arr.Length; i++)
            {
                if (largest < arr[i])
                    largest = arr[i];
            }

            return largest;
        }
        #endregion


        #region getSecondLargest element from array

        public static int getSecondLargest(int[] arr)
        {
            int largest = getLargest(arr);

            int secondLargest = int.MinValue;

            for(int i=0; i<arr.Length; i++)
            {
                if(secondLargest < arr[i] && arr[i]!=largest)
                {
                    secondLargest = arr[i];
                }
            }
            return secondLargest;
        }
        #endregion


        #region Maximum pairwise product

        public static int[] getMaxPair(int[]arr)
        {
            int[] maxPair = new int[2];

            int prod = arr[0] * arr[1];

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (prod < arr[i] * arr[j])
                    {
                        prod = arr[i] * arr[j];
                        maxPair[0] = arr[i];
                        maxPair[1] = arr[j];
                    }
                }
            }

            return maxPair;
        }

        #endregion


        #region Find missing element
        public static int missingElement(int[] arr)
        {
            int i = 1;

            int missingElement = -1;

            int n = getLargest(arr);

            while(i < n)
            {
                bool flag = false;

                for(int j=0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                    {
                        i++;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    missingElement = i;
                    break;
                }
            }

            return missingElement;
        }
        #endregion


        #region Find missing element- approach 2
        public static int missingElement2(int[] arr)
        {
            int n = getLargest(arr);

            int sumOfN = (n * (n + 1)) / 2;

            int sum = 0;


            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
            }

            int res = sumOfN - sum;

            return res;
        }
        #endregion


        #region Find unique elements for any range(brute force)

        public static int countDistinct(int[]arr)
        {
            int count = 0;

            bool flag;

            for(int i=0; i<arr.Length;i++)
            {
                flag = true;

                for(int j=i+1; j<arr.Length && j!=i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        flag = false;
                        break;
                    }

                    if (j + 1 == arr.Length)//set j to -1 to check indexes from beginning to i-1
                        j = -1;
                    
                }

                if(i==arr.Length - 1)//Loop to check n-1 element already exists or not
                {
                    for(int j=0; j<i; j++)
                    {
                        if(arr[j] == arr[i-1])
                        {
                            flag = false;
                            break;
                        }
                    }
                }

                if (flag)
                    count++;
            }

            return count;
        }

        #endregion


        #region Find unique elements for 0-9 (using array)

        public static int countUnique(int[] arr)
        {
            int[] flag = new int[10];

            int count = 0;

            for(int i=0;i<arr.Length;i++)
            {
                flag[arr[i]] = flag[arr[i]] + 1;
            }

            for(int i=0;i<flag.Length;i++)
            {
                if (flag[i] == 1)
                    count++;
            }

            return count;
        }

        #endregion


        #region Find element that occurs most (any range)

        public static int mostOccuredElement(int[] arr)
        {
            int count = 0,prevCount = 0;

            int mostOccured = arr[0];


            for(int i=0; i < arr.Length; i++)
            {
                count = 0;
                
                for(int j=0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        count++;
                }

                if (prevCount < count)
                {
                    mostOccured = arr[i];
                    prevCount = count;
                }

            }

           

            return mostOccured;
        }

        #endregion


        #region Find element that occurs the least (any range)

        public static int[] leastOccuredElement(int[] arr)
        {
            int count = 0, prevCount = 0;

            int leastOccured = arr[0];


            for (int i = 0; i < arr.Length; i++)
            {
                prevCount = prevCount == 0 ? count : prevCount;

                count = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        count++;
                }

                if (prevCount > count)
                {
                    leastOccured = arr[i];
                    prevCount = count;
                }
            }

            int[] res = new int[2];

            res[0] = leastOccured;

            res[1] = count;

            return res;
        }
        #endregion


        #region Find missing elements 0-9 range
        public static int[] getMissing(int[] arr)
        {
            bool[] isfound = new bool[10];

            int count = 0;

            for(int i=0; i < arr.Length; i++)
            {
                if (isfound[arr[i]] == false)
                {
                    isfound[i] = true;
                    count++;
                }
            }

            int[] missingElements = new int[count];

            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!isfound[i])
                    missingElements[j++] = i;
            }  



            return missingElements;
        }
        #endregion


        #region Find occurence of every element
        public static int[] Occurence(int[] arr)
        {
            int[] count = new int[10];

            for (int i = 0; i < 10; i++)
                count[i] = countOccurences(arr, i);

            return count;
        }
        #endregion
    }
}
