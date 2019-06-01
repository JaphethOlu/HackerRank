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
using static System.Console;

class Solution {
    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        int[] reverseArray = new int[n];

        if(n == 1) 
        {
            WriteLine($"{arr.ToString()}");
        }
        else
        {
            processArray(n, arr, reverseArray);
            stringArray(reverseArray);
        }
    }

    public static void processArray(int length, int[] originalArray, int[] reverseArray)
    {
        int k = 0; //reverseArray index

        for(int i = length - 1; i >= 0; i--)
        {
            reverseArray[k] = originalArray[i];
            k++;
        }
    }

    public static void stringArray(int[] array)
    {
        StringBuilder builder = new StringBuilder("");
        for(int i = 0; i < array.Length - 1; i++)
        {
            builder.Append(array[i].ToString());
            builder.Append(" ");
        }

        builder.Append(array[array.Length-1].ToString());

        WriteLine(builder);
    }
}
