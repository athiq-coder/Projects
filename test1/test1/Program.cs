using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;
            Console.WriteLine("Enter a Number: ");
            no = int.Parse(Console.ReadLine());
            int primeNo = 2;

            while (true)
            {
                if (isDivisible(no, primeNo))
                {
                    Console.Write(primeNo+"x");
                    no = no / primeNo;
                } else
                {
                    primeNo = nextPrime(primeNo);
                }

                if (no == 1)
                    break;
            }

        }

        public static int nextPrime(int num)
        {
            int nxtprime = 0;
            num++;

            if (num <= 1)
            {
                return -1;
            }
            num = num % 2 == 0 ? ++num : num;

            while (nxtprime == 0)
            {
                if (isPrime(num))
                {
                    nxtprime = num;
                    break;
                }
                num += 2;
            }

            return nxtprime;

        }

        public static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static bool isDivisible(int no, int primeNo)
        {
            return no % primeNo == 0;
        }
    }
}
