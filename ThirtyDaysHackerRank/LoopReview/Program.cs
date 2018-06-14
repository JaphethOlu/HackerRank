using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace LoopReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            var words = new List<string>();
            int numberOfWords = 0;

            char[] charsToTrim = {' '};

            string newWord;
            while(numberOfWords < numberOfTestCases)
            {
                newWord = Console.ReadLine();
                words.Add(newWord);
                numberOfWords++;
            }
            
            foreach(var word in words)
            {
                var characterSize = word.Length;
                char[] evenPosition = new char[characterSize];
                char[] oddPosition = new char[characterSize];
                evenPosition[0] = word[0];
                int evenCount = 0;
                int oddCount = 0;
                for(int i = 1; i < word.Length; i++)
                {
                    if(i%2 != 0)
                    {
                        oddPosition[evenCount] = word[i];
                        evenCount++;
                    }
                    else
                    {
                        evenPosition[oddCount] = word[i];
                        oddCount++;
                    }
                }
                string evenString = new string(evenPosition);
                
                string oddString = new string(oddPosition);

                WriteLine($"{evenString} {oddString}");
            }
        }
    }
}
