using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Encapsulacion
{
    internal class EncapsulacionIncorrecta
    {

        public EncapsulacionIncorrecta()
        {
            Rectangulo r = new Rectangulo();
            r.Ancho = -5; // Error lógico: un rectángulo no puede tener ancho negativo

            //No hay control ni validación sobre los datos.
            //Esto rompe la integridad del objeto.
        }
    }

    public class Rectangulo
    {
        public double Ancho;
        public double Alto;
    }
}
