using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.CicloVIda
{
    internal class RecursoDeribado : RecursoBase
    {

        private bool disposed = false;

        // Recurso propio del rectángulo
        private StreamWriter log;

        public RecursoDeribado()
        {
            log = new StreamWriter(new MemoryStream());
            Console.WriteLine("Rectángulo: recurso propio creado");
        }

        // Sobrescribe el Dispose protegido que fue creado en el recurso base
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Liberar recurso propio
                    log?.Dispose();
                    Console.WriteLine("Rectángulo: recurso propio liberado");
                }

                // Llamar al Dispose de la clase base
                base.Dispose(disposing);
                disposed = true;
            }
        }
    }
}
