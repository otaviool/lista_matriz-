using System;
using BibliotecaMatriz;

class Program
{
    static int contarMatriz(int[,] matriz, int x)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int cont = 0;
        
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            { 
                if (matriz[i, j] == x)
                {
                    cont++;
                }
            }
        }
        return cont;
    }

    static void Main()
    {
        int n = 4; 
        int m = 4;
        
        int[,] matriz = new int[n, m];
        
        Console.WriteLine("Matrizes carregadas");
        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);
        Console.Write("\nDigite o número que deseja contar na matriz: ");
        int x = int.Parse(Console.ReadLine());
int totalOcorrencias = contarMatriz(matriz, x);
        Console.WriteLine($"O número {x} aparece {totalOcorrencias} vez(es) na matriz.");

        Console.ReadKey();
    }
}