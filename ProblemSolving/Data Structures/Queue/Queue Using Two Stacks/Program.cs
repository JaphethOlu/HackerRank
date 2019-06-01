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
        OperateQueue(Q);
    }

    static void OperateQueue(string[] queries)
    {
        Stack<int> queue = new Stack<int>();
        Stack<int> temp = new Stack<int>();

        foreach(string query in queries)
        {
            if(query.StartsWith("1"))
            {
                int val = Convert.ToInt32(query.Substring(2));
                temp.Push(val);
            }
            else if(query.StartsWith("2"))
            {
                if(queue.Count == 0)
                {
                    while(temp.Count != 0)
                    {
                        queue.Push(temp.Pop()); // Turning stack to a queue
                    }
                }
                queue.Pop();
            }
            else
            {
                if(queue.Count == 0)
                {
                    while(temp.Count != 0)
                    {
                        queue.Push(temp.Pop()); // Turning stack to a queue
                    }
                }
                Console.WriteLine(queue.Peek());
            }
        }
    }
}