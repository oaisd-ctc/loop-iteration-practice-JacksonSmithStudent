using System;

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
    static void ShowError(int n)
    {
        Console.WriteLine(n + " is out of range.");
    }
}