using System;
using static System.Console;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputArray = Convert.ToString(Console.ReadLine());
            int outputArraySize = inputArray.Length + 1;

            string[] outputArray = new String[outputArraySize];

            int outputArrayPosition = 0;
            for(int i = inputArray.Length + 1; i >= 0; i--)
            {
                outputArray[outputArrayPosition] = inputArray[i];   
                outputArrayPosition++;
            }

            WriteLine(outputArray.ToString());
        }
    }
}
