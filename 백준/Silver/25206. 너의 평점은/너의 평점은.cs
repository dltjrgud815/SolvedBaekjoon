using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = 20;
        float[] score = new float[N];
        string[] grade = new string[N];
        string[] classTitle = new string[N];
        float totalCount = 0f;
        float sumOfGrade = 0f;

        for(int i = 0; i < N; i++)
        {
            var tempCor = Console.ReadLine().Split(" ");
            if(tempCor[2] != "P")
            {
                classTitle[i] = tempCor[0];
                score[i] = float.Parse(tempCor[1]);
                grade[i] = tempCor[2];
                totalCount += score[i];
                sumOfGrade += ConvertGradeToScore(grade[i]) * score[i];
            }
        }
        System.Console.WriteLine(sumOfGrade / totalCount);  
    }

    private static float ConvertGradeToScore(string grade)
    {
        switch (grade)
        {
            case "A+":
                return 4.5f;

            case "A0":
                return 4.0f;
            
            case "B+":
                return 3.5f;

            case "B0":
                return 3.0f;

            case "C+":
                return 2.5f;

            case "C0":
                return 2.0f;

            case "D+":
                return 1.5f;

            case "D0":
                return 1.0f;

            case "F":
                return 0.0f;

            default:
                return 0.0f;
        }
    }
}