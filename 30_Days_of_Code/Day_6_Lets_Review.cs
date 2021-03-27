using System;
using System.Collections.Generic;
using System.IO;

// AWN
//https://www.hackerrank.com/challenges/30-review-loop/submissions/code/72780421

class Solution {

    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        List<string> inputs = new List<string>();
        
        for (int i = 0; i < n; i++)
            inputs.Add(Console.ReadLine());    
        
        for (int i = 0; i < n; i++)
        {
            List<char> evens = new List<char>();
            List<char> odds = new List<char>();
            string current = inputs[i];
            string output = String.Empty;
            
            for (int j = 0; j < current.Length; j++)
            {
                if (j % 2 == 0)
                    evens.Add(current[j]);
                else 
                    odds.Add(current[j]);
            }
            
            for (int j = 0; j < evens.Count; j++)
                output = String.Format("{0}{1}", output, evens[j]);
            
            output = String.Format("{0} ", output);
            
            for (int j = 0; j < odds.Count; j++)
                 output = String.Format("{0}{1}", output, odds[j]);
            
            Console.WriteLine(output);
        }

    return;
    }
}