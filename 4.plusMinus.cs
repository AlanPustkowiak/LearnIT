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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr, byte size, int p,int m,int z) {
        for (int i = 0; i < size; i++)
        {
            if (arr[i]>0)
            {
                p++;
            }
            else if (arr[i]<0)
            {
                m++;
            }
            else if (arr[i]==0)
            {
                z++;
            }
        }
        System.Console.WriteLine(p / size);
        System.Console.WriteLine(m / size);
        System.Console.WriteLine(z / size);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}


/*
    Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.

    Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to 10^(-4) are acceptable.
    2/5 = 0.400000


    Wejście
    The first line contains an integer n, denoting the size of the array.
    The second line contains n space-separated integers describing an array of numbers arr(arr[0], arr[1], arr[2], ... , arr[n - 1]).

    Wyjście
    You must print the following 3 lines:

    A decimal representing of the fraction of positive numbers in the array compared to its size.
    A decimal representing of the fraction of negative numbers in the array compared to its size.
    A decimal representing of the fraction of zeros in the array compared to its size.

    Warunki
        0 < n < 100
        -100 <= arr[i] <= 100

    Przykład 
    Wejście
        6
        -4 3 -9 0 4 1    
    Wyjście
        0.500000
        0.333333
        0.166667


    Testy:
        {wejście}
         = 
        {wyjście}
    
    8
    1 2 3 -1 -2 -3 0 0
     =
    0.375000
    0.375000
    0.250000


    5
    0 4 -3 3 -6
     =
    0.400000
    0.400000
    0.200000


    72
    0 -67 -74 -38 -72 -53 0 -13 -95 -91 -100 -59 0 -10 -68 -71 -62 -21 0 -42 -57 -16 -66 -23 0 -80 -63 -68 -65 -71 0 -71 -15 -32 -26 -8 0 -6 -51 -87 -19 -71 0 -93 -26 -35 -56 -89 0 -21 -74 -39 -57 -8 0 -69 -29 -24 -99 -53 0 -65 -42 -72 -18 -4 0 -73 -46 -63 -78 -87
     =
    0.000000
    0.833333
    0.166667

    Podpowiedź:

*/