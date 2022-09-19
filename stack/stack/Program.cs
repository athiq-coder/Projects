using System;
using System.Collections.Generic;
namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12345*+-+";

            Queue<int> postfix = new Queue<int>(s.Length);

            int sum = 0;

            for(int i=0; i < s.Length; i++)
            {
                if(!isOperator(s[i]))
                {
                    postfix.Enqueue(s[i] - '0');
                }
                else
                {
                    sum +=(applyOperator(postfix.Dequeue(), postfix.Dequeue(), s[i]));
                }
            }

            Console.WriteLine(postfix.Peek());
        }

        public static bool isOperator(char s)
        {
            if (s == '+' || s == '-' || s == '*' || s == '/')
            {
                return true;
            }
            return false;
        }

        public static int applyOperator(int val1,int val2,char op)
        {
            if (op == '+')
            {
                return val1 + val2;
            }
            else if(op == '-')
            {
                return val1 - val2;
            }else if(op == '*')
            {
                return val1 * val2;
            }else if(op == '/')
            {
                return val1 / val2;
            }
            return -1;
        }
    }
}
