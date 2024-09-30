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
    // بسم الله 
    // لينك المسألة
    // https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        // مكان التفاحه
        int apple_Position = 0;
        // مكان البرتقاله
        int orange_Position = 0;
        // عدد التفاح اللى نزل علي البيت
        int apple_Count_In_Position = 0;
        // عدد البرتقال اللى نزل علي البيت
        int orange_Count_In_Position = 0;
        // ابدأ اطبع عشان تشوف القيم اللي هتستغل عليها


        foreach (int apple in apples)
        {
            // a اول البيت تجاه شجره التفاح
            // apple + التفاحه راحت ناحيه البيت - التفاحه راحت بعيد عن البيت
            apple_Position = a + apple;
            // s ده اول البيت ان لو التفاحة وصلتله تبقي وقعت عليه
            // t اخر البيت نفس الكلام
            // التفاحه مثلا 8 بين 7 و 11 كده عليا لبيت
            if (apple_Position >= s && apple_Position <= t)
            {
                // التفاحه كده نزلت علي البيت
                apple_Count_In_Position += 1;
            }

        }
        // اطبع عدد التفاح اللى نزل 
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
