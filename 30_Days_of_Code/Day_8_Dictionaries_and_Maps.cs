using System;
using System.Collections.Generic;
using System.IO;

// AWN
//https://www.hackerrank.com/challenges/30-dictionaries-and-maps/submissions/code/72936252

class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> phonebook = new Dictionary<string, int>();
        string query = String.Empty;
        
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            string name = inputSplit[0];
            int number = Convert.ToInt32(inputSplit[1]);
            
            phonebook.Add(name, number);
        }
        
        while(true) 
        {
            query = Console.ReadLine();
            int outvalue = 0;
            
            if (phonebook.ContainsKey(query))
            {
                phonebook.TryGetValue(query, out outvalue);
                Console.WriteLine("{0}={1}", query, outvalue);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        return;
    }
}