using System;

class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[17];
        int[] Y;
        int M;

        Random rnd = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = rnd.Next(-100, 101);
        }

        Console.WriteLine("Enter the value of M:");
        M = int.Parse(Console.ReadLine());

        int count = 0;
        foreach (int num in X)
        {
            if (Math.Abs(num) > M)
                count++;
        }

        Y = new int[count];
        int index = 0;
        foreach (int num in X)
        {
            if (Math.Abs(num) > M)
            {
                Y[index] = num;
                index++;
            }
        }

        Console.WriteLine("M: " + M);
        Console.WriteLine("Array X:");
        foreach (int num in X)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\nArray Y:");
        foreach (int num in Y)
        {
            Console.Write(num + " ");
        }
    }
}
