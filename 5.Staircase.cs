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



    // Complete the staircase function below.
    static void staircase(int n) {
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("#");
            for (int j = 0; j < ; j++)
            {
                System.Console.WriteLine("#");
            }

        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}


/*

    
    Wejście
    A single integer n, denoting the size of the staircase.



    Wyjście
    Print a staircase of size n using # symbols and spaces.


    Warunki
    0 < n < 101

    Przykład
    Wejście
    6
    Wyjście
         #
        ##
       ###
      ####
     #####
    ######

*/