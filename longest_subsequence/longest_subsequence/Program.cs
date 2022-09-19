using System;

namespace longest_subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12345*+-+";

            int i = 0;

            int sum = 0;

            while (s[i] <= '9' && s[i] >= '0')
            {
                i++;
            }

            sum = applyOperator((s[0] - '0'), (s[1] - '0'), s[i++]);

            for(int j=2; s[j] <= '9' && s[j] >= '0'; j++)
            {
                char ch = s[i++];

                sum = applyOperator(sum,(s[j]-'0'), ch);
            }

            Console.WriteLine(sum);

        }
        public static int applyOperator(int val1,int val2,char op)
        {

            if (op == '+')
            {
                return val1 + val2;

            }
            else if (op == '-')
            {
                return val1 - val2;

            }
            else if (op == '*')
            {
                return val1 * val2;

            }
            else if (op == '/')
            {
                return val1 / val2;

            }

            return -1;
        }
    }
}
