using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());

        int[] testCases = new int[n];

        int i = 0;

        while(i < n) {
            testCases[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

        foreach(int num in testCases) {
            if(IsPrimeNumber(num)) {
                Console.WriteLine("Prime");
            } else {
                Console.WriteLine("Not prime");
            }
        }       
    }

    static bool IsPrimeNumber(int number)
    {
        bool isPrime = true;

        if(number <= 1) {
            isPrime = false;
        } else {
            int sqrt = (int) Math.Sqrt(number);
            for(int i = 2; i <= sqrt; i++) {
                if(number%i == 0) {
                    isPrime = false;
                }
            }
        }        
        return isPrime;
    }
}