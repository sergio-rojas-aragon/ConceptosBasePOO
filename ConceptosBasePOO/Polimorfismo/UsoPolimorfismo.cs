using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Polimorfismo
{
    internal class UsoPolimorfismo
    {
        public UsoPolimorfismo()
        {
            Console.WriteLine("\n\nPOLIMORFISMO\n");

            List<FiguraPolimorfismo> figuras = new List<FiguraPolimorfismo>()
                {
                    new Rectangulo { Nombre = "Rectángulo", Ancho = 4, Alto = 5 },
                    new Circulo { Nombre = "Círculo", Radio = 3 }
                };

            // Polimorfismo en acción:
            foreach (var f in figuras)
            {
                // Método común (no polimórfico)
                f.MostrarNombre();

                // Método polimórfico
                Console.WriteLine($"Área: {f.CalcularArea()}"); 
            }
        }
    }
}
