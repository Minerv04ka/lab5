//Var 6
using System;

public class Cube
{
    private double sideLength;

    public double SideLength
    {
        get { return sideLength; }
        set
        {
            if (value >= 0)
                sideLength = value;
        }
    }

    public double CalculateVolume()
    {
        return sideLength * sideLength * sideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cube cube = new Cube();

        double side;
        Console.WriteLine("Введіть довжину ребра куба: ");

        while (!double.TryParse(Console.ReadLine(), out side) || side < 0)
        {
            Console.WriteLine("Введено некоректне значення. Введіть будь ласка додатнє число.");
            Console.Write("Введіть довжину ребра куба: ");
        }

        cube.SideLength = side;

        Console.WriteLine($"Об'єм куба з ребром {cube.SideLength} дорівнює {cube.CalculateVolume():F2}");
    }
}
