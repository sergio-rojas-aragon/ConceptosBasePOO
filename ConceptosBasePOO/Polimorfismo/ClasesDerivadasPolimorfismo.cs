using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Polimorfismo
{
    internal class Rectangulo : FiguraPolimorfismo
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        // override indica que estamos redefiniendo el método CalcularArea() de la clase base.
        // Cada figura calcula su área de manera diferente, aunque el método se llame igual.
        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }


    internal class Circulo : FiguraPolimorfismo
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
