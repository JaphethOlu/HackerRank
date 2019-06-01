using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {



    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        Console.WriteLine(CalculateMaxSum(arr));
    }

    static int CalculateMaxSum(int[][] arr)
    {
        int maxSum = -27; // Lowest possible value of the hourglass since negative values are allowed

        for(int i = 0; i < 4; i++)
        {
            int maxColReach = arr[i].Length - 2;
            
            for(int j = 0; j < maxColReach; j++)
            {
                int firstRowSum = arr[i][j] + arr[i][j+1] + arr[i][j+2];
                int secondRowSum = arr[i+1][j+1];
                int thirdRowSum = arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];

                int hourGlassSum = firstRowSum + secondRowSum + thirdRowSum;

                if(hourGlassSum >= maxSum)
                {
                    maxSum = hourGlassSum;
                }
            }
        }
        return maxSum;
    }
}
