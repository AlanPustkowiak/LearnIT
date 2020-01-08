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

class Solution {

    // Complete the aVeryBigSum function below.
    static long aVeryBigSum(long[] ar, int size) {
        long Sum;
        for (int i = 0; i < size; i++)
        {
            Sum += ar[i];

        }
        System.Console.WriteLine(Sum);
        


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        ;
        long result = aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

/*

    Oblicz i wydrukuj sumę elementów w tablicy, pamiętając, że niektóre z tych liczb całkowitych mogą być dość duże.
    
    Wejście
        Pierwszy wiersz wejścia zawiera liczbę całkowitą.
        Następny wiersz zawiera oddzielone spacjami liczby całkowite zawarte w tablicy.

    Wyjście
        Suma liczb z tablicy.

    Warunki
        1 <= n <= 10
        0 <= ar[i] <= 10^10

    Przykład
    
    Wejście
        5
        1000000001 1000000002 1000000003 1000000004 1000000005
    Wyjście
        5000000015


    Testy:
        {wejście}
         = 
        {wyjście}
    
        5
        1000000001 1000000002 1000000003 1000000004 1000000005
         =
        5000000015


    Podpowiedź:
        https://docs.microsoft.com/pl-pl/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

*/