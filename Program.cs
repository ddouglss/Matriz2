using System; // Importa funcionalidades básicas como leitura e escrita no console
using System.Globalization;
using System.Collections.Generic;

namespace Matriz {
    class Program {

        static void Main(string[] args) {

            // Lê a primeira linha de entrada e divide pelos espaços, pegando a quantidade de linhas (m) e colunas (n)
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]); // Define a quantidade de linhas da matriz
            int n = int.Parse(line[1]); // Define a quantidade de colunas da matriz

            // Declara uma matriz de inteiros com m linhas e n colunas
            int[,] mat = new int[m, n];

            // Lê os valores para preencher a matriz
            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' '); // Lê uma linha e divide em valores
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]); // Converte cada valor para int e armazena na matriz
                }
            }

            // Lê o valor que queremos encontrar na matriz
            int x = int.Parse(Console.ReadLine());

            // Procura pelo valor x na matriz e exibe suas posições adjacentes
            for (int i = 0; i < m; i++) { // Percorre cada linha
                for (int j = 0; j < n; j++) { // Percorre cada coluna
                    if (mat[i, j] == x) { // Verifica se o valor na posição [i, j] é igual a x
                        Console.WriteLine("Position " + i + "," + j + ":"); // Imprime a posição onde x foi encontrado

                        // Exibe o valor à esquerda, se existir (ou seja, se não estiver na primeira coluna)
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }

                        // Exibe o valor acima, se existir (ou seja, se não estiver na primeira linha)
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        // Exibe o valor à direita, se existir (ou seja, se não estiver na última coluna)
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }

                        // Exibe o valor abaixo, se existir (ou seja, se não estiver na última linha)
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
