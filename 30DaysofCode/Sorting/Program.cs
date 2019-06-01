using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        // Write Your Code Here
        BubbleSort(a);
    }

    static void BubbleSort(int[] array) {
        int numSwaps = 0;
        for (int i = 0; i < array.Length; i++) {
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;
            
            for (int j = 0; j < array.Length - 1; j++) {
                // Swap adjacent elements if they are in decreasing order
                if (array[j] > array[j + 1]) {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    numberOfSwaps++;
                    numSwaps++;
                }
            }
            
            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0) {
                break;
            }
        }
        Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
        Console.WriteLine($"First Element: {array[0]}");
        Console.WriteLine($"Last Element: {array[array.Length - 1]}");
    }
}