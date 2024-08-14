using System;
namespace Practica_LSP.clases
{
    public class Cuadrado:FiguraGeometrica
    {
        public override double CalcularArea()
        {
            // aqui es donde hice el codigo mal estructurado para que lo pueda notar.
            return base.Altura;
        }
    }
}
