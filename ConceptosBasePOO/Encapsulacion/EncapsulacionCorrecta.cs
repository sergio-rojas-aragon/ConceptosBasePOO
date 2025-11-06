using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Encapsulacion
{
    internal class RectanguloCorrecto
    {
        private double ancho; // Campo privado
        private double alto;  // Campo privado

        // Propiedad pública para Ancho
        public double Ancho
        {
            get { return ancho; }
            set
            {
                if (value > 0)
                    ancho = value;
                else
                    Console.WriteLine("El ancho debe ser mayor que cero.");
            }
        }

        // Propiedad pública para Alto
        public double Alto
        {
            get { return alto; }
            set
            {
                if (value > 0)
                    alto = value;
                else
                    Console.WriteLine("El alto debe ser mayor que cero.");
            }
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            return ancho * alto;
        }

    }
    
    internal class UsoEncapsulacion
    {
        public UsoEncapsulacion()
        {
            Console.WriteLine("\nENCAPSULACION\n");

            RectanguloCorrecto r = new RectanguloCorrecto();

            // Intentamos asignar valores
            r.Ancho = 10;
            r.Alto = -5; // Mostrará un mensaje de error

            Console.WriteLine($"Ancho: {r.Ancho}, Alto: {r.Alto}");
            Console.WriteLine($"Área: {r.CalcularArea()}");
        }
    }
}
