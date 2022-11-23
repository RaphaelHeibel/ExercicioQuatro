using System.Numerics;

namespace ExercicioQuatro
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] v = {5,3,2,4,7,1,0,6};

            var sort = bubbleSort(v);

            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] bubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }
    }
}