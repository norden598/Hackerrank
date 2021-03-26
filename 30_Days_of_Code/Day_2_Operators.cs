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
// https://www.hackerrank.com/challenges/30-operators/problem

class Solution {

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
		double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());
        double tip = meal_cost * (tip_percent * 0.01);
        double tax = meal_cost * (tax_percent * 0.01);
        int totalCost = Convert.ToInt16(meal_cost + tip + tax);
        //totalCost = Math.Round(totalCost);
        // 15.50
        // 2.33
        // 1.55
        // ----- 
        // 
        
        Console.WriteLine("The total meal cost is {0} dollars.", totalCost);
    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}