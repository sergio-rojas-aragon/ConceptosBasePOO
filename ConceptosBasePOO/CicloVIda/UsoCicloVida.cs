using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.CicloVIda
{
    internal class UsoCicloVida
    {
        public UsoCicloVida()
        {
            Console.WriteLine("\nCiclo de Vida Destructores\n");

            using (var f = new Destructores("Círculo"))
            {
                f.Dibujar();
            }

            Console.WriteLine("\nCiclo de Vida Destructores Heredados\n");

            using (var r = new RecursoDeribado())
            {
                Console.WriteLine("Usando el rectángulo...");
            }
        }
    }
}
