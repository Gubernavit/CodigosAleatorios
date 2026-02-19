/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Pokemon
{
    public string Nome;
    public int Nivel;
    public int Vida;

    public Pokemon(string nome, int nivel, int vida)
    {
        Nome = nome;
        Nivel = nivel;
        Vida = vida;
    }

    public virtual void Atacar()
    {
        Console.WriteLine($"{Nome} fez um ataque básico!");
    }

    public void SubirNivel()
    {
        Nivel++;
        Console.WriteLine($"{Nome} subiu para o nível {Nivel}!");
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"Pokémon: {Nome} | Nível: {Nivel} | Vida: {Vida}");
    }
}

// -----------------------------
// CLASSE FILHA 1
// -----------------------------
class PokemonFogo : Pokemon
{
    public string Tipo = "Fogo";

    public PokemonFogo(string nome, int nivel, int vida)
        : base(nome, nivel, vida)
    {
    }

    public void LancaChamas()
    {
        Console.WriteLine($"{Nome} usou LANÇA-CHAMAS!");
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacou com uma rajada de fogo!");
    }
}

// -----------------------------
// CLASSE FILHA 2
// -----------------------------
class PokemonAgua : Pokemon
{
    public string Tipo = "Água";

    public PokemonAgua(string nome, int nivel, int vida)
        : base(nome, nivel, vida)
    {
    }

    public void JatoDeAgua()
    {
        Console.WriteLine($"{Nome} usou JATO DE ÁGUA!");
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacou com um jato poderoso de água!");
    }
}

// -----------------------------
// PROGRAMA PRINCIPAL
// -----------------------------
class Program
{
    static void Main()
    {
        PokemonFogo charmander = new PokemonFogo("Charmander", 5, 40);
        PokemonAgua squirtle = new PokemonAgua("Squirtle", 5, 43);

        charmander.MostrarStatus();
        charmander.Atacar();
        charmander.LancaChamas();
        charmander.SubirNivel();

        Console.WriteLine();

        squirtle.MostrarStatus();
        squirtle.Atacar();
        squirtle.JatoDeAgua();
        squirtle.SubirNivel();

        Console.ReadLine();
    }
}