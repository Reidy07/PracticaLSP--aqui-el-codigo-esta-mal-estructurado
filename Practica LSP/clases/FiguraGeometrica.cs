using System;


namespace Practica_LSP.clases
{
    public class FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public virtual double CalcularArea()
        {
            throw new NotImplementedException("Este método debe ser implementado por las subclases.");

        }
    }
}
