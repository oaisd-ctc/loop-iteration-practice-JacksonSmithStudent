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
   