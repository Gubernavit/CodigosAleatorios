using System;

public class Armadura
{
    public int Defesa;
    public int Peso;

    public Armadura(int defesa, int peso)
    {
        Defesa = defesa;
        Peso = peso;
    }

    public virtual int AplicarDefesa()
    {
        return Defesa;
    }

    public virtual void MostrarDescricao()
    {
        Console.WriteLine($"Defesa: {Defesa}, Peso: {Peso}");
    }
}

public class ArmaduraLeve : Armadura
{
    public ArmaduraLeve() : base(20, 5) {}

    public override int AplicarDefesa() => Defesa;
}

public class ArmaduraPesada : Armadura
{
    public ArmaduraPesada() : base(40, 20) {}

    public override int AplicarDefesa()
    {
        Console.WriteLine("Velocidade reduzida!");
        return Defesa + 10;
    }
}

public class ArmaduraMagica : Armadura
{
    public ArmaduraMagica() : base(30, 10) {}

    public override int AplicarDefesa()
    {
        Console.WriteLine("Resistência mágica aumentada!");
        return Defesa + 5;
    }
}

public class Program
{
    public static void Main()
    {
        Armadura[] armaduras = new Armadura[]
        {
            new ArmaduraLeve(),
            new ArmaduraPesada(),
            new ArmaduraMagica()
        };

        foreach (var a in armaduras)
        {
            a.MostrarDescricao();
            Console.WriteLine("Defesa aplicada: " + a.AplicarDefesa());
            Console.WriteLine();
        }
    }
}
