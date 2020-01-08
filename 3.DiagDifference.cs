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
    public static int diagonalDifference(List<List<int>> arr)
    {
        // Don't know how to operate on Lists :P
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


/*
    Biorąc pod uwagę macierz kwadratową, oblicz bezwzględną różnicę między sumami jej przekątnych.
    
    Na przykład macierz kwadratowa arr wygląda tak:
    1 2 3
    4 5 6
    9 8 9 

    Przekątna od lewej do prawej = 15. Przekątna od prawej do lewej = 17. Ich |rónica| to |15 - 17| = 2.

    Wejście
    Pierwszy wiersz zawiera jedną liczbę całkowitą, liczbę wierszy i kolumn w macierzy.
    Każdy z kolejnych n wierszy opisuje wiersz arr[i] i składa się z liczb całkowitych oddzielonych spacją arr[i][j].

    Wyjście
    Wypisz bezwzględną różnicę między sumami dwóch przekątnych macierzy jako pojedynczą liczbę całkowitą.

    Warunki
    -100 <= arr[i][j] <= 100

    Przykład

    Wejście
    3
    11 2 4
    4 5 6
    10 8 -12  

    Wyjście
    15


    Testy:
        {wejście}
         = 
        {wyjście}
    
    3
    1 1 1
    1 1 1
    1 1 1
     = 
    0

    2
    6 8
    -6 9
     =
    13

*/