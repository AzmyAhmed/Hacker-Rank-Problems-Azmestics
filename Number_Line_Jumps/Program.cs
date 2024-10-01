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
// بسم الله الرحمن الرحيم
// لينك المسألة
//https://www.hackerrank.com/challenges/kangaroo/problem?isFullScreen=true
// الكنغرو
class Result
{


    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        //  هنركز علي المسافه ونقطة البداية مين هيبدأ الاول.
        // تاني حاجه هنركز علي السرعه مين اسرع من التاني
        // عندي حالتين هستبعدهم 
        // الكنغرو الاول عيبدأ قبل التاني بس التاني اسرع او يساوية في السرعة فمستحيل الكنغرو الاول يحصله
        // الكنغرو التاني اللى هيبدأ الاول بس الكنغرو الاول اسرع منه او يساويه فى السرعه فمستحيل يحصله
        //في كل الحالات الكنغرو التاني هيبدأ بعده الاول
        // السرعه هي اللى هتختلف لو الاول ابطأ او يساوي سرعة التاني مستحيل يحصله
        if ((x1 > x2 && v1 >= v2) || (x2 > x1 && v2 >= v1))
        {
            return "NO";
        }
        //(0,2,5,3)
        //--x2 - x1 = 5 - 0 = 5 فرق المسافه
        // v1 - v2 = 2 - 3 = -1 الكنغرو التاني اسرع
        // 5 % -1 ==0 المفروض هنا الشرط يتحقق بس اللوجيك بيقول لا لي لاني التاني اسرع
        // هيدخل علي اول شرط
        if ((x2 - x1) % (v1 - v2) == 0) // شرط انهم يتلاقوا فرق المسافه يقبل القسمه علي فرق السرعه بمعني ناتج القسمة عدد صحيح عشان كده استخدمنا %
        {
            return "YES";
        }
        return "NO";






    }

}

class Solution
{
    public static void Main(string[] args)
    {
         //(0,2,5,3)
        //x1 = 0 (موقع الكنغرو الأول)
       //v1 = 2(سرعة الكنغرو الأول) 
      //x2 = 5(موقع الكنغرو الثاني)
     //v2 = 3(سرعة الكنغرو الثاني)

        // اختبر بالارقام اللى انتي عايزها 
        string[] firstMultipleInput = new string[] { "0", "3", "4", "2" };

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}
