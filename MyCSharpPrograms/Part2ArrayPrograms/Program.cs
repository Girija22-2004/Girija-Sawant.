using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine(" ***ARRAY AND MATRIX*** ");
        Console.WriteLine("Choose program following programs :- ");
        Console.WriteLine();
        Console.WriteLine("1. Read and Print Array (Recursion)");
        Console.WriteLine("2. Print Negative Elements");
        Console.WriteLine("3. Sum of Array Elements (Recursion)");
        Console.WriteLine("4. Max and Min (Recursion)");
        Console.WriteLine("5. Second Largest Element");
        Console.WriteLine("6. Count Even and Odd Elements");
        Console.WriteLine("7. Count Negative Elements");
        Console.WriteLine("8. Copy Array");
        Console.WriteLine("9. Insert Element");
        Console.WriteLine("10. Delete Element at Position");
        Console.WriteLine("11. Frequency of Each Element");
        Console.WriteLine("12. Print Unique Elements");
        Console.WriteLine("13. Count Duplicate Elements");
        Console.WriteLine("14. Delete Duplicate Elements");
        Console.WriteLine("15. Merge Two Arrays");
        Console.WriteLine("16. Reverse Array");
        Console.WriteLine("17. Separate Even and Odd");
        Console.WriteLine("18. Search Element");
        Console.WriteLine("19. Sort Array");
        Console.WriteLine("20. Sort Even and Odd Separately");
        Console.WriteLine("21. Left Rotate Array");
        Console.WriteLine("22. Right Rotate Array");
        Console.WriteLine("23. Add Two Matrices");
        Console.WriteLine("24. Subtract Two Matrices");
        Console.WriteLine("25. Multiply Two Matrices");
        Console.WriteLine("26. Check Matrix Equality");
        Console.WriteLine();

        int choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1:
                ReadPrintArray(); 
                  break;
            case 2:
                PrintNegative(); 
                  break;
            case 3: 
                SumArray(); 
                  break;
            case 4:
                MaxMinArray(); 
                  break;
            case 5: 
                SecondLargest(); 
                 break;
            case 6: 
                CountEvenOdd();
                  break;
            case 7: 
                CountNegative(); 
                 break;
            case 8: 
                CopyArray();
                  break;
            case 9: 
                InsertElement();
                  break;
            case 10: 
                DeleteElement();
                  break;
            case 11:  
                Frequency(); 
                 break;
            case 12: 
                UniqueElements();
                  break;
            case 13: 
                CountDuplicates();
                  break;
            case 14:
                RemoveDuplicates(); 
                 break;
            case 15: 
                MergeArrays(); 
                 break;
            case 16: 
                ReverseArray();
                  break;
            case 17: 
                SeparateEvenOdd(); 
                 break;
            case 18: 
                SearchElement(); 
                 break;
            case 19: 
                SortArray(); 
                 break;
            case 20: 
                SortEvenOddSeparately(); 
                 break;
            case 21: 
                LeftRotate(); 
                 break;
            case 22: 
                RightRotate(); 
                 break;
            case 23: 
                AddMatrices(); 
                 break;
            case 24: 
                SubtractMatrices(); 
                 break;
            case 25: 
                MultiplyMatrices();
                  break;
            case 26:
                MatrixEquality(); 
                 break;
            default: 
                 Console.WriteLine("Invalid Choice"); break;
        }
    }

    // ARRAY FUNCTIONS 

    static int[] ReadArray(out int n)
    {
        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine()!);
        int[] arr = new int[n];
        ReadArrayRec(arr, 0);
        return arr;
    }

    static void ReadArrayRec(int[] arr, int i)
    {
        if (i == arr.Length) return;
        Console.Write($"Element {i}: ");
        arr[i] = int.Parse(Console.ReadLine()!);
        ReadArrayRec(arr, i + 1);
    }

    static void PrintArrayRec(int[] arr, int i)
    {
        if (i == arr.Length) return;
        Console.Write(arr[i] + " ");
        PrintArrayRec(arr, i + 1);
    }

    static void ReadPrintArray()
    {
        int n;
        int[] arr = ReadArray(out n);
        Console.WriteLine("Array elements:");
        PrintArrayRec(arr, 0);
    }

    static void PrintNegative()
    {
        int n; int[] arr = ReadArray(out n);
        Console.WriteLine("Negative elements:");
        foreach (int x in arr)
            if (x < 0) Console.Write(x + " ");
    }

    static void SumArray()
    {
        int n; int[] arr = ReadArray(out n);
        Console.WriteLine("Sum = " + SumRec(arr, 0));
    }
    static int SumRec(int[] arr, int i)
    {
        if (i == arr.Length) return 0;
        return arr[i] + SumRec(arr, i + 1);
    }

    static void MaxMinArray()
    {
        int n; int[] arr = ReadArray(out n);
        Console.WriteLine("Max = " + MaxRec(arr, 0, arr[0]));
        Console.WriteLine("Min = " + MinRec(arr, 0, arr[0]));
    }
    static int MaxRec(int[] arr, int i, int max)
    {
        if (i == arr.Length) return max;
        return MaxRec(arr, i + 1, arr[i] > max ? arr[i] : max);
    }
    static int MinRec(int[] arr, int i, int min)
    {
        if (i == arr.Length) return min;
        return MinRec(arr, i + 1, arr[i] < min ? arr[i] : min);
    }

    static void SecondLargest()
    {
        int n; int[] arr = ReadArray(out n);
        Array.Sort(arr);
        Console.WriteLine("Second Largest = " + arr[n - 2]);
    }

    static void CountEvenOdd()
    {
        int n; int[] arr = ReadArray(out n);
        int even = 0, odd = 0;
        foreach (int x in arr)
            if (x % 2 == 0) even++; else odd++;
        Console.WriteLine("Even = " + even);
        Console.WriteLine("Odd = " + odd);
    }

    static void CountNegative()
    {
        int n; int[] arr = ReadArray(out n);
        int count = 0;
        foreach (int x in arr)
            if (x < 0) count++;
        Console.WriteLine("Negative count = " + count);
    }

    static void CopyArray()
    {
        int n; int[] arr = ReadArray(out n);
        int[] copy = new int[n];
        Array.Copy(arr, copy, n);
        Console.WriteLine("Copied array:");
        PrintArrayRec(copy, 0);
    }

    static void InsertElement()
    {
        int n; int[] arr = ReadArray(out n);
        Console.Write("Enter position: ");
        int pos = int.Parse(Console.ReadLine()!);
        Console.Write("Enter value: ");
        int val = int.Parse(Console.ReadLine()!);

        int[] newArr = new int[n + 1];
        for (int i = 0, j = 0; i < newArr.Length; i++)
            newArr[i] = (i == pos) ? val : arr[j++];
        PrintArrayRec(newArr, 0);
    }

    static void DeleteElement()
    {
        int n; int[] arr = ReadArray(out n);
        Console.Write("Enter position: ");
        int pos = int.Parse(Console.ReadLine()!);

        for (int i = pos; i < n - 1; i++)
            arr[i] = arr[i + 1];

        PrintArrayRec(arr, 0);
    }

    static void Frequency()
    {
        int n; int[] arr = ReadArray(out n);
        for (int i = 0; i < n; i++)
        {
            int count = 1;
            if (arr[i] == -999) continue;
            for (int j = i + 1; j < n; j++)
                if (arr[i] == arr[j]) { count++; arr[j] = -999; }
            Console.WriteLine(arr[i] + " -> " + count);
        }
    }

    static void UniqueElements()
    {
        int n; int[] arr = ReadArray(out n);
        Console.WriteLine("Unique elements:");
        for (int i = 0; i < n; i++)
        {
            bool unique = true;
            for (int j = 0; j < n; j++)
                if (i != j && arr[i] == arr[j]) unique = false;
            if (unique) Console.Write(arr[i] + " ");
        }
    }

    static void CountDuplicates()
    {
        int n; int[] arr = ReadArray(out n);
        int count = 0;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (arr[i] == arr[j]) { count++; break; }
        Console.WriteLine("Duplicate count = " + count);
    }

    static void RemoveDuplicates()
    {
        int n; int[] arr = ReadArray(out n);
        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < n; i++)
        {
            bool dup = false;
            for (int j = 0; j < i; j++)
                if (arr[i] == arr[j]) dup = true;
            if (!dup) Console.Write(arr[i] + " ");
        }
    }

    static void MergeArrays()
    {
        int n1, n2;
        Console.WriteLine("First array:");
        int[] a = ReadArray(out n1);
        Console.WriteLine("Second array:");
        int[] b = ReadArray(out n2);

        int[] c = new int[n1 + n2];
        a.CopyTo(c, 0);
        b.CopyTo(c, n1);
        PrintArrayRec(c, 0);
    }

    static void ReverseArray()
    {
        int n; int[] arr = ReadArray(out n);
        Array.Reverse(arr);
        PrintArrayRec(arr, 0);
    }

    static void SeparateEvenOdd()
    {
        int n; int[] arr = ReadArray(out n);
        Console.WriteLine("Even:");
        foreach (int x in arr) if (x % 2 == 0) Console.Write(x + " ");
        Console.WriteLine("\nOdd:");
        foreach (int x in arr) if (x % 2 != 0) Console.Write(x + " ");
    }

    static void SearchElement()
    {
        int n; int[] arr = ReadArray(out n);
        Console.Write("Enter element to search: ");
        int key = int.Parse(Console.ReadLine()!);
        Console.WriteLine(Array.IndexOf(arr, key) >= 0 ? "Found" : "Not Found");
    }

    static void SortArray()
    {
        int n; int[] arr = ReadArray(out n);
        Array.Sort(arr);
        PrintArrayRec(arr, 0);
    }

    static void SortEvenOddSeparately()
    {
        int n; int[] arr = ReadArray(out n);
        Array.Sort(arr);
        Console.WriteLine("Even:");
        foreach (int x in arr) if (x % 2 == 0) Console.Write(x + " ");
        Console.WriteLine("\nOdd:");
        foreach (int x in arr) if (x % 2 != 0) Console.Write(x + " ");
    }

    static void LeftRotate()
    {
        int n; int[] arr = ReadArray(out n);
        int first = arr[0];
        for (int i = 0; i < n - 1; i++) arr[i] = arr[i + 1];
        arr[n - 1] = first;
        PrintArrayRec(arr, 0);
    }

    static void RightRotate()
    {
        int n; int[] arr = ReadArray(out n);
        int last = arr[n - 1];
        for (int i = n - 1; i > 0; i--) arr[i] = arr[i - 1];
        arr[0] = last;
        PrintArrayRec(arr, 0);
    }

    // MATRIX FUNCTIONS 

    static void AddMatrices()
    {
        int[,] a = ReadMatrix();
        int[,] b = ReadMatrix();
        int r = a.GetLength(0), c = a.GetLength(1);
        Console.WriteLine("Result:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
                Console.Write(a[i, j] + b[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void SubtractMatrices()
    {
        int[,] a = ReadMatrix();
        int[,] b = ReadMatrix();
        int r = a.GetLength(0), c = a.GetLength(1);
        Console.WriteLine("Result:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
                Console.Write(a[i, j] - b[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void MultiplyMatrices()
    {
        int[,] a = ReadMatrix();
        int[,] b = ReadMatrix();
        int r = a.GetLength(0), c = b.GetLength(1), k = a.GetLength(1);
        int[,] res = new int[r, c];

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                for (int x = 0; x < k; x++)
                    res[i, j] += a[i, x] * b[x, j];

        Console.WriteLine("Result:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
                Console.Write(res[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void MatrixEquality()
    {
        int[,] a = ReadMatrix();
        int[,] b = ReadMatrix();
        bool equal = true;

        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                if (a[i, j] != b[i, j]) equal = false;

        Console.WriteLine(equal ? "Matrices are Equal" : "Matrices are Not Equal");
    }

    static int[,] ReadMatrix()
    {
        Console.Write("Enter rows: ");
        int r = int.Parse(Console.ReadLine()!);
        Console.Write("Enter columns: ");
        int c = int.Parse(Console.ReadLine()!);
        int[,] m = new int[r, c];

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine()!);
            }
        return m;
    }
}
