using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Herencia
{
    internal class FiguraBase
    {
        public string Nombre { get; set; }
        public string Color { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Figura: {Nombre}, Color: {Color}");
        }
    }
}
