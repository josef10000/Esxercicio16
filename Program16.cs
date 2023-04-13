using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[10];
        int[] Y = new int[10];

        Console.WriteLine("Digite os valores do vetor X:");
        for (int i = 0; i < 10; i++)
            X[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os valores do vetor Y:");
        for (int i = 0; i < 10; i++)
            Y[i] = int.Parse(Console.ReadLine());

        int[] uniao = X.Concat(Y).Distinct().ToArray();
        int[] diferenca = X.Except(Y).ToArray();
        int[] intersecao = X.Intersect(Y).ToArray();

        Console.WriteLine($"\nVetor X: {string.Join(" ", X)}");
        Console.WriteLine($"Vetor Y: {string.Join(" ", Y)}");
        Console.WriteLine($"Vetor de união: {string.Join(" ", uniao)}");
        Console.WriteLine($"Vetor de diferença: {string.Join(" ", diferenca)}");
        Console.WriteLine($"Vetor de interseção: {string.Join(" ", intersecao)}");
    }
}
