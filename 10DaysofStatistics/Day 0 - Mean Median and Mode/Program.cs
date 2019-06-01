using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int N = Convert.ToInt32(Console.ReadLine());

        int[] X = new int[N];

        X = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        decimal mean = CalculateMean(X);
        decimal median = GetMedian(X);
        int mode = GetMode(X);

        Console.WriteLine(mean);
        Console.WriteLine(median);
        Console.WriteLine(mode);
    }

    static decimal CalculateMean(int[] array)
    {
        decimal sum = 0;

        foreach(int value in array)
        {
            sum += value;
        }

        decimal mean = Decimal.Round(sum / array.Length, 1);
        return mean;
    }

    static decimal GetMedian(int[] array)
    {
        decimal median = 0;

        Array.Sort(array);

        if(array.Length % 2 == 0)
        {
            int position = array.Length / 2;
            decimal rightCenter = array[position];
            decimal leftCenter = array[position - 1];
            return median = Decimal.Round((leftCenter + rightCenter) / 2, 1);
        }
        else
        {
            return median = array[array.Length / 2];
        }
    }

    static int GetMode(int[] array)
    {
        int occurence = 0;
        int position = 0;
        int currentValue = array[0];

        int frequency = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(currentValue == array[i])
            {
                frequency++;
            }
            else
            {
                currentValue = array[i];
                frequency = 1;
            }
            if(frequency > occurence)
            {
                occurence = frequency;
                position = i;
            }
        }
        return array[position];
    }
}
