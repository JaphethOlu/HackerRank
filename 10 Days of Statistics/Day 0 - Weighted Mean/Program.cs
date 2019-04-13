using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int N = Convert.ToInt32(Console.ReadLine());

        int[] X = new int[N];

        int[] W = new int[N];

        X = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        W = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        decimal result = CalculateMean(X, W);

        Console.WriteLine(result);
    }

    static decimal CalculateMean(int[] elements, int[] weights) {
        
        decimal sum = 0;
        decimal weightSum = 0;

        for(int i = 0; i < elements.Length; i++) {
            sum += (elements[i] * weights[i]);
            weightSum += weights[i];
        }

        // For some reason, the 1st test case never passes. C# issues
        decimal mean = Decimal.Round(sum/weightSum, 1);
        return mean;
    }

}
