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
//https://www.hackerrank.com/challenges/30-binary-numbers/submissions/code/73106424

class Solution 
{

    static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int size = 0;
        List<int> bin = new List<int>();
        int lastNum = 0;
        int currentSize = 0;
        int max = 0;

        for (int i = 0; Math.Pow(2, i) < n; i++)
            size++;

        for (int i = (size - 1); i >= 0; i--)
        {
            if (n - Math.Pow(2, i) >= 0)
            {
                n = (int)(n - Math.Pow(2, i));
                bin.Insert(0, 1);
            }
            else
            {
                bin.Insert(0, 0);
            }
        }

        for (int i = 1; i < bin.Count(); i++)
        {
            lastNum = bin[i - 1];
            if (lastNum == 1)
            {
                if (max == 0)
                    max++;
                    
                if (bin[i] == 1)
                {
                    if (currentSize == 0)
                        currentSize++;

                    currentSize++;
                }
            }
            else
            {
                currentSize = 0;
            }

            if (currentSize > max)
                max = currentSize;
        }

        Console.WriteLine(max);

        return;
    }
}
