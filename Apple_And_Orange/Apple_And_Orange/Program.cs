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

class Result
{

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int apple_Position = 0;
        int orange_Position = 0;
        int apple_Count_In_Position = 0;
        int orange_Count_In_Position = 0;

        foreach (int apple in apples)
        {
            apple_Position = a + apple;
            if (apple_Position >= s && apple_Position <= t)
            {
                apple_Count_In_Position += 1;
            }

        }
        Console.WriteLine(apple_Count_In_Position);
        foreach (int orange in oranges)
        {
            orange_Position = b + orange;
            if (orange_Position >= s && orange_Position <= t)
            {
                orange_Count_In_Position += 1;
            }

        }
        Console.WriteLine(orange_Count_In_Position);

    }




}

class Solution
{
    public static void Main(string[] args)
    {
       // 7 11
//5 15
//3 2
//- 2 2 1
//5 - 6
        int s = 7;

        int t = 11;


        int a = 5;

        int b = 15;


        int m = 3;

        int n = 2;

        List<int> apples = new List<int> { -2, 2, 1 };

        List<int> oranges = new List<int> { 5, -6 };

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
