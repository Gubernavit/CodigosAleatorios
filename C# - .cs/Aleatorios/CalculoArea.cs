using System;

public abstract class FormaGeometrica
{
    public float Base { get; set; }
    public float Altura { get; set; }

    public abstract float CalcularArea();
}

public class Triangulo : FormaGeometrica
{
    public override float CalcularArea()
    {
        Console.WriteLine("Digite a base do triângulo:");
        Base = float.Parse(Console.ReadLine()); 

        Console.WriteLine("Digite a altura do triângulo:");
        Altura = float.Parse(Console.ReadLine());

        return Base * Altura / 2;
    }
}

public class Retangulo : FormaGeometrica
{
    public override float CalcularArea()
    {
        Console.WriteLine("Digite a base do retângulo:");   
        Base = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do retângulo:");
        Altura = float.Parse(Console.ReadLine());

        return Base * Altura;
    }
}

public class Circulo : FormaGeometrica
{
    public override float CalcularArea()
    {
        Console.WriteLine("Digite o diâmetro do círculo:");
        Base = float.Parse(Console.ReadLine());

        return (float)(Math.PI * Math.Pow(Base / 2, 2));
    }
}

public class Quadrado : FormaGeometrica
{
    public override float CalcularArea()
    {
        Console.WriteLine("Digite o lado do quadrado:");
        Base = float.Parse(Console.ReadLine());

        return Base * Base;
    }
}

public class Losango : FormaGeometrica
{
    public override float CalcularArea()
    {
        Console.WriteLine("Digite a diagonal maior do losango:");
        Base = float.Parse(Console.ReadLine()); 
        Console.WriteLine("Digite a diagonal menor do losango:");
        Altura = float.Parse(Console.ReadLine());   

        return Base * Altura / 2;
    }
}

public class Trapezio : FormaGeometrica
{
    public float BaseMenor { get; set; }

    public override float CalcularArea()
    {
        Console.WriteLine("Digite a base maior do trapézio:");
        Base = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a base menor do trapézio:");
        BaseMenor = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do trapézio:");
        Altura = float.Parse(Console.ReadLine());

        return (Base + BaseMenor) * Altura / 2;
    }
}

public class Hexagono : FormaGeometrica
{
    public override float CalcularArea()
    {
        Console.WriteLine("Digite o lado do hexágono:");
        Base = float.Parse(Console.ReadLine());

        return (float)((3 * Math.Sqrt(3) * Math.Pow(Base / 2, 2)) / 2);
    }
}


public class Program
{
    public static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("Escolha a forma geométrica para calcular a área:");
            Console.WriteLine("===================================================");
            Console.WriteLine("1. Triângulo");
            Console.WriteLine("2. Retângulo");
            Console.WriteLine("3. Círculo");
            Console.WriteLine("4. Quadrado");
            Console.WriteLine("5. Losango");
            Console.WriteLine("6. Trapézio");
            Console.WriteLine("7. Hexágono");
            Console.WriteLine();
            Console.WriteLine("0. Sair");
            Console.WriteLine("===================================================");

            int escolha = int.Parse(Console.ReadLine());
            FormaGeometrica forma = null;

            switch (escolha)
            {
                case 0:
                    sair = true;
                    continue;
                case 1:
                    forma = new Triangulo();
                    break;
                case 2:
                    forma = new Retangulo();
                    break;
                case 3:
                    forma = new Circulo();
                    break;
                case 4:
                    forma = new Quadrado();
                    break;
                case 5:
                    forma = new Losango();
                    break;
                case 6:
                    forma = new Trapezio();
                    break;
                case 7:
                    forma = new Hexagono();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    continue;
            }

            Console.WriteLine($"A área do {forma.GetType().Name} é: {forma.CalcularArea()}");
        }
    }
}
