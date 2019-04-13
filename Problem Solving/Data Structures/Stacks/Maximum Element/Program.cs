using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int N = Convert.ToInt32(Console.ReadLine());

        string[] Q = new string[N];

        for(int i = 0; i < Q.Length; i++)
        {
            Q[i] = Console.ReadLine();
        }

        MaximumElement(Q);
    }

    static void MaximumElement(string[] queries)
    {
        int maxValue = Int32.MinValue;

        Stack<Node> elements = new Stack<Node>();

        foreach(string query in queries)
        {
            if(query.StartsWith("1"))
            {
                int val = Convert.ToInt32(query.Substring(2));
                if(val > maxValue)
                {
                    maxValue = val;
                }
                var node = new Node(val, maxValue);
                elements.Push(node);
            }
            else if(query.StartsWith("2"))
            {
                elements.Pop();

                if(elements.Count == 0)
                {
                    maxValue = Int32.MinValue;
                }
                else
                {
                    var peek = elements.Peek();
                    maxValue = peek.MaxValue;
                }
            }
            else
            {
                var peek = elements.Peek();
                Console.WriteLine(peek.MaxValue);
            }

        }
    }

    class Node
    {
        public int Value { get; set; }
        public int MaxValue { get; set; }

        public Node(int value, int maxValue)
        {
            Value = value;
            MaxValue = maxValue;
        }
    }
}
