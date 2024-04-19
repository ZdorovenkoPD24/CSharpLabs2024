using System;

class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[17];

        Random rnd = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = rnd.Next(1, 100);
        }

        int min = X[0];
        int max = X[0];
        foreach (int num in X)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        Console.WriteLine("Array X:");
        foreach (int num in X)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\nMinimum value: " + min);
        Console.WriteLine("Maximum value: " + max);
    }
}
