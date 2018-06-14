using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = arr_temp.Select(s => Int32.Parse(s)).ToArray();

            int m = arr_temp.Length;
            WriteLine($"n is {n} while m is {m}");
            string[] new_arr = new string[n];

            int i = 0;
            while(n >= 0)
            {
                new_arr[i] = arr_temp[m-1];
                i++;
                m--;
            }
            WriteLine($"{new_arr.ToString()}");
            */

            int[] special = {5, 3, 6, 9, 0};
            
            WriteLine($"{special.Length}");
        }
    }
}
