using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.AbstraccionInterfaces
{
    internal class Circulo : FiguraAbstractaConInterfaz
    {
        public double Radio { get; set; }
        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;

        }
    }

    internal class Rectangulo : FiguraAbstractaConInterfaz
    {

        public double Ancho { get; set; }
        public double Alto { get; set; }

        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }


}
