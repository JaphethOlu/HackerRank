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

    /*
    static int[] leftRotation(int[] array, int numOfRot)
    {
        while(numOfRot > 0)
        {
            int rotatingValue = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                array[i-1] = array[i];
            }
            array[array.Length-1] = rotatingValue;
            numOfRot--;
        }
        return array;
        // Test Case 8 terminates due to timeout in this solution
        // This is because of the Asymptotic run time/Time Complexity
        // Time Complexity is O(dn)
        // d represent number of rotations
        // n represents problem space
        // Best Solution
        // Make Time/Space Complexity Trade-Off
    }
    */

    static int[] leftRotation(int[] array, int numOfRot)
    {
        int[] rotatedArray = new int[array.Length];

        int revStartIndex = array.Length - numOfRot;

        int aStartIndex = numOfRot;

        int valuesToShift = array.Length - numOfRot;

        Array.Copy(array, 0, rotatedArray, revStartIndex, numOfRot); // Reverse Elements

        Array.Copy(array, aStartIndex, rotatedArray, 0, valuesToShift); // Shift Elements to Left

        return rotatedArray;

        /*  Time Complexity is O(n)
        *   Space Complexity is O(n)
        */
    }

    static void Main(string[] args) {

        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        int[] result = leftRotation(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
