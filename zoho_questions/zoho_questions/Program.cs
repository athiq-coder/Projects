using System;
using System.Collections.Generic;
namespace zoho_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string inputStr = Console.ReadLine();

            string[] splittedInputStr = inputStr.Split(" ");
            bool matched = true;
            Dictionary<String, char> patternMatcher = new Dictionary<String, char>();
            if (pattern.Length == splittedInputStr.Length) {
                int index = 0;
                while (index < pattern.Length)
                {
                    char p = pattern[index];
                    string s = splittedInputStr[index];
                
                    if (patternMatcher.ContainsKey(s))
                    {
                        char value = patternMatcher[s];
                        if (value != p)
                        {
                            matched = false;
                            break;
                        }
                           
                    } else if (patternMatcher.ContainsValue(p))
                    {
                        matched = false;
                        break;

                    }

                    patternMatcher[s] = p;

                    index++;
                }
            } else
            {
                matched = false;
            }
            
            Console.WriteLine(matched ? "true" : "false");
        }
    }
}
