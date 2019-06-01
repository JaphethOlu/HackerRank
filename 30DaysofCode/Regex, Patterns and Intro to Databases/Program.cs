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

    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());

        string[] firstNames = new string[N];

        string[] emails = new string[N];

        List<string> gmailNames = new List<string>();

        int NItr = 0;

        while(NItr < N) {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');
            firstNames[NItr] = firstNameEmailID[0];
            emails[NItr] = firstNameEmailID[1];
            NItr++;
        }

        for(int i = 0; i < emails.Length; i++) {
            if(IsGmail(emails[i])) {
                gmailNames.Add(firstNames[i]);
            }
        }

        gmailNames.Sort();

        foreach(string name in gmailNames) {
            Console.WriteLine(name);
        }
    }

    static bool IsGmail(string emailAddress) {
        var pattern = new Regex(@"(@gmail.com)");
        
        if(pattern.IsMatch(emailAddress)) {
            return true;
        }
        else {
            return false;
        }
    }
}
