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
        int N = Convert.ToInt32(Console.ReadLine());
        int Count = NumberOfOnes(N);
        WriteLine($"{Count}");
    }

    public static int NumberOfOnes(int bTenDigit)
    {
        int currentResult = 0;
        int previousResult = 0;
        int counter = 0;
        int maxCount = 0;

        while(bTenDigit != 0)
        {
            previousResult = currentResult;

            currentResult = bTenDigit % 2;

            if(previousResult == 0 && currentResult == 1)
            {
                counter = 1;
            }
            if(previousResult == 1 && currentResult == 1)
            {
                counter++;
                if(maxCount <= counter)
                {
                    maxCount = counter;
                }
            }
            if(previousResult == 1 && currentResult == 0)
            {
                if(maxCount <= counter)
                {
                    maxCount = counter;
                }
            }
            
            bTenDigit = bTenDigit / 2;
        }
        return maxCount;
    }
}
