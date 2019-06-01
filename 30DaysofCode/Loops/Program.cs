using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                WriteLine($"{n} x {i} = {n*i}");
            }
        }
    }
}
