// Challenge Link: https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
using System;
using System.Collections.Generic;
using static System.Console;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> PhoneBook = new Dictionary<string, int>();
            
            int NumberOfContacts = Convert.ToInt32(Console.ReadLine());

            while(NumberOfContacts != 0)
            {
                string NewContact = Console.ReadLine();
                string[] Contact = NewContact.Split(" ");
                string NewContactName = Contact[0];
                int NewContactNumber = Convert.ToInt32(Contact[1]);
                PhoneBook.Add(NewContactName, NewContactNumber);
                NumberOfContacts--;
            }
        }
    }
}
