using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBasePOO.Genericos
{
    internal class GenericosBasico<T>
    {
        private T contenido;

        public void Guardar (T valor)
        {
            contenido = valor;
        }

        public T Obtener()
        {
            return contenido;
        }
    }

    internal class UsoGenericoBasico
    {
        public UsoGenericoBasico()
        {
            Console.WriteLine("\nGENERICOS BASICO\n");
            // problema
            ArrayList lista = new ArrayList();
            lista.Add(10);
            lista.Add("texto"); // Causa errores después

            // Usando Genericos

            GenericosBasico<int> cajaEnteros = new GenericosBasico<int>();
            cajaEnteros.Guardar(42);
            Console.WriteLine(cajaEnteros.Obtener()); // 42

            GenericosBasico<string> cajaTexto = new GenericosBasico<string>();
            cajaTexto.Guardar("Hola mundo");
            Console.WriteLine(cajaTexto.Obtener()); // Hola mundo

        }
    }
}
