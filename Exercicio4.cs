using System;
using BibliotecaMatriz;

class Program
{
      static void mostrarDiagonalSecundaria(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        Console.WriteLine("\n--- Diagonal Secundária ---");
        
        for (int i = 0; i < n; i++)
        {
        
            Console.Write($"{matriz[i, n - 1 - i]} ");
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
        mostrarDiagonalSecundaria(matriz);

        Console.ReadKey();
    }
}