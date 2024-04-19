using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three integers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (IsInRange(num1))
        {
            Console.WriteLine(num1 + " belongs to the interval [0;8.1]");
        }
        if (IsInRange(num2))
        {
            Console.WriteLine(num2 + " belongs to the interval [0;8.1]");
        }
        if (IsInRange(num3))
        {
            Console.WriteLine(num3 + " belongs to the interval [0;8.1]");
        }

        Console.ReadLine();
    }

    static bool IsInRange(int number)
    {
        return number >= 0 && number <= 8.1;
    }
}
