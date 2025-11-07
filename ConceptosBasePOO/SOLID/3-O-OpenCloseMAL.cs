using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.SOLID
{
    internal class OpenCloseMAL
    {

        public double CalcularDescuento(string tipoCliente, double monto)
        {
            if (tipoCliente == "Normal")
                return monto * 0.05;
            else if (tipoCliente == "VIP")
                return monto * 0.10;
            else if (tipoCliente == "Premium")
                return monto * 0.15;
            else
                return 0;
        }
    }
}
