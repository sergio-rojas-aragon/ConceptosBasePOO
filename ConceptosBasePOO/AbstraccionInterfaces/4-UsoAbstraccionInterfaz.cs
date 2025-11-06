using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.AbstraccionInterfaces
{
    internal class UsoAbstraccionInterfaz
    {
        public UsoAbstraccionInterfaz()
        {
            Console.WriteLine("\nABSTRACCION INTERFAZ\n");

            var circulo = new Circulo { Color = "Rojo", Radio = 3 };
            var rectangulo = new Rectangulo { Color = "Azul", Ancho = 4, Alto = 5 };

            //circulo
            Console.WriteLine($"Área: {circulo.CalcularArea()}");
            circulo.MostrarColor();

            //rectangulo
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");
            rectangulo.MostrarColor();

        }
    }
}
