using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.SOLID
{
    using System;
    using System.Collections.Generic;

    #region Interfaces

    public interface IFigura2D
    {
        double CalcularArea();
        double CalcularPerimetro();
        string Nombre { get; }
    }

    #endregion

    #region Clases Concretas (O, L, I aplicados)

    public class Cuadrado : IFigura2D
    {
        public double Lado { get; set; }
        public string Nombre => "Cuadrado";

        public Cuadrado(double lado) => Lado = lado;

        public double CalcularArea() => Lado * Lado;
        public double CalcularPerimetro() => 4 * Lado;
    }

    public class Circulo : IFigura2D
    {
        public double Radio { get; set; }
        public string Nombre => "Círculo";

        public Circulo(double radio) => Radio = radio;

        public double CalcularArea() => Math.PI * Radio * Radio;
        public double CalcularPerimetro() => 2 * Math.PI * Radio;
    }

    public class Triangulo : IFigura2D
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public string Nombre => "Triángulo";

        public Triangulo(double b, double h, double a, double c)
        {
            Base = b; Altura = h; LadoA = a; LadoB = c;
        }

        public double CalcularArea() => (Base * Altura) / 2;
        public double CalcularPerimetro() => Base + LadoA + LadoB;
    }

    #endregion

    #region Clases de alto nivel (S, D aplicados)

    // Calculadora depende de una abstracción (IFigura2D), no de clases concretas
    public class Calculadora
    {
        public void MostrarResultados(IFigura2D figura)
        {
            Console.WriteLine($"Figura: {figura.Nombre}");
            Console.WriteLine($"Área: {figura.CalcularArea():0.00}");
            Console.WriteLine($"Perímetro: {figura.CalcularPerimetro():0.00}");
            Console.WriteLine(new string('-', 30));
        }
    }

    // Esta clase podría cambiar la forma de salida sin tocar las demás
    public class Impresora
    {
        public void Imprimir(IEnumerable<IFigura2D> figuras)
        {
            var calculadora = new Calculadora();
            foreach (var figura in figuras)
            {
                calculadora.MostrarResultados(figura);
            }
        }
    }

    #endregion

    #region Programa Principal

    public class Program
    {
        public static void Main()
        {
            var figuras = new List<IFigura2D>
        {
            new Cuadrado(5),
            new Circulo(3),
            new Triangulo(3, 4, 3, 5)
        };

            var impresora = new Impresora();
            impresora.Imprimir(figuras);
        }
    }

    #endregion

}
