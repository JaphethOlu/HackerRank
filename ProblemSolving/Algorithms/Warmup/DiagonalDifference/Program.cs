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

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr) {

        int primaryRow = 0;
        int primaryColumn = 0;

        int secondaryRow = 0;
        int secondaryColumn = arr.Length - 1;

        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        while(primaryRow < arr.Length)
        {
            primaryDiagonal += arr[primaryRow][primaryColumn];
            primaryRow++;
            primaryColumn++;

            secondaryDiagonal += arr[secondaryRow][secondaryColumn]; 
            secondaryRow++;
            secondaryColumn--;
        }

        int difference = primaryDiagonal - secondaryDiagonal;

        return Math.Abs(difference);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
