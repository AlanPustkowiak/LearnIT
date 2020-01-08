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

    static List<int> compareTriplets(List<int> a, List<int> b) {
        // Not sure how to operate Lists
        byte z, z1;
        for (int i = 0; i <= a && b; i++)
        {
            if (a>b)
            {
                z++;
            }
            if (a<b)
            {
                z1++;
            }

        }
        System.Console.WriteLine(z, z1);


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}



/*
    ZADANIE:

    Alicja i Bartek stworzyli jeden problem dla LearnIT. Recenzent ocenia dwa wyzwania, przyznając punkty w skali od 1 do 100 dla trzech kategorii: jasność problemu, oryginalność i trudność.

    Określamy ocenę wyzwania Alicji jako trójka a = (a[0], a[1], a[2]), a ocenę wyzwania Bartka - b = (b[0], b[1], b[2]).

    Twoim zadaniem jest znalezienie ich punktów porównawczych poprzez porównanie z, z i z.

    Jeśli, a[i] > b[i] to Alicja otrzymuje punkt.
    Jeśli, a[i] < b[i] to Bartek otrzymuje punkt.
    Jeśli, a[i] = b[i] to żadna osoba nie otrzyma punktu.

    Punkty porównania to suma punktów, które osoba zarobiła.

    compareTriplets ma następujące parametry:
        a: tablica liczb całkowitych reprezentujących ocenę wyzwania Alicja
        b: tablica liczb całkowitych reprezentujących ocenę wyzwania Bartek

    Wejście:
        Pierwszy wiersz zawiera 3 oddzielone spacjami liczby całkowite opisujące odpowiednie wartości w trójce a.
        Drugi wiersz zawiera 3 oddzielone spacjami liczby całkowite opisujące odpowiednie wartości w trójce b.


    Warunki:
        1 <= a[i] <= 100
        1 <= b[i] <= 100

    Wyjście
        Zwraca tablicę dwóch liczb całkowitych oznaczających odpowiednie punkty porównania zarobione przez Alicje i Bartka.

    Przykład

    Wejście

        5 6 7
        3 6 10

    Wyjście

        1 1



    Testy:
        {wejście}
         = 
        {wyjście}

        5 6 7
        3 6 10
         =
        1 1

        6 2 100
        5 2 70
         = 
        2 1

        22 11 24
        24 15 18
         = 
        1 2

        17 28 30
        99 16 8
         = 
        2 1

        99 16 8
        99 16 8
         = 
        0 0
        


*/