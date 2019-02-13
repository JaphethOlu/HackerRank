using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        TryToInt(S);
    }

    static void TryToInt(string s) {
        try {
            int number = Int32.Parse(s);
            Console.WriteLine(number);
        } catch (Exception e) {
            Console.WriteLine("Bad String");
        }
    }
}