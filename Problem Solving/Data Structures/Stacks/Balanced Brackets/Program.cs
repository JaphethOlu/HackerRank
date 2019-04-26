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

    // Complete the isBalanced function below.
    static string isBalanced(string s) {

        const string N = "NO";
        const string Y = "YES";

        Stack<char> brackets = new Stack<char>();

        foreach(char character in s)
        {
            switch(character)
            {
                case '(':
                case '{':
                case '[':
                    brackets.Push(character);
                    break;
                case ']':
                    if(brackets.Count == 0 || brackets.Peek() != '[')
                    {
                        return N;
                    }
                    brackets.Pop();
                    break;
                case '}':
                    if(brackets.Count == 0 || brackets.Peek() != '{')
                    {
                        return N;
                    }
                    brackets.Pop();
                    break;
                case ')':
                    if(brackets.Count == 0 || brackets.Peek() != '(')
                    {
                        return N;
                    }
                    brackets.Pop();
                    break;

            }
        }
        if(brackets.Count == 0)
        {
            return Y;
        }
        else
        {
            return N;
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
