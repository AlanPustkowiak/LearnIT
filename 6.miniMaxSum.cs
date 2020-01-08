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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr,uint max,uint min,uint sum) {
        for (int i = 0; i < 5; i++)
        {
            max = arr[0];
            min = arr[0];
            if (min>arr[i])
            {
                min = arr[i];
            }
            else if (min<arr[i] && max<arr[i])
            {
                max = arr[i];
            }
            sum += arr[i];
            System.Console.WriteLine(sum - max);
            System.Console.WriteLine(sum - min);

        }


    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}


/*
    Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
    Then print the respective minimum and maximum values as a single line of two space-separated long integers.
    
    Wejście
    A single line of five space-separated integers.


    Wyjście
    Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. 
    (The output can be greater than a 32 bit integer.)


    Warunki
    1 <= arr[i] <= 10^9 

    Przykład
    
    Wejście
        1 2 3 4 5

    Wyjście
        10 14



    Testy:
        {wejście}
         = 
        {wyjście}
    
    140638725 436257910 953274816 734065819 362748590
     =
    1673711044 2486347135


    156873294 719583602 581240736 605827319 895647130
     =
    2063524951 2802298787


    539674108 549382170 270968351 746219035 140597628
     =
    1500622257 2106243664


    Podpowiedź:

*/