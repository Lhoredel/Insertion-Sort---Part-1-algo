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

    /*
     * Complete the 'insertionSort1' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort1(int n, List<int> arr)
    {
        int valueToInsert = arr[n - 1];
        int position = n - 2;
        while (position >= 0 && arr[position] > valueToInsert
        {
            
        arr[position + 1] = arr[position];
        position--;
        Console.WriteLine(string.Join(" ", arr));
    }
    
    arr[position + 1] = valueToInsert;
    Console.WriteLine(string.Join(" ", arr));
}

    }



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}
