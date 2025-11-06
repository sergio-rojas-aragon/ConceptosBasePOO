using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Herencia
{
    internal class Cuadrado:FiguraBase
    {
        public double Lado { get; set; }

        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }

    internal class Triangulo : FiguraBase
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
