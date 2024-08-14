using System;

namespace Practica_LSP.clases
{
    public class Rectangulo : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            return base.Altura;
        }
    }
}
