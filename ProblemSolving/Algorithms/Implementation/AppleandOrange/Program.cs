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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        int countApples = 0;
        int countOranges = 0;

        //s: start point of sam's house
        //t: end point of sam's house
        //a: location of apple tree
        //b: location of orange tree

        int distanceFell = 0;
        foreach(int value in apples)
        {
            distanceFell = a + value;
            if(distanceFell >= s && distanceFell <= t)
            {
                countApples++;
            }
        }

        foreach(int value in oranges)
        {
            distanceFell = b + value;
            if(distanceFell <= t && distanceFell >= s)
            {
                countOranges++;
            }
        }

        Console.WriteLine($"{countApples}");
        Console.WriteLine($"{countOranges}");
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
