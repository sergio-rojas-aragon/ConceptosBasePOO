using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.CicloVIda
{
    internal class RecursoBase : IDisposable
    {

        private bool disposed = false;

        // Simulación de un recurso administrado (por ejemplo, una imagen)
        protected MemoryStream recurso;

        public RecursoBase()
        {
            recurso = new MemoryStream();
            Console.WriteLine("Figura: recurso creado");
        }

        // Método público que llama al patrón de Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Método protegido y virtual (permite herencia)
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Liberar recursos administrados
                    recurso?.Dispose();
                    Console.WriteLine("Figura: recurso administrado liberado");
                }

                // Aquí irían recursos no administrados si los hubiera
                disposed = true;
            }
        }

        // Destructor (por si no se llamó a Dispose)
        ~RecursoBase()
        {
            Dispose(false);
        }
    }
}
