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
//https://www.hackerrank.com/challenges/30-loops/submissions/code/72764849

class Solution {

    static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= 10; i++)
            Console.WriteLine("{0} x {1} = {2}", n, i, n * i);

        return;
    }
}
