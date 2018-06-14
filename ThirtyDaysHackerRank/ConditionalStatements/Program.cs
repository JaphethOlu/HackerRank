using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        if(N%2 != 0)
        {
            WriteLine("Weird");
        }
        else
        {
            if((N >= 2) && (N <= 5))
            {
                WriteLine("Not Weird");
            }
            if((N >= 6) && (N <= 20))
            {
                WriteLine("Wierd");
            }
            if(N > 20)
            {
                WriteLine("Not Weird");
            }
        }
    }
}
