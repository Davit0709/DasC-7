using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки A (x,y,z):");
        double[] a = ReadPoint();

        Console.WriteLine("Введите координаты точки B (x,y,z):");
        double[] b = ReadPoint();

        double distance = CalculateDistance(a, b);

        Console.WriteLine($"Расстояние между точками A и B: {distance:f2}");
    }

    static double[] ReadPoint()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("z = ");
        double z = double.Parse(Console.ReadLine());

        return new double[] { x, y, z };
    }

    static double CalculateDistance(double[] a, double[] b)
    {
        double dx = b[0] - a[0];
        double dy = b[1] - a[1];
        double dz = b[2] - a[2];

        double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);

        return distance;
    }
}
