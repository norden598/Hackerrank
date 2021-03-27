using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// AWN
//https://www.hackerrank.com/challenges/30-arrays/submissions/code/72851032

class Solution {

    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        string str = String.Empty;
        List<int> ints = new List<int>();
        
        for (int i = 0; i < n; i++)
            ints.Add(arr[(n - i) - 1]);
                    
        str = String.Join(" ", ints);
        Console.WriteLine(str);

        return;
    }
}