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
//https://www.hackerrank.com/challenges/30-2d-arrays/submissions/code/73168327

class Solution {

// 1 1 1 0 0 0
// 0 1 0 0 0 0
// 1 1 1 0 0 0
// 0 0 2 4 4 0
// 0 0 0 2 0 0
// 0 0 1 2 4 0

    static void Main(string[] args) 
    {
        int[][] arr = new int[6][];
        int currentSum = -100;
        int maxSum = -100;
        
        for (int i = 0; i < 6; i++) 
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                
        for (int i = 1; i < 5; i++)
        {
            for (int j = 1; j < 5; j++)
            {
                int center = arr[i][j];
                int topLeft = arr[i - 1][j - 1];
                int topMid = arr[i - 1][j];
                int topRight = arr[i - 1][j + 1];
                int botLeft = arr[i + 1][j - 1];
                int botMid = arr[i + 1][j];
                int botRight = arr[i + 1][j + 1];
                
                currentSum = center + topLeft + topMid + topRight + botLeft + botMid + botRight;
                if (currentSum > maxSum)
                    maxSum = currentSum;
            }
        }

        Console.WriteLine(maxSum);

        return;
    }
}
