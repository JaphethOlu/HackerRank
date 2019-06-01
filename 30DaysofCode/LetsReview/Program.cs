// Challenge Link: https://www.hackerrank.com/challenges/30-review-loop/problem
using System;
using System.Text;
using System.Collections.Generic;
using static System.Console;

namespace LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            List<string> testCases = new List<string>();

            while(T != 0)
            {
                string newTestString = Console.ReadLine();
                testCases.Add(splitTestString(newTestString));
                T--;
            }

            foreach(string value in testCases)
            {
                WriteLine($"{value}");
            }
        
        }

        static string splitTestString(string testString)
        {
            StringBuilder even = new StringBuilder();
            StringBuilder odd = new StringBuilder();
            for(int i = 0; i <= testString.Length-1; i++)
            {
                if(i == 0)
                {
                    even.Append(testString[i]);
                }
                else if(i % 2 == 0)
                {
                    even.Append(testString[i]);
                }
                else
                {
                    odd.Append(testString[i]);
                }
            }
            return even.ToString() + " " + odd.ToString();
        }
    }
}
