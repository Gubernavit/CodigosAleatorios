using System;
using System.Collections.Generic;

public class Inventario
{
    private int _capacidade;
    private List<string> _itens = new List<string>();

    public int Capacidade => _capacidade;
    public int Quantidade => _itens.Count;
    public string[] Itens => _itens.ToArray();

    public Inventario(int capacidade)
    {
        if (capacidade < 1 || capacidade > 50)
        {
            Console.WriteLine("Capacidade inválida! Definindo para 10.");
            _capacidade = 10;
        }
        else
        {
            _capacidade = capacidade;
        }
    }

    public void AdicionarItem(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome do item inválido!");
            return;
        }

        if (Quantidade >= Capacidade)
        {
            Console.WriteLine("Inventário cheio!");
            return;
        }

        _itens.Add(nome);
        Console.WriteLine($"Item '{nome}' adicionado.");
    }

    public void RemoverItem(string nome)
    {
        if (_itens.Remove(nome))
            Console.WriteLine($"Item '{nome}' removido.");
        else
            Console.WriteLine("Item não encontrado!");
    }
}

class Program1
{
    static void Main(string[] args)
    {
        Console.Write("Defina a capacidade do seu inventário (1-50): ");
        int.TryParse(Console.ReadLine(), out int cap);
        
        Inventario meuInventario = new Inventario(cap);
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine($"\n--- INVENTÁRIO ({meuInventario.Quantidade}/{meuInventario.Capacidade}) ---");
            
            string[] itensAtuais = meuInventario.Itens;
            if (itensAtuais.Length == 0)
            {
                Console.WriteLine("[ Vazio ]");
            }
            else
            {
                foreach (string item in itensAtuais)
                {
                    Console.WriteLine($"- {item}");
                }
            }

            Console.WriteLine("\n1. Adicionar Item");
            Console.WriteLine("2. Remover Item");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do item para adicionar: ");
                    string nomeAdd = Console.ReadLine();
                    meuInventario.AdicionarItem(nomeAdd);
                    break;

                case "2":
                    Console.Write("Nome do item para remover: ");
                    string nomeRem = Console.ReadLine();
                    meuInventario.RemoverItem(nomeRem);
                    break;

                case "3":
                    rodando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}