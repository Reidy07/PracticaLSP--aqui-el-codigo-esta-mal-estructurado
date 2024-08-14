
using Practica_LSP.clases;

public class Program 
{
    static void Main(string[] args)
    {
        FiguraGeometrica rectangulo = new Rectangulo { Base = 5, Altura = 4 };
        FiguraGeometrica cuadrado = new Cuadrado { Base = 4, Altura = 4 }; 

        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
    }
}
