using System;

class Ex1002
{
    static void Main()
    {
        double raio,area, n;

         n = 3.14159;
        
         raio = double.Parse(Console.ReadLine());

         area = n * Math.Pow(raio, 2);

        Console.WriteLine($"A={area:F4}");

    }
}
