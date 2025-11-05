using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Abstraccion
{
    internal class UsoAbstraccion
    {
        public UsoAbstraccion()
        {
            FiguraAbstracta figura = new ImplementacionAbstraccion() { Color = "Rojo", Radio = 5 };
            Console.WriteLine($" Area de la figura {figura.CalcularArea()}");
            figura.MostrarColor();
        }


    }
}
