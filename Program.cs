﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);
        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);
        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);
        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);
        WriteEvensThrough100();
        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);
        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);
        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);
        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);
    }
    static void Write1ThroughN_While(int n)
    {
        if (n < 1)
        {
            ShowError(n);
            return;
        }
        int i = 1;
        while (i <= n)
        {
            Console.Write(i + " ");
            i++;
        }
        Console.WriteLine();
    }
     static void Write1ThroughN_For(int n)
    {
        if (n < 1)
        {
            ShowError(n);
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
     static void WriteNThrough1_While(int n)
    {
        if (n < 1)
        {
            ShowError(n);
            return;
        }
        while (n > 0)
        {
            Console.Write(n + " ");
            n--;
        }
        Console.WriteLine();
    }
    static void WriteNThrough1_For(int n)
    {
        if (n < 1)
        {
            ShowError(n);
            return;
        }
        for (int i = n; i > 0; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
     static void WriteEvensThrough100()
    {
        for (int i = 2; i <= 100; i += 1)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
     static void FindSum(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
        }
        else
        {
            for (int i = n; i <= 1; i++)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
    static void FindSumOfEvenNumbers(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }
        if (n > 0)
        {
            for (int i = 2; i <= n; i += 2)
            {
                sum += i;
            }
        }
        else
        {
            for (int i = n; i <= 1; i += 2)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
     static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }
        if (n > 0)
        {
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
        }
        else
        {
            for (int i = n; i <= -1; i += 2)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
    static void OutputRightTriangle(int baseLength)
    {
        if (baseLength == 0)
        {
            ShowError(baseLength);
            return;
        }
        if (baseLength > 0)
        {
            for (int i = 1; i <= baseLength; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = -baseLength; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    static void ShowError(int n)
    {
        Console.WriteLine(n + " is out of range.");
    }
}