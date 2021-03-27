using System;
using System.Linq;

// AWN
//https://www.hackerrank.com/challenges/30-scope/problem

class Difference 
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        maximumDifference = 0;
        int curDiff = 0;
        
        maximumDifference = elements.Max() - elements.Min();
    }
} // End of Difference Class

class Solution 
{
    static void Main(string[] args) 
    {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
    
    