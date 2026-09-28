using System;
using BibliotecaMatriz;

class Program
{
       static void mostrarDiagonalPrincipal(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        Console.WriteLine("\n--- Diagonal Principal ---");
 
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{matriz[i, i]} ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int n = 5;
        int[,] matriz = new int[n, n];
        Console.WriteLine("Matrizes carregadas");
        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);
        mostrarDiagonalPrincipal(matriz);

        Console.ReadKey();
    }
}