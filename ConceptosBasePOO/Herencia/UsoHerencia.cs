using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Herencia
{
    internal class UsoHerencia
    {
        public UsoHerencia()
        {
            Console.WriteLine("\n\nHERENCIA\n");
            Cuadrado c = new Cuadrado();
            c.Nombre = "Cuadrado";
            c.Color = "Rojo";
            c.Lado = 5;

            Triangulo t = new Triangulo();
            t.Nombre = "Triangulo";
            t.Color = "Azul";
            t.Base = 6;
            t.Altura = 4;

            // metodos heredados

            c.MostrarInformacion();
            Console.WriteLine($"Área del {c.Nombre}: {c.CalcularArea()}");

            t.MostrarInformacion();
            Console.WriteLine($"Área del {t.Nombre}: {t.CalcularArea()}");
        }
    }
}
