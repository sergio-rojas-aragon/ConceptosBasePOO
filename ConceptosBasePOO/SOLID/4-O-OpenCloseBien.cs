using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.SOLID
{
    internal abstract class Descuento
    {
        public abstract double Calcular(double monto);
    }

    internal class DescuentoNormal : Descuento
    {
        public override double Calcular(double monto) => monto * 0.05;
    }

    internal class DescuentoVIP : Descuento
    {
        public override double Calcular(double monto) => monto * 0.10;
    }

    internal class DescuentoPremium : Descuento
    {
        public override double Calcular(double monto) => monto * 0.15;
    }

    // Contexto abierto a extensión
    internal class CalculadoraDescuento
    {
        public double ObtenerDescuento(Descuento tipo, double monto)
        {
            return tipo.Calcular(monto);
        }
    }
}
