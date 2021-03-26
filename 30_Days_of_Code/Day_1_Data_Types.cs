using System;
using System.Collections.Generic;
using System.IO;

// AWN

//https://www.hackerrank.com/challenges/30-data-types/problem

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int ii = Convert.ToInt32(Console.ReadLine());
        double dd = Convert.ToDouble(Console.ReadLine());
        string ss = Console.ReadLine();
        // Read and save an integer, double, and String to your variables.
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + ii);
        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:0.0}", d + dd);
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + ss);
        // The 's' variable above should be printed first.
    }
}