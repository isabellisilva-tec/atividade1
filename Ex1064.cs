using System;
class Ex1064
{
    static void Main()
    {
        double x, soma = 0, media;
        int cont = 0;
          for(int i = 1;i <= 6; i++)
          {
            Console.WriteLine("digite um numero: ");
            x = double.Parse(Console.ReadLine());

                  if(x > 0)
                  { 
                   cont++;
                soma = soma + x; 
                                 
                  }
          }
        media = soma / cont;
        Console.WriteLine($"{cont} valores positivos");
        Console.WriteLine($"{media:F1}");
        Console.ReadKey();
    }
}
