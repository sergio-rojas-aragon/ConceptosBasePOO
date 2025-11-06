using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.AbstraccionInterfaces
{
    internal abstract class FiguraAbstractaConInterfaz : Interfaz
    {
        //FiguraAbstractaConInterfaz implementa la Interfaz
        //FiguraAbstractaConInterfaz aplica abstracción(no se puede instanciar directamente).
        //CalculateArea() se deja sin implementación(abstracción pura).
        //MostrarColor() se implementa parcialmente(abstracción parcial + reutilización).

        public string Color { get; set; }

        // Método abstracto (no tiene implementación aquí)
        public abstract double CalcularArea();

        // Método concreto (tiene implementación)
        public void MostrarColor() =>  Console.WriteLine($"Color AbstractaInterfaz: {Color}");

    }
}
