using System;

class Point
{
    private int x;
    private int y;
    private string name;

    public Point(int x, int y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public int X => x;

    public int Y => y;

    public string Name => name;
}

class Figure
{
    private Point[] points;

    public Figure(Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
            throw new ArgumentException("A figure must have 3 to 5 points.");

        this.points = points;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }
        perimeter += LengthSide(points[points.Length - 1], points[0]); 
        Console.WriteLine($"Perimeter of {points.Length}-sided figure: {perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point[] points = new Point[4];
        points[0] = new Point(0, 0, "A");
        points[1] = new Point(0, 2, "B");
        points[2] = new Point(2, 2, "C");
        points[3] = new Point(2, 0, "D");

        Figure figure = new Figure(points);
        figure.PerimeterCalculator();
    }
}
