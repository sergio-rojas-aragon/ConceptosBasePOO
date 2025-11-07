using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.SOLID
{

    // Si cambia una forma de envío o guardado, hay que modificar esta clase (difícil de mantener y probar).
    internal class SingleResponSabilityMAL
    {
        public string GenerarReporte()
        {
            return "Contenido del reporte";
        }

        public void GuardarArchivo(string contenido)
        {
            // Guardar en archivo
            File.WriteAllText("reporte.txt", contenido);
        }

        public void EnviarPorCorreo(string contenido)
        {
            // Lógica de envío de correo
            Console.WriteLine("Correo enviado con reporte");
        }
    }
}
