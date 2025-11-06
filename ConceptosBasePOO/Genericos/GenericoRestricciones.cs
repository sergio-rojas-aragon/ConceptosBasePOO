using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Genericos
{

    internal class FiguraRestricciones
    {
        public string Color { get; set; }

        public virtual double CalcularArea()
        {
            return 0;
        }
    }

    internal class Rectangulo : FiguraRestricciones
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public override double CalcularArea() => Ancho * Alto;
    }

    internal class Circulo : FiguraRestricciones
    {
        public double Radio { get; set; }

        public override double CalcularArea() => Math.PI * Radio * Radio;
    }

    internal class CalculadoraDeAreas<T> where T : FiguraRestricciones, new()
    {
        // solo funciona con tipos que hereden de FiguraRestricciones
        // y que además tengan un constructor sin parámetros(new ()).
        // Garantiza que T herede de FiguraRestricciones, por lo que tiene el método CalcularArea().

        public double CalcularAreaFigura(T figura)
        {
            return figura.CalcularArea();
        }

        // Crear una figura vacía del tipo T
        public T CrearFigura()
        {
            return new T();
            // Permite usar new T() dentro de la clase, creando instancias genéricas.
        }
    }

    internal class UsoGenericoRestricciones
    {
        public UsoGenericoRestricciones()
        {
            Console.WriteLine("\nGENERICOS RESTRICCIONES\n");

            // llamo a la clase con restricciones y que solo permite las clases que hereden FIguraRestricciones como Rectangulo y Circulo
            // Reemplaza T por Rectangulo.
            var calcRect = new CalculadoraDeAreas<Rectangulo>();

            // uso la clase rectangulo para setear los valores del rectangulo.
            var rect = new Rectangulo { Ancho = 5, Alto = 4, Color = "Rojo" };

            // envio el objeto de rectangulo para el calculo del area
            var calculoRectangulo = calcRect.CalcularAreaFigura(rect);
            
            Console.WriteLine($"Área del rectángulo: {calculoRectangulo}");

            // Reemplaza T por Circulo.
            var calcCirculo = new CalculadoraDeAreas<Circulo>();
            
            var cir = new Circulo { Radio = 3, Color = "Azul" };
            var calculoCirculo = calcCirculo.CalcularAreaFigura(cir);

            Console.WriteLine($"Área del círculo: {calculoCirculo}");
        }
    }

}
