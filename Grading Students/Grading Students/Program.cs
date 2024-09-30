using System;
using System.Collections.Generic;

class Result
{
    // Azmestics
    //لينك المسألة
    //https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> finalGrades = new List<int>();

        foreach (int studentGrade in grades)
        {
            // من شروط المسألة القاعدة ببدأ اطبقها من بعد ل 38
            if (studentGrade >= 38)
            {
                // هقرب لاقرب رقم يقبل القسمة علي 5 بحيث يكون أكبر من درجة الطالب
                // مثال 73 هقسمها علي 5 يديني 14.6 هاخد الرقم الصحيح بس واضربه فى 5 يديني 75
                int nextMultipleOfFive = ((studentGrade / 5) + 1) * 5;

                // هتحقق من الشرط التاني لو ناتج الطرح اصغر من 3 حط النتيجه الجديده اللى هيا 75 لو لا سيب نتيجه الطالب القديمة
                if (nextMultipleOfFive - studentGrade < 3)
                {
                    finalGrades.Add(nextMultipleOfFive); // النتيجة الجديدة
                }
                else
                {
                    finalGrades.Add(studentGrade);// النتيجة القديمة
                }
            }
            else
            {
                finalGrades.Add(studentGrade); // لو الدرجه اقل من 38
            }
        }

        return finalGrades;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // درجات الطالب
        List<int> grades = new List<int> {73, 67, 38, 33 };

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine("New Grades:");
        foreach (int grade in result)
        {
            Console.WriteLine(grade);
        }
    }
}
