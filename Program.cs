using System;
using System.Collections.Generic;
using System.Text;

namespace SomaGrafos1
{
    class Program
    {
        static void soma()
        {
            int vertices1, vertices2, vertices3; // declara��o das variaveis de vertices
            Console.WriteLine("Informe o número de vértices do primeiro grafo");
            vertices1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de vértices do segundo grafo");

            vertices2 = int.Parse(Console.ReadLine());
            vertices3= vertices1+vertices2;

            int[,] grafo1 = new int[vertices1, vertices1]; // matrizes de adjacencias
            int[,] grafo2 = new int[vertices2, vertices2];
            int [,] grafosoma = new int [vertices3,vertices3];
            Console.WriteLine("Informe as adjacencias para o grafo 1. Informe 1 para grafo adjacente, 0 para n�o adjacente");
            
            for (int i=0; i<vertices1;i++) // receber e armazenar as adjacencias do grafo 1
            {
                for (int j = 0; j < vertices1; j++)
                {
                    Console.WriteLine("Vértice " +i+ " com vértice " +j+ ":");
                    int aux = int.Parse(Console.ReadLine());
                    while(aux !=0 && aux != 1)
                    {
                        Console.WriteLine("Digite apenas 0 ou 1!");
                        aux = int.Parse(Console.ReadLine());
                    }
                    grafo1[i,j]=aux;
                }
            }


            Console.WriteLine("Informe as adjacencias para o grafo 2. Informe 1 para grafo adjacente, 0 para n�o adjacente");

            for (int i=0; i<vertices2;i++) // receber e armazenar as adjacencias do grafo 2
            {
                for (int j = 0; j < vertices2; j++)
                {
                    Console.WriteLine("Vértice " +i+ " com vértice " +j+ ":");
                    int aux = int.Parse(Console.ReadLine());
                    while(aux !=0 && aux != 1)
                    {
                        Console.WriteLine("Digite apenas 0 ou 1!");
                        aux = int.Parse(Console.ReadLine());
                    }
                    grafo2[i,j]=aux;
                }
            }
            for (int i = 0; i < vertices1; i++) // efeua a soma das matrizes adjacentes para adicionar o grafo 1
            {
                for(int j=0; j<vertices1;j++)
                {
                    grafosoma[i, j] = grafo1[i, j];
                }
            }

            for (int i = 0; i < vertices2; i++) // efeua a soma das matrizes adjacentes para adicionar o grafo 2
            {
                for (int j = 0; j < vertices2; j++)
                {
                    grafosoma[i + vertices1, j + vertices1] = grafo2[i, j];
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < vertices3; i++) // imprime a matriz de resultado
            {
                for (int j = 0; j < vertices3; j++)
                {
                    Console.Write(grafosoma[i, j] +"\t" );
                }
                Console.Write("\n");
            }

        }
        static void Main(string[] args)
        {
            soma();
            Console.ReadKey();
        }
    }
}
