namespace FundamentalUpskilling.OOP.Abstraction;

/*
 * Abstraction : hanya dapat berisi method kosong, atau atribut dan juga constructor yang akan diturunkan ke child, dan sifatnya wajib di overide
 */
public abstract class Shape
{
    public abstract double GetSurface();
    public abstract double GetAround();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Length { get; set; }

    public override double GetSurface()
    {
        return Width * Length;
    }

    public override double GetAround()
    {
        return 2 * (Width * Length);
    }
}

public class Triangle : Shape
{
    public int Base { get; set; }
    public int Height { get; set; }
    public int PrismHeight { get; set; }
    public override double GetSurface()
    {
        return 0.5 * (Base * Height);
    }

    public override double GetAround()
    {
        return 0.5 * (Base * Height) * PrismHeight;
    }
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         var triangle = new Triangle
//         {
//             Base = 6,
//             Height = 9,
//             PrismHeight = 10
//         };
//         Console.WriteLine(triangle.GetSurface());
//         Console.WriteLine(triangle.GetAround());
//
//         var rectangle = new Rectangle
//         {
//             Width = 10,
//             Length = 15
//         };
//
//         Console.WriteLine(rectangle.GetSurface());
//         Console.WriteLine(rectangle.GetAround());
//     }
// }