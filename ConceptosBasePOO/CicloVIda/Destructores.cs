using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConceptosBasePOO.CicloVIda
{
    // se llama a IDisposable para poder destruir
    internal class Destructores : IDisposable
    {
        public string Nombre { get; set; }
        private bool disposed = false;

        public Destructores(string nombre)
        {
            Nombre = nombre;
            Console.WriteLine($"{Nombre} creada.");
        }

        public void Dibujar()
        {
            if (disposed)
                throw new ObjectDisposedException("Figura");
            Console.WriteLine($"Dibujando {Nombre}...");
        }

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine($"{Nombre} eliminada (Dispose).");
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        ~Destructores()
        {
            Console.WriteLine($"{Nombre} eliminada (Destructor).");
        }
    }
}
