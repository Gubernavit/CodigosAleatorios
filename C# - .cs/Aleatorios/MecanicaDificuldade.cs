using System;

class SistemaDificuldade
{
    static void Main(string[] args)
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("        SISTEMA DE DIFICULDADE");
            Console.WriteLine("==========================================");
            Console.WriteLine(" 1 - Fácil");
            Console.WriteLine(" 2 - Normal");
            Console.WriteLine(" 3 - Difícil");
            Console.WriteLine(" 4 - Pesadelo");
            Console.WriteLine(" 0 - Sair");
            Console.WriteLine("==========================================");
            Console.Write("Escolha uma opção: ");

            int escolha;
            bool entradaValida = int.TryParse(Console.ReadLine(), out escolha);

            if (!entradaValida)
            {
                Console.WriteLine("\nEntrada inválida!");
                Console.ReadLine();
                continue;
            }

            if (escolha == 0)
            {
                sair = true;
                continue;
            }

            string nomeDificuldade = "Normal";
            double multiplicadorDano = 1.0;
            double multiplicadorXP = 1.2;
            double multiplicadorOuro = 1.1;

            switch (escolha)
            {
                case 1:
                    nomeDificuldade = "Fácil";
                    multiplicadorDano = 0.75;
                    multiplicadorXP = 1.0;
                    multiplicadorOuro = 1.0;
                    break;

                case 2:
                    nomeDificuldade = "Normal";
                    break;

                case 3:
                    nomeDificuldade = "Difícil";
                    multiplicadorDano = 1.5;
                    multiplicadorXP = 1.5;
                    multiplicadorOuro = 1.3;
                    break;

                case 4:
                    nomeDificuldade = "Pesadelo";
                    multiplicadorDano = 2.0;
                    multiplicadorXP = 2.0;
                    multiplicadorOuro = 1.5;
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    Console.ReadLine();
                    continue;
            }

            Console.WriteLine("==========================================");
            Console.WriteLine($" DIFICULDADE SELECIONADA: {nomeDificuldade.ToUpper()}");
            Console.WriteLine("==========================================");
            Console.WriteLine($" Dano dos inimigos:      x{multiplicadorDano}");
            Console.WriteLine($" Experiência recebida:   x{multiplicadorXP}");
            Console.WriteLine($" Ouro recebido:          x{multiplicadorOuro}");
            Console.WriteLine("==========================================");

            double danoBase = 20;
            double xpBase = 100;
            double ouroBase = 50;

            Console.WriteLine("\n--- Exemplo Prático ---");
            Console.WriteLine($" Dano: {danoBase}  →  {danoBase * multiplicadorDano}");
            Console.WriteLine($" XP:   {xpBase}   →  {xpBase * multiplicadorXP}");
            Console.WriteLine($" Ouro: {ouroBase}  →  {ouroBase * multiplicadorOuro}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
        }

        Console.WriteLine("Encerrando o sistema...");
    }
}
