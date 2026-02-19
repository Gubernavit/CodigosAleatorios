using System;

public class Item
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Raridade { get; private set; }
    public float Valor { get; set; }
    public int Quantidade { get; private set; }

    public Item(string nome, string descricao, int raridade, float valor, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        Raridade = raridade < 1 ? 1 : (raridade > 5 ? 5 : raridade);
        Valor = valor;
        Quantidade = quantidade < 0 ? 0 : quantidade;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Item: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Raridade: {Raridade}/5");
        Console.WriteLine($"Valor: {Valor} gold");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }

    public bool EhValioso()
    {
        return Raridade >= 4 || Valor >= 100;
    }

    public void AumentarRaridade()
    {
        if (Raridade < 5)
            Raridade++;
    }

    public bool UsarItem()
    {
        if (Quantidade <= 0)
        {
            Console.WriteLine("Sem itens suficientes!");
            return false;
        }

        Quantidade--;
        Console.WriteLine($"Você usou {Nome}! Restam {Quantidade}");
        return true;
    }
}

public class Program
{
    public static void Main()
    {
        Item espada = new Item(
            "Espada Flamejante",
            "Uma espada envolta em chamas eternas.",
            4,
            150,
            3
        );

        espada.ExibirInfo();
        Console.WriteLine();

        Console.WriteLine("É valioso? " + (espada.EhValioso() ? "Sim" : "Não"));
        Console.WriteLine();

        espada.AumentarRaridade();
        espada.ExibirInfo();
        Console.WriteLine();

        while (espada.UsarItem())
        {
            Console.WriteLine("Item usado com sucesso!");
        }

        Console.WriteLine();
        espada.UsarItem();
    }
}
