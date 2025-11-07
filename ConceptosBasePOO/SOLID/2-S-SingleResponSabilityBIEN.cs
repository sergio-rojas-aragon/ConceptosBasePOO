using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.SOLID
{
    public class Reporte
    {
        public string GenerarReporte()
        {
            return "Contenido del reporte";
        }
    }

    public class GuardarArchivo
    {
        public void Guardar(string contenido)
        {
            File.WriteAllText("reporte.txt", contenido);
        }
    }

    public class EnviarCorreo
    {
        public void Enviar(string contenido)
        {
            Console.WriteLine("Correo enviado con reporte");
        }
    }
}
