using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Abstraccion
{
    internal abstract class FiguraAbstracta
    {
        public string Color { get; set; }
        public abstract double CalcularArea();

        public void MostrarColor() => Console.WriteLine($"Color: {Color}");

    }
}
