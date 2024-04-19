using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the first side of the triangle:");
        double side1 = GetPositiveDouble();

        Console.WriteLine("Enter the length of the second side of the triangle:");
        double side2 = GetPositiveDouble();

        Console.WriteLine("Enter the length of the third side of the triangle:");
        double side3 = GetPositiveDouble();

        if (IsTriangle(side1, side2, side3))
        {
            double perimeter = side1 + side2 + side3;
            double halfPerimeter = perimeter / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));

            Console.WriteLine($"Perimeter of the triangle: {perimeter}");
            Console.WriteLine($"Area of the triangle: {area}");

            if (IsEquilateral(side1, side2, side3))
                Console.WriteLine("This is an equilateral triangle.");
            else if (IsIsosceles(side1, side2, side3))
                Console.WriteLine("This is an isosceles triangle.");
            else
                Console.WriteLine("This is a scalene triangle.");
        }
        else
        {
            Console.WriteLine("A triangle with such sides does not exist.");
        }
    }

    static double GetPositiveDouble()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Please enter a positive number:");
        }
        return number;
    }

    static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static bool IsEquilateral(double a, double b, double c)
    {
        return a == b && b == c;
    }

    static bool IsIsosceles(double a, double b, double c)
    {
        return a == b || a == c || b == c;
    }
}
