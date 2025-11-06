using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Polimorfismo
{
    internal class FiguraPolimorfismo
    {
        public string Nombre { get; set; }

        // Método virtual que podrá ser sobrescrito
        // indica que el método puede ser redefinido en las clases hijas.
        // Si una clase hija no lo sobrescribe, usará esta versión base.
        public virtual double CalcularArea()
        {
            return 0; // Valor por defecto
        }

        public void MostrarNombre()
        {
            Console.WriteLine($"Figura: {Nombre}");
        }
    }
}
