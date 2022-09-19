using System;

namespace Numbers_new
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1,Q3-Maximum number that divides given digits
            //int num, max, temp;
            //bool isfound = false;

            //showoutput("Enter the Value: ");
            //num = getInt(Console.ReadLine());
            //temp = num;

            //max = getMinimumDigit(num);

            //if (max == 1)
            //    isfound = true;

            //if (min > 0 && !isfound)
            //{
            //    while (temp != 0)
            //    {
            //        isfound = isdivisible(getlastDigit(num), max);

            //        if (!isfound)
            //            break;

            //        temp /= 10;
            //    }
            //}

            //showoutput(isfound ? "Maximum Digit that divides the given number " + num + " is : " + min : "Not possible to divide");


            #endregion
            #region Q2-Minimum number excluding '1'
            //int num, min, temp;
            //bool isfound = false;

            //showoutput("Enter the Value: ");
            //num = getInt(Console.ReadLine());
            //temp = num;

            //min = getMinimumDigit(num);


            //    while(temp!=0)
            //    {
            //        if (min <= 1)
            //        break;

            //        isfound = isdivisible(getlastDigit(temp), min);

            //        if (!isfound)
            //            break;

            //        temp /= 10;
            //    }


            //showoutput(isfound ? "Minimum Digit that divides the given number " + num + " is : " + min : "Not possible to divide");
            #endregion
            #region Q4-Minimum number that divides given digits
            //int num, min;
            //bool isfound = false;

            //showoutput("Enter the Value: ");
            //num = getInt(Console.ReadLine());

            //min = getMinimumDigit(num);

            //if (min >= 1)
            //{
            //    min = 1;
            //    isfound = true;
            //}

            //showoutput(isfound ? "Minimum Digit that divides the given number " + num + " is : " + min : "Not possible to divide");

            #endregion
            #region Q5-Check if given number is power of 4
            //int num,count=0;
            //int m;
            //bool ispower = false;
            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());



            //if (num > 0)
            //{
            //    m = 1;
            //    while (m <= num)
            //    {
            //        if (num == m)
            //        {
            //            ispower = true;
            //            break;
            //        }
            //        m <<= 2;//left shift everytime by two places
            //        count++;
            //    }
            //}
            //if(num < 0)
            //{
            //    m = -1;
            //    while (m >= num)
            //    {
            //        if (num == m)
            //        {
            //            ispower = true;
            //            break;
            //        }
            //        m <<= 2;//left shift everytime by two places
            //        count++;
            //    }
            //}

            //if (isdivisible(count, 2))//change sign to positive(for negative square inputs)
            //    num = Math.Abs(num);


            //showoutput(ispower ? "The given number "+num+  " is equal to: 4 "+"power of "+count : "Not power of 4");

            #endregion
            #region Q6-Power of K
            // int num, k, temp, count = 0;

            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //showoutput("Enter the K value: ");
            //k = getInt(Console.ReadLine());

            //temp = num;


            //while (temp != 1 && temp > 0)
            //{
            //    temp /= k;
            //    count++;
            //}

            //showoutput(temp == 1 ? "The number " + num + " can be represented as " + k + " power " + count : "Cannot be represented as power of K");

            #endregion
            #region Q7-Check for armstrong number
            //int num,count,temp,sum=0;

            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //count = getcount(num);

            //temp = num;

            //showoutput("The total count of " + num + " is: " + count);

            //Console.WriteLine();

            //while(temp!=0)
            //{
            //    sum += getPower(getlastDigit(temp), count);
            //    Console.Write(getlastDigit(temp) + "^" + count + "+");
            //    temp /= 10;
            //}
            //Console.Write("\b");//remove last character '+'


            //if (sum == num)
            //    Console.WriteLine(" = " + sum);

            //else
            //{
            //    Console.WriteLine(" != " + num);
            //    Console.WriteLine("The total sum of above expression is: " + sum);
            //}
            //Console.WriteLine();

            //showoutput(sum == num ? "The given number " + num + " is an armstrong number" : "The result------Not an armstrong number------- \t");
            #endregion
            #region Q8-Find Armstrong in a given range
            //int m, n;

            //showoutput("Enter the M value: ");
            //m = getInt(Console.ReadLine());

            //showoutput("Enter N value: ");
            //n = getInt(Console.ReadLine());

            //Console.Write("The Armstrong numbers are: ");
            //for(int i = m; i<=n; i++)
            //    Console.Write(isarmstrong(i) ? i + "," : "");

            //Console.Write("\b  \b");
            #endregion
            #region Q9-Perfect square or not
            //int num;

            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //showoutput(isperfectsquare(num) ? "The given number " + num + " is a perfect square" : "Not a perfect square" );

            #endregion
            #region Q10-sum of perfect squares less than N
            //int n,sum=0;

            //showoutput("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //// Approach
            //// 1. first perfect square is 4
            //// 2. difference between first perfect square and second perfect square is 9-4=5
            //// 3. difference between second and third is 16-9 = 7, clearly it is increasing by 2
            //// 4. Iterate diff by 2 and add to the sum.

            //if (n > 4)
            //    sum = 4;

            //int diff = 5;//9-4=5

            //Console.Write("The perfect squares are: ");
            //Console.Write(sum+" ");

            //for(int i=9 ; i<n; i+=diff)
            //{
            //    Console.Write(i+ " ");//prints all the perfect squares
            //    sum+=i;
            //    diff += 2;
            //}
            //Console.WriteLine();

            //showoutput(sum!=0? "The sum of perfect squares are: " + sum : "No perfect square exist for this input N ");
            #endregion
            #region Q11-nextperfectsquare
            //int n;

            //showoutput("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //showoutput("The next perfect square is: "+nextSquare(n));

            #endregion
            #region Q12-previousPerfectsquare
            //int n;

            //showoutput("Enter the N value: ");
            //n = getInt(Console.ReadLine());

            //showoutput("The Previous perfect square is: " + prevSquare(n));

            #endregion
            #region Q13-Nearestsquare
            //int n, nxt, prev, near;

            //showoutput("Enter the number: ");
            //n = getInt(Console.ReadLine());

            //nxt = nextSquare(n);
            //prev = prevSquare(n);




            //if (n < 4)
            //    near = 4;
            //else
            //    near = Math.Abs(n - nxt) < Math.Abs(n - prev) ? nxt : prev;

            //showoutput("The next perfect square from " + n + " is: " + nxt);
            //showoutput("The Previous perfect square from " + n + " is: " + prev);
            //showoutput("Input-previousSquare= " + Math.Abs(n - prev));
            //showoutput("Input-nextSquare= " + Math.Abs(n - nxt));
            //showoutput("The Nearest perfect square is:  " + near);
            #endregion
            #region Q14-Nearest armstrong
            //int num, next, prev, near;

            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //next = nxtArmstrong(num);
            //prev = prevArmstrong(num);

            //near = Math.Abs(num - next) < Math.Abs(num - prev) ? next : prev;

            //showoutput("The next Armstrong number from " + num + " is: " + next);
            //showoutput("The Previous Armstrong number from " + num + " is: " + prev);
            //showoutput("Input-previousArmstrong= " + Math.Abs(num - prev));
            //showoutput("Input-nextArmstrong= " + Math.Abs(num - next));
            //showoutput("The Nearest Armstrong number is:  " + near);


            #endregion
            #region Q15-Next->Armstrong number
            //int num, next;

            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //next = nxtArmstrong(num);

            //showoutput("The next Armstrong number from " + num + " is: " + next);


            #endregion
            #region Q16-Next->palindrome
            //int num;

            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //showoutput("The next palindrome from " + num + " is " + nextPalindrome(num));
            #endregion
            #region Q17-previous<-palindrome
            //int num;

            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //showoutput("The Previous palindrome from " + num + " is " + prevPalindrome(num));
            #endregion
            #region Q18-Kth perfect square from the given number
            //int num, k, res = 0;
            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //showoutput("Enter the Kth value");
            //k = getInt(Console.ReadLine());

            //res = nextSquare(num);

            //for (int i = 1; i <= k; i++)
            //{
            //    showoutput("The " + i + " Perfectsquare from " + num + " is: " + res);
            //    res = nextSquare(res);
            //}

            #endregion
            #region Q19-Kth Armstrong number from the given number
            //int num, k, res = 0;
            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //showoutput("Enter the Kth value");
            //k = getInt(Console.ReadLine());

            //res = nxtArmstrong(num);

            //for (int i = 1; i <=k; i++)
            //{
            //    showoutput("The " + i + " Armstrong number from " + num + " is: " + res);
            //    res = nxtArmstrong(res);
            //}
            #endregion
            #region Q20-Kth Palindrome number from the given number
            //int num, k, res = 0;
            //showoutput("Enter the number: ");
            //num = getInt(Console.ReadLine());

            //showoutput("Enter the Kth value");
            //k = getInt(Console.ReadLine());

            //res = nextPalindrome(num);

            //for (int i = 1; i <= k; i++)
            //{
            //    showoutput("The " + i + " Palindrome number from " + num + " is: " + res);
            //    res = nextPalindrome(res);
            //}
            #endregion
            #region Q21-get square root without using sqrt()
            //int num,next, prev;
            //double temp, square=0;
            //showoutput("Enter the number to find sqrt: "); 
            //num = getInt(Console.ReadLine());

            //next = nextSquare(num);
            //prev = prevSquare(num);

            //int prev_base = getbase(prev);
            //int next_base = getbase(next);

            //double epsilon = 0.00001f;

            //temp = prev_base + epsilon;//add zeroes to epsilon to get more accurate result

            //while(temp<=next_base)
            //{
            //    square = temp * temp;


            //    if (Math.Abs(temp - next_base) < epsilon || square >= num)
            //        break;

            //    temp+=epsilon;
            //}

            //temp-=epsilon;

            //showoutput("The square root of "+num+ " is " +  temp.ToString("n3"));
            #endregion
            #region Q22-Print armstrong - the number of digits mentioned
            //int n,i=1;

            //showoutput("Enter the number of digits: ");
            //n = getInt(Console.ReadLine());

            //i = getPower(10, n-1);//source : start print from

            //int j = i * 10;//destination : end printing

            //Console.Write("The " + n + " digit Armstrong numbers are: ");
            //while(i<j)
            //{
            //    if (isarmstrong(i))
            //        Console.Write(i + ",");
            //    i++;
            //}
            //Console.Write("\b \b");

            #endregion
            #region Q23-HCF of two given numbers
            //int num1, num2;

            //showoutput("Enter the first number: ");
            //num1 = getInt(Console.ReadLine());

            //showoutput("Enter the Second number: ");
            //num2 = getInt(Console.ReadLine());

            //showoutput("The HCF of " + num1 + " and " + num2 + " is: " + getHcf(num1, num2));

            #endregion
            #region Q24-LCM of two numbers
            //int num1, num2;

            //showoutput("Enter the first number: ");
            //num1 = getInt(Console.ReadLine());

            //showoutput("Enter the Second number: ");
            //num2 = getInt(Console.ReadLine());

            //showoutput("The LCM of " + num1 + " and " + num2 + " is: " + getLcm(num1, num2));

            #endregion
            #region Q25-LCM of three numbers
            //int num1, num2, num3;

            //showoutput("Enter the first number: ");
            //num1 = getInt(Console.ReadLine());

            //showoutput("Enter the Second number: ");
            //num2 = getInt(Console.ReadLine());

            //showoutput("Enter the third number: ");
            //num3 = getInt(Console.ReadLine());

            //showoutput("The LCM of " + num1 + " and " + num2 + " and " + num3 + " is: " + getLcm(num1, num2, num3));

            #endregion
            #region Q26-HCF of three numbers
            //int num1, num2, num3;

            //showoutput("Enter the first number: ");
            //num1 = getInt(Console.ReadLine());

            //showoutput("Enter the Second number: ");
            //num2 = getInt(Console.ReadLine());

            //showoutput("Enter the third number: ");
            //num3 = getInt(Console.ReadLine());

            //showoutput("The HCF of " + num1 + " and " + num2 + " and " + num3 + " is: " + getHcf(num1, num2, num3));
            #endregion
            #region Q27-Print fibonacci numbers
            //int n,n1,n2;

            //showoutput("Enter the Nth term: ");
            //n = getInt(Console.ReadLine());

            //n1 = 0;
            //n2 = 1;

            //Console.Write("Fibonacci sequence: ");

            //if(n==1)
            //Console.Write("0 ");

            //if (n > 1)
            //{
            //    Console.Write("0 1 ");
            //    n -= 2;
            //}

            //while(n!=0)
            //{
            //    Console.Write(n1 + n2 + " ");
            //    int temp = n1 + n2;
            //    n1 = n2;
            //    n2 = temp;
            //    n--;
            //}

            #endregion
            #region Q28-Kth Fibonacci number
            //int k;

            //showoutput("Enter the Kth value: ");
            //k = getInt(Console.ReadLine());

            //showoutput("The " + k + " Fibonacci number is: " + getFib(k));
            #endregion
            #region Q29-Next fibonacci
            //int val;

            //showoutput("Enter the value: ");
            //val = getInt(Console.ReadLine());

            //showoutput("The next Fibonacci number after " + val + " is: " + nextFib(val));

            #endregion
            #region Q30- Previous Fibonacci
            //int val;

            //showoutput("Enter the number: ");
            //val = getInt(Console.ReadLine());

            //showoutput("The previous fibonacci of " + val+ " is:"+prevFib(val));

            #endregion
            #region Q31-Given N find I
            //int n;
            //double i;
            //showoutput("Enter the fibonacci number to find the term: ");
            //n = getInt(Console.ReadLine());

            //if (n < 0)
            //    showoutput("Entered number is not fibonacci number");


            //if (n == 0)
            //    showoutput("The 1st term is 0 ");

            //if (n == 1)
            //    showoutput("The 2nd and 3rd is 1 ");



            //if (isFib(n) && n>1)
            //{


            //    double phi = (Math.Sqrt(5) + 1) / 2.0;

            //    i = Math.Round((getLog(n) + getLog(5 / 2)) / getLog(phi));

            //    showoutput("The " + (i+1) + "th term is: " + n);
            //}

            #endregion
            #region Q32-Check for fibonacci
            //int val;

            //showoutput("Enter the Value: ");
            //val = getInt(Console.ReadLine());


            //showoutput((isFib(val) && val>=0) ? val + " is a fibonacci number" : val + " is not fibonacci number");
            #endregion
        }

        #region Input-Output
        public static void showoutput(string message)
        {
            Console.WriteLine(message);
        }

        public static int getInt(string val)
        {
            return int.Parse(val);
        }
        #endregion


        //Arithmetic logics
        #region Check for Divisibility
        public static bool isdivisible(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }
        #endregion
        #region getRemainder
        public static int getRemainder(int num1, int num2)
        {
            return num1 % num2;
        }
        #endregion
        #region getLog
        public static double getLog(double num)
        {
            return Math.Log(num);
        }
        #endregion
        #region getLastDigit
        public static int getlastDigit(int num)
        {
            return num % 10;
        }
        #endregion



        //Frequently used logics
        #region get_Minimum_digit
        public static int getMinimumDigit(int val)
        {

            int min = getlastDigit(val);
            val /= 10;


            while(val!=0)
            {
                if(min>getlastDigit(val))
                 min = getlastDigit(val);
                

                if(min==0)
                    break;

                val /= 10;
            }

            return min;
        }
        #endregion
        #region count of a number
        public static int getcount(int num)
        {
            int count = 0;

            while(num!=0)
            {
                num /= 10;
                count++;
            }

            return count;
        }
        #endregion
        #region powerfunction
        public static int getPower(int num, int k)
        {
            int res = 1;

            while (k > 0)
            {
                int l_bit = k & 1;//check if lsb is 1 or 0

                if (l_bit == 1)//if lbit is 1, multiply res with the base
                    res *= num;

                num *= num;

                k /= 2;//right shift by one place
            }

            return res;
        }
        #endregion
       
        


        //Fibonacci logics
        #region getFib
        public static int getFib(int n)
        {
            int n1 = 1, n2 = 1;


            if (n == 1)
                return 0;

            if (n == 2 || n == 3)
                return 1;

            n -= 3;

            while (n != 0)
            {
                int temp = n1+n2;
                n1 = n2;
                n2 = temp;
                n--;
            }
            return n2;

        }
        #endregion
        #region NextFibonacci
        public static int nextFib(int num)
        {
            if (num < 0)
                return 0;

            if (num == 0)
                return 1;

            double a = num * (1 + Math.Sqrt(5)) / 2.0;
            return (int)Math.Round(a);
        }
        #endregion
        #region PreviousFibonacci
        public static int prevFib(int num)
        {
            if (num < 0)
                return -1;


            if (num == 1)
                return 0;

            double a = num-2 * (1 + Math.Sqrt(5)) / 2.0;
            return Math.Abs((int)Math.Round(a));
        }
        #endregion
        #region CheckforFib
        public static bool isFib(int num)
        {
            return isperfectsquare((5 * num * num) + 4) || isperfectsquare((5 * num * num) - 4);
            
        }
        #endregion

        //Perfectsquare logics
        #region check for perfectsquare
        public static bool isperfectsquare(int num)
        {
            int sum = 4;

            if (sum == num)
                return true;

            for(int i=5;i<num;i+=2)
            {
                sum += i;
                if (sum == num)
                    return true;
            }
            return false;
        }
        #endregion
        #region Next->perfectsquare
        public static int nextSquare(int num)
        {

            num++;

            while(!isperfectsquare(num))
            {
                num++;
            }

            return num;
        }
        #endregion
        #region previous<-PerfectSquare
        public static int prevSquare(int num)
        {

            num--;

            if (num < 4)
                return 0;

            while (!isperfectsquare(num))
            {
                num--;
            }

            return num;
        }
        #endregion
        #region getsquareroot- for perfect squares only
        public static int getbase(int val)
        {
            int count = 1;//substract consecutive odd numbers and count them

            for (int i = 1; i < val; i += 2)
            {
                if (val == 0)
                    break;
                val -= i;
                count++;
            }

            return count;
        }
        #endregion

        //Armstrong logics
        #region checkforArmstrong
        public static bool isarmstrong(int num)
        {
            int sum = 0, temp = num;

            int count = getcount(num);

            while (temp != 0)
            {
                sum += getPower(getlastDigit(temp), count);
                temp /= 10;
            }

            return sum == num;
        }
        #endregion
        #region Nextarmstrong
        public static int nxtArmstrong(int num)
        {
            num++;//start from the next number


            if (num < 0)
                return 0;

            while (!isarmstrong(num))
                num++;

            return num;
        }
        #endregion
        #region previousArmstrong
        public static int prevArmstrong(int num)
        {
            num--; //start from the prev number.

            if (num < 0)
                return -1;

          
            while (!isarmstrong(num))
                num--;

            return num;
        }
        #endregion

        //HCF and LCM
        #region getHCF
        public static int getHcf(int num1, int num2)
        {
            int numerator = num1;
            int denominator = num2;



            while (!isdivisible(numerator,denominator))
            {
                int temp = getRemainder(numerator, denominator);
                numerator = denominator;
                denominator = temp;
            }

            return denominator;
        }

        public static int getHcf(int num1, int num2,int num3)
        {
            int numerator = getHcf(num1, num2);
            int denominator = num3;

            return getHcf(numerator, denominator);
        }


        #endregion
        #region getLcm
        public static int getLcm(int num1,int num2)
        {
            int hcf = getHcf(num1, num2);//using Euclid method (HCF x LCM = num1 x num2)

            return (num1 * num2)/hcf;//Rewriting equation as LCM = (num1 x num2)/HCF
        }
                public static int getLcm(int num1, int num2,int num3)
        {
            int hcf = getHcf(num1, num2,num3);//using Euclid method (HCF x LCM = num1 x num2 x num3)

            return ((num1 * num2 * num3) * hcf)/((getHcf(num1,num2))*(getHcf(num2,num3))*(getHcf(num3,num1)));//Rewriting equation as LCM = (num1 x num2 x num3)/HCF
        }


        #endregion

        //Palindrome logics
        #region Checkpalindrome
        public static bool ispalindrome(int num)
        {
            return reverse(num) == num;
        }
        #endregion
        #region reversedigits
        public static int reverse(int num)
        {
            int temp = 0;

            while(num!=0)
            {
                temp = (temp*10)+(num % 10);
                num /= 10;
            }
            return temp;
        }
        #endregion
        #region next->Palindrome number
        public static int nextPalindrome(int num)
        {
            num++;

            if (num < 0)
                return 0;

            while (!ispalindrome(num))
                num++;

            return num;
        }
        #endregion
        #region previous<-palindrome number
        public static int prevPalindrome(int num)
        {
            num--;

            if (num < 0)
                return -1;

            while (!ispalindrome(num))
                num--;

            return num;

        }
        #endregion
    }
}
