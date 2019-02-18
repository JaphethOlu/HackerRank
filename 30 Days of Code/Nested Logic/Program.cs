using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string returnDate = Console.ReadLine();
        string dueDate = Console.ReadLine();

        DateTime rDate = ConvertToDateTime(returnDate);
        DateTime dDate = ConvertToDateTime(dueDate);

        Console.WriteLine(CalculateFine(rDate, dDate));
    }

    static int CalculateFine(DateTime returnDate, DateTime dueDate) {
        if(returnDate < dueDate) {
            return 0;
        }
        else if(returnDate.Year > dueDate.Year)
        {
            return 10000;
        }  
        else if(returnDate.Month > dueDate.Month)
        {
            return 500 * (returnDate.Month - dueDate.Month);
        } 
        else if(returnDate.Day > dueDate.Day)
        {
            return 15 * (returnDate.Day - dueDate.Day);
        }
        else
        {
            return 0;
        }
    }

    static DateTime ConvertToDateTime(string date) {
        string[] dateArray = date.Split(' ');

        int day = Int32.Parse(dateArray[0]);
        int month = Int32.Parse(dateArray[1]);
        int year = Int32.Parse(dateArray[2]);

        return new DateTime(year, month, day);
    }
}
