using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Genericos
{

    internal class Repositorio<T>
    {
        // funciona para cualquier tipo de dato sin duplicar código.

        private List<T> elementos = new List<T>();

        public void Agregar(T item)
        {
            elementos.Add(item);
        }

        public List<T> ObtenerTodos()
        {
            return elementos;
        }
    }

    internal class UsoGenericoRepositorio
    {
        public UsoGenericoRepositorio()
        {
            Console.WriteLine("\nGENERICOS REPOSITORIO\n");

            // Repositorio de enteros
            Repositorio<int> numeros = new Repositorio<int>();
            numeros.Agregar(1);
            numeros.Agregar(2);

            // Repositorio de cadenas
            Repositorio<string> nombres = new Repositorio<string>();
            nombres.Agregar("Ana");
            nombres.Agregar("Luis");

            // Mostrar resultados
            Console.WriteLine(string.Join(", ", numeros.ObtenerTodos())); // 1, 2
            Console.WriteLine(string.Join(", ", nombres.ObtenerTodos())); // Ana, Luis
        }
    }

}
