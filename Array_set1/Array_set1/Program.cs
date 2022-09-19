using System;
using System.Collections.Generic;

namespace Array_set1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1-Create array with size 'n' and initialize with 'K'
            //int n, k;
            //int[] arr;

            //showInConsole("Enter the size of an array: ");
            //n = getInt(Console.ReadLine());

            //showInConsole("Enter the K value: ");
            //k = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative ");
            //else
            //{
            //    arr = CreateArray(n);

            //    for (int i = 0; i < n; i++)
            //        arr[i] = k;



            //    Display(arr);
            //}
            #endregion
            #region Q2- Create and get inputs from user
            //int[] arr;
            //int n;

            //showInConsole("Enter the Value of N: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");
            //else
            //{
            //    arr = CreateArray(n);
            //    showInConsole("Enter the elements: ");
            //    for(int i=0;i<n;i++)
            //        readInputs(arr,i);

            //    Display(arr);
            //}
            #endregion
            #region Q3- create and fill with random values in the range
            //int n, i, j;
            //int[] arr;
            //showInConsole("Enter the Value of N: ");
            //n = getInt(Console.ReadLine());

            //showInConsole("Enter the Range of I ");
            //i = getInt(Console.ReadLine());

            //showInConsole("Enter the Value of J: ");
            //j = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or Negative");
            //else
            //{
            //    arr = CreateArray(n);


            //    if (i > 0 && j <= n && j!=i)
            //    {
            //        while (i < j)
            //            arr[i] = GenerateNumber(i++, j);
            //    }
            //    else
            //        showInConsole("Range cannot be Negative");

            //    Display(arr);
            //}
            #endregion
            #region Q4-Min and max and random numbers in it
            //int[] arr;
            //int i, j;

            //int n = GenerateNumber(1, int.MaxValue-1);

            //arr = new int[n];

            //showInConsole("Enter the range of I between 1 and "+n);
            //i = getInt(Console.ReadLine());

            //showInConsole("Enter the range of J between "+i+" and "+n);
            //j = getInt(Console.ReadLine());


            //if (i < j )
            //{
            //    for (int k = i; k < j; k++)
            //    {
            //        int getRandom = GenerateNumber(k, j);

            //        arr[k] = getRandom;
            //    }

            //    Printwithin(arr, i, j);
            //}
            //else
            //    displayErrorMessage("The given range is Invalid");

            #endregion
            #region Q5,Q6,Q7,Q8 Print in straight and reverse, print odd position, even position

            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("Array cannot be created with this value ");

            //else
            //{
            //    int[] arr = CreateArray(n);

            //    showInConsole("Enter the elements one by one: ");

            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    //normal traversal
            //    Display(arr);

            //    Console.WriteLine();

            //    //reverse print
            //    showInConsole("The reverse version is: ");
            //    for (int i = n - 1; i >= 0; i--)
            //        Console.Write(arr[i] + " ");


            //    Console.WriteLine();

            //    //odd position printing

            //    showInConsole("Elements in odd position: ");
            //    for (int i = 1; i < n; i += 2)
            //        Console.Write(arr[i] + " ");

            //    Console.WriteLine();

            //    //even position printing

            //    showInConsole("Elements in even position: ");
            //    for (int i = 0; i < n; i += 2)
            //        Console.Write(arr[i] + " ");
            //}
            #endregion
            #region Q9,Q10-Print the elements upto K, K to end array.
            //int n, k;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //showInConsole("Enter the K value: ");
            //k = getInt(Console.ReadLine());

            //if (n < 0)
            //    displayErrorMessage("Invalid size of an array");

            //else
            //{
            //    int[] arr = CreateArray(n);

            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);


            //    if (k > n)
            //        displayErrorMessage("Not possible to print");
            //    else
            //    {

            //        //Print upto K
            //        showInConsole("Elements upto k is: ");
            //        for (int i = 0; i <= k; i++)
            //            Console.Write(arr[i] + " ");

            //        Console.WriteLine();

            //        //Print from K to end
            //        showInConsole("Elements from k to n is: ");
            //        for (int i = k; i < n; i++)
            //            Console.Write(arr[i] + " ");

            //        Console.WriteLine();

            //    }
            //}

            #endregion
            #region Q11,Q12,Q13,Q14,Q15,Q16,Q17 - Alternate locations , Key:value , Subtract index 0, sum of odd and even positions, check for sum of odd and even is equal or not

            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n < 0)
            //    displayErrorMessage("Invalid size of an array");
            //else
            //{

            //    int[] arr = CreateArray(n);

            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    //Elements in Alternate locations
            //    showInConsole("Elements in alternate locations: ");
            //    for (int i = k; i < n; i += 2)
            //        Console.Write(arr[i] + " ");

            //    Console.WriteLine();

            //    //Print with index and value
            //    showInConsole("Elements with index and value: ");
            //    Display(arr);

            //    Console.WriteLine();

            //    //subtract index[0] from all the elements
            //    int element = arr[0];

            //    for (int i = 0; i < n; i++)
            //        arr[i] = arr[i] - element;

            //    Display(arr);

            //    //sum of all elements in even position
            //    showInConsole("Sum of even positions is: " + sumofEven(arr, n));

            //    //sum of all elements in odd position
            //    showInConsole("Sum of odd positions is: " + sumofOdd(arr, n));

            //    //check if even position sum and odd position sum is equal or not
            //    showInConsole(sumofOdd(arr, n) == sumofEven(arr, n) ? "Both the sums are equal " : "Not equal");

            //}
            #endregion
            #region Q18,Q19,Q20,Q21,Q22,Q23,Q24- Mean , count non zero, positive, negative, check positive and negative elements are equal, mean without 0, subtract mean
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    bool withzero = true;


            //    //mean with zero
            //    showInConsole("The mean with adding zero is : " + getMean(arr, n, withzero));

            //    //mean without zero
            //    showInConsole("The mean without adding zero is : " + getMean(arr, n, !withzero));

            //    //count of Nonzero
            //    showInConsole("The count of Non zero elements is :" + countOfNonZero(arr, n));

            //    //count of Positive 
            //    showInConsole("The count of Positive elements is :" + countOfPostive(arr, n));

            //    //count of Negative
            //    showInConsole("The count of Negative elements is :" + countOfNegative(arr, n));

            //    //check if count of positive is equal to negative
            //    showInConsole(countOfPostive(arr, n) == countOfNegative(arr, n) ? "The count of positive and negative elements are Equal " : "The count of positive and negative elements are Not equal ");

            //    Console.WriteLine();
            //    //subtract mean and display
            //    int mean = getMean(arr, n, withzero);


            //    showInConsole("The mean is: " + mean);

            //    showInConsole("Array before Subtracting mean ");
            //    Display(arr);

            //    for (int i = 0; i < n; i++)
            //        arr[i] = arr[i] - mean;
            //    Console.WriteLine();

            //    showInConsole("Array after Subtracting mean ");

            //    Display(arr);


            //}

            #endregion
            #region Q25,Q26,Q27 -number of odd,even , perfectsquare, prime
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    //number of odd and even
            //    showInConsole("The Count of odd numbers: " + countOfOdd(arr, n));
            //    showInConsole("The Count of even numbers: " + countOfEven(arr, n));

            //    //number of perfect square
            //    showInConsole("The number of perfect square in it is: " + countOfPerfectsquares(arr, n));

            //    //number of primes
            //    showInConsole("The number of primes in it is: " + countOfPrimes(arr, n));


            //}

            #endregion
            #region Q28-return copy of array
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    showInConsole("The elements of array 1 : ");
            //    Display(arr);
            //    Console.WriteLine();

            //    Console.WriteLine();

            //    //assign copy
            //    int[] arr2 = getCopy(arr);
            //    showInConsole("The elements of array 2 : ");
            //    Display(arr2);
            //}

            #endregion
            #region Q29- Odd numbers and even numbers only
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    showInConsole("Original array: ");
            //    Display(arr);
            //    Console.WriteLine();

            //    Console.WriteLine();

            //    //odd numbers enclosed array
            //    int[] oddArr = getOddElements(arr,n);
            //    showInConsole("The Odd elements are: ");
            //    Display(oddArr);

            //    Console.WriteLine();
            //    Console.WriteLine();

            //    //Even numbers enclosed array
            //    int[] evenArr = getEvenElements(arr, n);
            //    showInConsole("The Even elements are: ");
            //    Display(evenArr);
            //}
            #endregion
            #region Q30-Array containing perfectsquares only
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    showInConsole("Original array: ");
            //    Display(arr);

            //    Console.WriteLine();
            //    Console.WriteLine();

            //    //Perfect square enclosed array

            //    int[] squares = getPerfectSquare(arr, n);

            //    showInConsole("Perfect square array: ");

            //    Display(squares);

            //}
            #endregion
            #region Q31- Array containing PrimeNumbers only
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    showInConsole("Original array: ");
            //    Display(arr);

            //    Console.WriteLine();
            //    Console.WriteLine();

            //    //Prime numbers enclosed array

            //    int[] primes = getPrimeNumbers(arr, n);

            //    showInConsole("Prime numbers array: ");

            //    Display(primes);

            //}
            #endregion
            #region Q32,Q33- Boolean array for even positions, odd positions
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    showInConsole("Original array: ");
            //    Display(arr);

            //    Console.WriteLine();
            //    Console.WriteLine();

            //    //Boolean array for even numbers

            //    bool[] evenArr = evenBoolArray(arr,n);

            //    showInConsole("Bool even array: ");

            //    Display(evenArr);

            //    Console.WriteLine();
            //    //Boolean array for odd numbers

            //    bool[] oddArr = oddBoolArray(arr,n);

            //    showInConsole("Bool odd array: ");

            //    Display(oddArr);
            //}
            #endregion
            #region Q34- Boolean array for Primenumber
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else if (n > 100000)
            //    displayErrorMessage("Range cannot go beyond 100000");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    showInConsole("Original array: ");
            //    Display(arr);

            //    Console.WriteLine();
            //    Console.WriteLine();

            //    //Bool Prime array

            //    bool[] primeArr = primeBoolArray(arr, n);

            //    showInConsole("Bool prime array: ");

            //    Display(primeArr);

            //}
            #endregion
            #region Q35- Boolean array for perfectSquare
            //int n;

            //showInConsole("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //if (n <= 0)
            //    displayErrorMessage("N cannot be zero or negative");

            //else if (n > 100000)
            //    displayErrorMessage("Range cannot go beyond 100000");

            //else
            //{
            //    int[] arr = CreateArray(n);


            //    //input
            //    showInConsole("Enter the elements one by one ");
            //    for (int i = 0; i < n; i++)
            //        readInputs(arr, i);

            //    showInConsole("Original array: ");
            //    Display(arr);

            //    Console.WriteLine();
            //    Console.WriteLine();

            //    //Bool PerfectSquare array

            //    bool[] squares = perfectSquareBoolArray(arr, n);

            //    showInConsole("Bool PerfectSquare array: ");

            //    Display(squares);

            //}
            #endregion
        }


        // I/O functions

        #region Input-Output
        public static void showInConsole(string message)
        {
            Console.WriteLine(message);
        }


        public static int getInt(string val)
        {
           return int.Parse(val);
        }

        public static void readInputs(int []arr,int index)
        {
                arr[index] = getInt(Console.ReadLine());
        }
        #endregion


        //Generate random number

        #region randomNumber
        public static int GenerateNumber(int i,int j)
        {
            Random r = new Random();

            return r.Next(i,j+1);
        }
        #endregion

        //Error handling

        #region Exception
        public static void displayErrorMessage(string message)
        {
            Console.WriteLine(message);
        }
        #endregion


        //Array creation, print, copy

        #region CreateArray
        public static int[] CreateArray(int n)
        {
                
                int[] a = new int[n];
                return a;
            
        }
        #endregion

        #region PrintArray
        public static void Display <T> (T[] a)
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
        }

        public static void Printwithin(int[] arr, int i, int j)
        {
            string index = "";
            Console.Write("The Elements are: ");
            Console.Write("[");
            for (int k = i; k < j; k++)
            {
                Console.Write(arr[k] + ",");
                index += k + " ";
            }
            Console.Write("\b \b");
            Console.WriteLine("]");
            Console.Write("Index:\t");
            Console.Write("\t   " + index);
        }
        #endregion

        #region getcopy
        public static int[] getCopy(int[] arr)
        {
            return arr;
        }
        #endregion

        //Boolean logics

        #region checkForOdd
        public static bool isOdd(int num)
        {
            return num % 2 != 0;
        }
        #endregion

        #region checkForEven
        public static bool isEven(int num)
        {
            return num % 2 == 0;
        }
        #endregion

        #region checkforPerfectsquare
        public static bool isperfectSquare(int num)
        {

            if (num == 4)
                return true;


            int diff = 5;

            for(int i = 9; i<=num; i+=diff )
            {
                if (i == num)
                    return true;

                diff += 2;
            }
            return false;
        }

        #endregion

        #region checkForprime
        public static bool isPrime(int num)
        {
            if (num < 1)
                return false;

            for(int i=2; i*i<=num && i>0 ; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
        #endregion

        #region CheckforEven - boolean array
        public static bool[] evenBoolArray(int[] arr,int n)
        {
            bool[] even = new bool[n];

            for(int i=0;i<n;i++)
            {
                if (isEven(arr[i]))
                    even[i] = true;
            }

            return even;
        }

        #endregion

        #region CheckforOdd - boolean array
        public static bool[] oddBoolArray(int[] arr, int n)
        {
            bool[] odd = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (isOdd(arr[i]))
                    odd[i] = true;
            }

            return odd;
        }

        #endregion

        #region CheckforPrime - boolean array
        public static bool[] primeBoolArray(int[] arr, int n)
        {
            bool[] prime = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (isPrime(arr[i]))
                    prime[i] = true;
            }

            return prime;
        }

        #endregion

        #region CheckforPerfectSquare - boolean array
        public static bool[] perfectSquareBoolArray(int[] arr, int n)
        {
            bool[] squares = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (isperfectSquare(arr[i]))
                    squares[i] = true;
            }

            return squares;
        }

        #endregion

        #region PerfectSquare array
        public static int[] getPerfectSquare(int[] arr, int n)
        {
            int count = countOfPerfectsquares(arr, n);

            int[] squares = CreateArray(count);

            int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (isperfectSquare(arr[i]))
                    squares[j++] = arr[i];
            }
            return squares;
        }
        #endregion

        #region PrimeNumbers array
        public static int[] getPrimeNumbers(int[] arr, int n)
        {
            int count = countOfPrimes(arr, n);

            int[] primes = CreateArray(count);

            int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (isPrime(arr[i]))
                    primes[j++] = arr[i];
            }
            return primes;
        }
        #endregion


        //Common Logics

        #region count
        public static int countOfNonZero(int[]arr,int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
                count = arr[i] != 0 ? ++count : count;



            return count;
        }

        public static int countOfPostive(int[] arr, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
                count = arr[i] >= 0 ? ++count : count;



            return count;
        }

        public static int countOfNegative(int[] arr, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
                count = arr[i] < 0 ? ++count : count;



            return count;
        }

        public static int countOfOdd(int [] arr,int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
                count = arr[i]%2!=0 ? ++count : count;

            return count;
        }

        public static int countOfEven(int[] arr, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
                count = arr[i] % 2 == 0 ? ++count : count;


            return count;
        }

        public static int countOfPerfectsquares(int[]arr , int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (isperfectSquare(arr[i]))
                    count++;
            }
                

            return count;
        }

        public static int countOfPrimes(int[] arr, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (isPrime(arr[i]))
                    count++;
            }


            return count;
        }


        #endregion
        
        #region getmean
        public static int getMean(int[] arr, int n, bool withzero)
        {

            int sum = 0;
            int count = 0;

            if (withzero)
            {
                for (int i = 0; i < n; i++)
                {
                    sum += arr[i];
                    count++;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] != 0)
                    {
                        sum += arr[i];
                        count++;
                    }
                }
            }

            return sum / count;
        }



        #endregion

        #region sumOfArray
        public static int sumofEven(int []arr,int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i += 2)
                sum += arr[i];

            return sum;
        }

        public static int sumofOdd(int []arr,int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i+=2)
                sum += arr[i];

            return sum;
        }

        #endregion

        #region Oddarray
        public static int[] getOddElements(int[] arr,int n)
        {

            int count;

            count = countOfOdd(arr, n);

            int[] odd = CreateArray(count);
            int j = 0;

            for(int i=0;i<n;i++)
            {
                if (arr[i] % 2 != 0)
                    odd[j++] = arr[i];
               
            }
            return odd;
        }
        #endregion

        #region Evenarray
        public static int[] getEvenElements(int[] arr, int n)
        {

            int count;

            count = countOfEven(arr, n);

            int[] even = CreateArray(count);
            int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                    even[j++] = arr[i];
            }
            return even;
        }
        #endregion
    }
}
