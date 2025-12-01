using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Solve 2x2 linear equations:");
        Console.WriteLine("Equation format: a1*x + b1*y = c1");
        Console.WriteLine("                 a2*x + b2*y = c2");

        Console.Write("Enter a1: "); double a1 = double.Parse(Console.ReadLine());
        Console.Write("Enter b1: "); double b1 = double.Parse(Console.ReadLine());
        Console.Write("Enter c1: "); double c1 = double.Parse(Console.ReadLine());
        Console.Write("Enter a2: "); double a2 = double.Parse(Console.ReadLine());
        Console.Write("Enter b2: "); double b2 = double.Parse(Console.ReadLine());
        Console.Write("Enter c2: "); double c2 = double.Parse(Console.ReadLine());

    
        double[,] A = { { a1, b1 }, { a2, b2 } };
        double[] C = { c1, c2 };

 
        double det = a1 * b2 - a2 * b1;

        if(det == 0)
        {
            Console.WriteLine("No unique solution exists (Determinant = 0).");
            return;
        }

   
        double[,] invA = {
            { b2 / det, -b1 / det },
            { -a2 / det, a1 / det }
        };

        double x = invA[0,0]*C[0] + invA[0,1]*C[1];
        double y = invA[1,0]*C[0] + invA[1,1]*C[1];

        Console.WriteLine($"Solution: x = {x}, y = {y}");
    }
}
