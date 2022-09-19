    using System;

    namespace challenge_day1
    {
        class Program
        {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testcases; i++)
            {
                ulong n = ulong.Parse(Console.ReadLine());

                while (true)
                {
                    if (n == 1 || n == 2)
                    {
                        Console.WriteLine("NO");
                        break;
                    }

                    if (n % 2 != 0)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                    n /= 2;
                }
            }
        }
    }
}
