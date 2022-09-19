using System;

namespace primeNumbers_set
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1- Find out all factors
            //int num;
            //showoutput("Enter the number: ");
            //num = getint(Console.ReadLine());
            //if (num > 0)
            //{
            //    Console.Write("1");
            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            Console.Write(","+i);
            //        }
            //    }
            //}else
            //{
            //    Console.Write("-1");
            //    for (int i = -2; i > num; i--)
            //    {
            //        if (num % i == 0)
            //        {
            //            Console.Write(","+i);
            //        }
            //    }
            //}
            //Console.Write("," + num);
            #endregion
            #region Q2-check for prime number
            //int num;
            //showoutput("Enter the number: ");
            //num = getint(Console.ReadLine());
            //if (num > 0)
            //    showoutput(isprime(num) ? num + " is a prime no " : num + " is not a prime no");
            //else
            //    showoutput("Invalid input");
            #endregion
            #region Q3-Print all prime numbers N
            //long num;
            //showoutput("Enter N value: ");
            //num = (long)getint(Console.ReadLine());
            //if (num == 1)
            //    Console.Write("1 ");
            //if (num > 1)
            //{
            //    Console.Write("2 ");
            //    for (long i = 3; i <= num; i = i + 2)
            //    {
            //        if (isprime(i))
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}
            //else
            //{
            //    showoutput("Not a valid input");
            //}
            #endregion
            #region Q4-First N primes
            //int n;
            //showoutput("Enter the number of primes you wanted");
            //n = getint(Console.ReadLine());
            //if (n > 0)
            //{
            //    int i = 2;
            //    while(n!=0)
            //    {
            //        if (isprime(i))
            //        {
            //            Console.Write(i + " ");
            //        }
            //        n--;
            //        i = i % 2 == 0 ? ++i : i += 2;
            //    }
            //}
            //else
            //{
            //    showoutput("Invalid input");
            //}
            #endregion
            #region Q5-Prime numbers less than N
            //int n, count = 0;
            //showoutput("Enter N value: ");
            //n = getint(Console.ReadLine());
            //if (n >= 2)
            //{
            //    for (int i = 2; i <= n; i++)
            //    {
            //        if (isprime(i))
            //        {
            //            count++;
            //        }
            //        i = i % 2 == 0 ? i : ++i;

            //    }
            //    showoutput("The number of prime numbers less than " + n + " is " + count);
            //}else
            //{
            //    showoutput("invalid input");
            //}
            #endregion
            #region Q6-sum of all primes
            //int sum = 0, n,m;
            //showoutput("Enter the number of prime numbers");
            //n = getint(Console.ReadLine());
            //if (n > 0)
            //{ 
            //    sum = 2;
            //    int i = 3;
            //    m = n;
            //    while(m!=0 && m!=1)
            //    {
            //        if (isprime(i))
            //        {
            //            sum += i;
            //        }
            //        m--;
            //        i += 2;
            //    }
            //    showoutput("The sum of " + n + " primes is " + sum);
            //}else
            //{
            //    showoutput("Invalid range");
            //}
            #endregion
            #region Q7-sum of primes less than N
            //int n, sum = 0;
            //showoutput("Enter N value: ");
            //n = getint(Console.ReadLine());
            //if (n > 0)
            //{
            //    for (int i = 2; i < n; i++)
            //    {
            //        if (isprime(i))
            //        {
            //            sum += i;
            //        }
            //        i = i % 2 == 0 ? i : ++i;
            //    }
            //    showoutput("The sum of prime numbers less than " + n + " is " + sum);
            //}else
            //{
            //    showoutput("Invalid input");
            //}
            #endregion
            #region Q8-prime no between M and N
            //int m, n;
            //showoutput("Enter M value: ");
            //m = getint(Console.ReadLine());
            //showoutput("Enter N value: ");
            //n = getint(Console.ReadLine());
            //if (m > 0 && n > m)
            //{
            //    m++;
            //    m = m % 2 == 0 ? ++m : m;
            //    while (m < n)
            //    {
            //        if (isprime(m))
            //        {
            //            Console.Write(m + " ");
            //        }
            //        m += 2;
            //    }
            //}else
            //{
            //    showoutput("Invalid range");
            //}
            #endregion
            #region Q9-prime factors
            //int num;
            //showoutput("Enter the Number to find prime factors: ");
            //num = getint(Console.ReadLine());
            //if(num%2==0)
            //Console.Write("2 ");
            //for (int i = 3; i < num; i+=2)
            //{

            //    if (num % i == 0 && isprime(i))
            //    {
            //        Console.Write(i + " ");
            //    }

            //}
            #endregion
            #region Q10-Prime between M and N
            //int m, n, count = 0,k;
            //showoutput("Enter M value: ");
            //m = getint(Console.ReadLine());
            //showoutput("Enter N value: ");
            //n = getint(Console.ReadLine());
            //k = m;
            //if (m > 0 && n > m)
            //{
            //    m++;
            //    m = m % 2 == 0 ? ++m : m;
            //    for (int i = m; i < n; i+=2)
            //    {
            //        if (isprime(i))
            //        {
            //            count++;
            //        }
            //    }
            //    showoutput("The number of primes between " + k + " and " + n + " is " + count);
            //}else
            //{
            //    showoutput("Invalid range");
            //}
            #endregion
            #region Q11,Q12- Print primes between M and N(m>n) and count
            //int m, n, count = 0;
            //showoutput("Enter M value: ");
            //m = getint(Console.ReadLine());
            //showoutput("Enter N value: ");
            //n = getint(Console.ReadLine());
            //if (n > 0 && n < m)
            //{
            //    n++;

            //    for (int i = n; i < m; i++)
            //    {
            //        if (isprime(i))
            //        {
            //            Console.Write(i + " ");
            //            count++;
            //        }

            //        i = i % 2 == 0 ? i : ++i;
            //    }
            //    Console.WriteLine();
            //    showoutput("The number of primes between " + m + " and " + n + " is " + count);
            //}else
            //{
            //    showoutput("invalid range");
            //}
            #endregion
            #region Q15-Next prime
            //int num;
            //showoutput("Enter a number: ");
            //num = getint(Console.ReadLine());
            //showoutput("The next prime after " + num + " is " + nextprime(num));
            #endregion
            #region Q16-Previous prime
            //int num;
            //showoutput("Enter a number: ");
            //num = getint(Console.ReadLine());
            //showoutput("The previous prime before " + num + " is " + prevprime(num));
            #endregion
            #region Q17-Nearest prime
            //int current,prev,next,nearest;
            //showoutput("Enter the number: ");
            //current = getint(Console.ReadLine());
            //next = nextprime(current);
            //prev = prevprime(current);
            //nearest = (Math.Abs(current - prev)< Math.Abs(current-next))?prev:next;
            //showoutput("The nearest prime from " + current + " is " + nearest);
            #endregion
            #region Q18-Kth prime
            //int num, k,count=1,res;
            //showoutput("Enter the number: ");
            //num = getint(Console.ReadLine());
            //showoutput("Enter the Kth number: ");
            //k = getint(Console.ReadLine());
            //res = nextprime(num);
            //while(count!=k)
            //{
            //    res = nextprime(res);
            //    count++;
            //}

            //showoutput("The " + k + "th Prime number from " + num + " is: " + res);
            #endregion
            #region Q19-check for prime in the given range
            //int m, n;
            //showoutput("Enter M value: ");
            //m = getint(Console.ReadLine());
            //showoutput("Enter N value: ");
            //n = getint(Console.ReadLine());
            //if(m>0 && n>m)
            //{
            //showoutput(isprime(m,n) ? "Prime number exists" : "Prime number doesnt exists");
            //}else
            //{
            //    showoutput("Invalid range");
            //}
            #endregion
            #region Q20-Distinct prime factors
            //int tot_fact = 0, m, n, res_prime = 0;
            //showoutput("Enter the value of M: ");
            //m = getint(Console.ReadLine());
            //showoutput("Enter the value of N: ");
            //n = getint(Console.ReadLine());
            //if (m > 0 && n > m)
            //{
            //    m++;
            //    for (int i = m; i < n; i++)
            //    {
            //        if (tot_fact < primefactor(i))
            //        {
            //            tot_fact = primefactor(i);
            //            res_prime = i;
            //        }
            //    }
            //    showoutput(res_prime + " has more number of distinct prime factors with the count of " + tot_fact);
            //}else
            //{
            //    showoutput("Invalid range");
            //}

            #endregion
            #region Q21-Check if N can be represented as product of two primes

            //int n, j = 0;
            //showoutput("Enter N value");
            //n = getint(Console.ReadLine());
            //bool possible = false;
            //int i = 2;

            //while (!possible && i < n)
            //{
            //    if (n % i == 0 && isprime(i))
            //    {

            //        if (j == 0)
            //        {
            //            j = i;
            //        }

            //        if (i * j == n)
            //        {
            //            possible = true;
            //            break;
            //        }
            //    }

            //    i = i % 2 == 0 ? ++i : i += 2;

            //}

            //showoutput(possible ? "Possible to represent by the product of " + i + "x" + j : "Not possible to represent by distinct factors");

            #endregion
            #region Q22-product of primes distinct factors
            //int n, j = 0;
            //showoutput("Enter N value");
            //n = getint(Console.ReadLine());
            //bool possible = false;
            //int i = 2;

            //while (!possible && i < n)
            //{
            //    if (n % i == 0 && isprime(i))
            //    {

            //        if (j == 0)
            //        {
            //            j = i;
            //        }

            //        if (i * j == n && i!=j)
            //        {
            //            possible = true;
            //            break;
            //        }
            //    }

            //    i = i % 2 == 0 ? ++i : i += 2;

            //}

            //showoutput(possible ? "Possible to represent by the product of " + i + "x" + j : "Not possible to represent by distinct factors");
            #endregion
            #region Q23-Given number represent as product of primes
            int n, quotient = 0, k = 1;
            showoutput("Enter N value");
            n = getint(Console.ReadLine());
            bool ispossible = false;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0 && isprime(i))
                {
                    ispossible = true;
                    quotient = n / i;
                    while (!isprime(quotient))
                    {
                        k = nextprime(k);
                        if (quotient % k == 0 && !isprime(quotient/k))
                        {
                            quotient = quotient / k;
                        }
                        else if(quotient%k==0 && isprime(quotient/k))
                        {
                            Console.Write(quotient / k + "x" + k + "x");
                            
                        }
                    }
                }
                i = i % 2 == 0 ? ++i : i += 2;
            }

            showoutput(!ispossible ? "Not possible as product" : "");
            #endregion
            #region Q24-Largest prime in a given range
            //int m, n, largest = 0;
            //showoutput("Enter the value of M:");
            //m = getint(Console.ReadLine());
            //showoutput("Enter the value of N:");
            //n = getint(Console.ReadLine());
            //if (m > 0 && n > m)
            //{
            //    n--;

            //    n = n % 2 == 0 ? --n : n;

            //    for (int i = n; i > m; i -= 2)
            //    {
            //        if (isprime(i))
            //        {
            //            largest = i;
            //            break;
            //        }
            //    }

            //    showoutput("The largest prime number is " + largest);
            //}else
            //{
            //    showoutput("Invalid range");
            //}
            #endregion
            #region Q25-Smallest prime in a given range
            //int m, n, smallest = 0;
            //showoutput("Enter the value of M:");
            //m = getint(Console.ReadLine());
            //showoutput("Enter the value of N:");
            //n = getint(Console.ReadLine());
            //if (m > 0 && n > m)
            //{
            //      m++;
            //    if (m == 2)
            //    {
            //        smallest = 2;
            //    }
            //    else
            //    {
            //        m = m % 2 == 0 ? ++m : m;
            //        for (int i = m; i < n; i += 2)
            //        {
            //            if (isprime(i))
            //            {
            //                smallest = i;
            //                break;
            //            }
            //        }
            //    }

            //    showoutput("The Smallest prime number is " + smallest);
            //}else
            //{
            //    showoutput("Invalid range ");
            //}
            #endregion

        }
        #region Input-output
        public static void showoutput(string message)
        {
            Console.WriteLine(message);
        }

        public static int getint(string value)
        {
            return int.Parse(value);
        }
        #endregion
        #region check for prime
        public static bool isprime(long num)
        {

            if (num < 0 || num == 0)
            {
                return false;
            }

            for (int i = 2; i * i <= num && num != i; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isprime(int m, int n)
        {
            bool found = false;
            m++;
            m = m % 2 == 0 ? ++m : m;
            while (m < n)
            {
                if (isprime(m))
                {
                    found = !found;
                    break;
                }
                m += 2;
            }
            return found;
        }
        #endregion
        #region Primefactors
        public static int primefactor(int num)
        {
            int count = 0;
            count = num % 2 == 0 ? ++count : count;
            for (int i = 3; i < num; i += 2)
            {
                if (isprime(i) && num % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
        #region NextPrime number
        public static int nextprime(int num)
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
                if (isprime(num))
                {
                    nxtprime = num;
                    break;
                }
                num += 2;
            }

            return nxtprime;

        }
        #endregion

        #region PreviousPrime
        public static int prevprime(int num)
        {
            int prev = 0;
            num--;

            if (num <= 1)
            {
                return -1;
            }

            while (prev == 0)
            {
                if (isprime(num))
                {
                    prev = num;
                    break;
                }
                num = num % 2 == 0 ? --num : num -= 2;
            }

            return prev;
        }
        #endregion
    }
}
