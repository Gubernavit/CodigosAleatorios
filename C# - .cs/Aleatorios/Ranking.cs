using System;

public class Program1
{
    public static void Main()
    {
        int[] ranking = new int[5] { 2, 5, 1, 3, 4 };
        int aux;

        void ExibirRanking()
        {
            for (int x = 0; x < ranking.Length; x++)
            {
                if(ranking.Length == x)
                {
                    Console.WriteLine();
                }
                Console.Write(ranking[x] + " ");
            }
            
        }
        
        Console.WriteLine("Ranking inicial:");
        ExibirRanking();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Ordenando ranking...");

        for (int i = 0; i < ranking.Length; i++)
        {
            for (int j = 0; j < ranking.Length; j++)
            {
                if (ranking[j] > ranking[i])
                {
                    aux = ranking[j];
                    ranking[j] = ranking[i];
                    ranking[i] = aux;

                    ExibirRanking();
                    Console.WriteLine();
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Ranking ordenado:");
        ExibirRanking();
    }
}
