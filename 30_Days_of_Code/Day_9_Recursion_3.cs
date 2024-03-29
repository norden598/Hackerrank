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

// AWN
//https://www.hackerrank.com/challenges/30-recursion/submissions/code/73022944

class Solution {

    // Complete the factorial function below.
    static int factorial(int n) 
    {
        int value = n;
        
        if (n > 2)   
            value *= factorial(n - 1);  
        
        return value;
    }

    static void Main(string[] args) 
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        int result = factorial(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();

        return;
    }
}
