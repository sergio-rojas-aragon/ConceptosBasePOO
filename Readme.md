# Conceptos Base en la Programacion Orientada a Objetos Aplicado

Para estos ejercicios se utilizo **.Net8** en una Consola Simple

... El resto del contenido de tu README ...


## Abstraccion

La abstracción es un principio fundamental de la Programación Orientada a Objetos (POO) que consiste en:

> Modelar solo los aspectos relevantes de un objeto, ocultando los detalles de implementación.

En otras palabras:

* Te enfocas en qué hace un objeto, no cómo lo hace.
* Permite simplificar sistemas complejos, exponiendo solo lo necesario a través de interfaces o clases abstractas.

En .NET puedes aplicar abstracción de dos maneras principales:

### Con clases abstractas

* Son clases base que no pueden instanciarse.
* Pueden definir métodos implementados y no implementados.
* Los métodos abstractos deben implementarse en las clases derivadas.

El ejemplo se puede encontrar en la carpeta `Abstraccion`

### Con interfaces

Se puede aplicar Abstraccion utilizando interfaces siguiendo este orden:

Interfaz => Abstraccion => Clase a implementar

* Una interfaz define un contrato que las clases deben cumplir.
* No tiene lógica interna ni estado, solo firmas de métodos o propiedades.
* Una clase puede implementar múltiples interfaces (a diferencia de la herencia simple).

**Diferencias entre Abstraccion y Encapsulacion**


| Concepto          | Qué hace                                                             | Cómo se aplica                          |
| ----------------- | -------------------------------------------------------------------- | --------------------------------------- |
| **Encapsulación** | Oculta los **datos** internos de un objeto                           | Uso de `private`, `public`, propiedades |
| **Abstracción**   | Oculta los **detalles de implementación** y muestra solo lo esencial | Clases abstractas, interfaces           |




El ejemplo se puede encontrar en la carpeta `AbstraccionInterfaces`


## Herencia

Crear una nueva clase (derivada o hija) a partir de una clase existente (base o padre), heredando sus propiedades, métodos y comportamiento.

Esto permite reutilizar código, extender funcionalidades y mantener una estructura jerárquica en el diseño.


| Término                   | Significado                                                                                                           |
| ------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| **Clase base (padre)**    | La clase original que contiene atributos y métodos comunes.                                                           |
| **Clase derivada (hija)** | La clase que hereda de la base y puede agregar o modificar comportamiento.                                            |
| **Herencia simple**       | En C#, una clase **solo puede heredar de una clase base**.                                                            |
| **Palabras clave**        | `:` (dos puntos) para heredar, `base` para acceder al constructor o métodos del padre, `override` para sobreescribir. |

## Encapsulacion

La encapsulación es el principio de ocultar los datos internos de un objeto y controlar cómo se accede o modifica esa información.

Objetivo

* Evitar acceso directo a los datos (por ejemplo, que se modifiquen sin control).
* Asegurar consistencia en el estado del objeto.
* Separar la implementación interna de la interfaz pública.

Sin la encapsulacion no hay control ni valdacion sobre los datos. Esto Rompe la integridad del objeto.

## Polimorfismo

Un mismo método o acción puede comportarse de distintas maneras según el tipo de objeto que lo ejecute.

El polimorfismo permite tratar diferentes tipos de objetos de una misma familia (por herencia) como si fueran del mismo tipo, pero ejecutando el comportamiento propio de cada uno.

Tipos de polimorfismo en C# / .NET

| Tipo                                    | Cuándo ocurre                     | Cómo se implementa                                  |
| --------------------------------------- | --------------------------------- | --------------------------------------------------- |
| **En tiempo de compilación (estático)** | Durante la compilación            | *Sobrecarga de métodos* (`overloading`)             |
| **En tiempo de ejecución (dinámico)**   | Durante la ejecución del programa | *Sobrescritura de métodos* (`virtual` / `override`) |


Para que un método sea polimórfico:

* Debe estar declarado como virtual o abstract en la clase base.
* Debe sobrescribirse con override en la clase derivada.

Si no usas virtual/override, C# no hará polimorfismo real,
sino que llamará siempre al método de la clase base (esto se llama ocultamiento y se hace con new, no override).