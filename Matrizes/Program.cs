using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int Linha = 0; Linha < n; Linha++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int coluna = 0; coluna < n; coluna++)
                {
                    matriz[Linha, coluna] = int.Parse(values[coluna]);
                }
            }

            Console.WriteLine(" ");

            Console.Write("Valor diagonal da matriz: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i]+ " ");
            }

            Console.WriteLine("\n");

            int contador = 0;

            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < n; coluna++)
                {
                    if(matriz[linha, coluna] < 0)
                    {
                        contador++;
                    }
                }
            }

            Console.Write("Quantidade de numeros negativos na matriz: "+ contador);
            
            Console.ReadKey();
        }
    }
}
