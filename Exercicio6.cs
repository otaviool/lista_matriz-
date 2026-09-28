using System;
using BibliotecaMatriz;

class Program
{
   static void SomarMatrizes(double[,] m1, double[,] m2)
    {
        int linhas = m1.GetLength(0);
        int cols = m1.GetLength(1);
        double[,] resultado = new double[linhas, cols];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultado[i, j] = m1[i, j] + m2[i, j];
            }
        }
        ImprimirMatriz(resultado);
    }
	
	static void SubtrairMatrizes(double[,] m2, double[,] m1)
    {
        int linhas = m1.GetLength(0);
        int cols = m1.GetLength(1);
        double[,] resultado = new double[linhas, cols];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultado[i, j] = m2[i, j] - m1[i, j];
            }
        }
        ImprimirMatriz(resultado);
    }
	
	static void ImprimirMatriz(double[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matriz[i, j],10:F2}");
            }
            Console.WriteLine();
        }
    }
	static void AdicionarConstantes(double [,] matriz , double constante)
	{
		int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matriz[i, j] += constante;
            }
        }
	}

    static void Main()
    {
        int n = 4; 
        int m = 4;
        int[,] matriz = new int[n, m];
        Console.WriteLine("Matrizes carregadas");
        Matriz.gerarMatriz(matriz);
		SomarMatrizes(matriz);
		AdicionarConstantes(matriz);
	    SubtrairMatrizes(matriz);
		ImprimirMatriz(matriz);
        Console.ReadKey();
    }
}