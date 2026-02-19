using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public string Nome;
    public int Preco;
    public int Quantidade;

    public Item(string nome, int preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public virtual void Usar()
    {
        Console.WriteLine($"{Nome} foi usado.");
    }
}

public class Pocao : Item
{
    public Pocao() : base("Poção de Vida", 10, 5) { }
    public override void Usar() => Console.WriteLine(">>> Resultado: Você curou vida!");
}

public class Mana : Item
{
    public Mana() : base("Poção de Mana", 12, 5) { }
    public override void Usar() => Console.WriteLine(">>> Resultado: Você restaurou mana!");
}

public class Veneno : Item
{
    public Veneno() : base("Veneno", 15, 3) { }
    public override void Usar() => Console.WriteLine(">>> Resultado: Você causou dano no inimigo!");
}

public class Loja
{
    private List<Item> itens = new List<Item>();

    public Loja()
    {
        itens.Add(new Pocao());
        itens.Add(new Mana());
        itens.Add(new Veneno());
    }

    public void ListarItems()
    {
        Console.WriteLine("\n=========================================");
        Console.WriteLine("           ESTOQUE DISPONÍVEL            ");
        Console.WriteLine("=========================================");
        Console.WriteLine("ID | Item            | Preço | Estoque");
        Console.WriteLine("-----------------------------------------");
        for (int i = 0; i < itens.Count; i++)
        {
            Console.WriteLine($"{i + 1}  | {itens[i].Nome.PadRight(15)} | {itens[i].Preco}g  | {itens[i].Quantidade} un");
        }
        Console.WriteLine("=========================================");
    }

    public void ComprarPorIndice(int indice, int quantidade)
    {
        if (indice < 0 || indice >= itens.Count)
        {
            Console.WriteLine("Erro: ID do item inválido.");
            return;
        }

        var item = itens[indice];

        if (quantidade <= 0)
        {
            Console.WriteLine("Erro: A quantidade deve ser maior que zero.");
            return;
        }

        if (item.Quantidade < quantidade)
        {
            Console.WriteLine($"Erro: Estoque insuficiente! Apenas {item.Quantidade} disponível.");
            return;
        }

        item.Quantidade -= quantidade;
        Console.WriteLine($"\nSucesso! Você comprou {quantidade}x {item.Nome}.");
        item.Usar();
    }

    public static void Main(string[] args)
    {
        Loja loja = new Loja();
        bool rodando = true;

        while (rodando)
        {
            // Console.Clear();
            Console.WriteLine("********** BEM-VINDO AO MERCADO RPG **********");
            loja.ListarItems();
            
            Console.WriteLine("\nOPÇÕES:");
            Console.WriteLine("[1] Comprar Item");
            Console.WriteLine("[0] Sair do Jogo");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("\nDigite o ID do item que deseja (número à esquerda): ");
                if (int.TryParse(Console.ReadLine(), out int id) && id > 0)
                {
                    Console.Write("Quantidade: ");
                    if (int.TryParse(Console.ReadLine(), out int qtd))
                    {
                        loja.ComprarPorIndice(id - 1, qtd);
                    }
                    else
                    {
                        Console.WriteLine("Quantidade inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("ID inválido.");
                }
                
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            else if (opcao == "0")
            {
                rodando = false;
                Console.WriteLine("Obrigado por visitar a nossa loja! Até logo.");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}