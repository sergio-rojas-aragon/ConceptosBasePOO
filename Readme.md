<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
**Table of Contents**

- [Conceptos Base en la Programacion Orientada a Objetos Aplicado](#conceptos-base-en-la-programacion-orientada-a-objetos-aplicado)
  - [Abstraccion](#abstraccion)
    - [Con clases abstractas](#con-clases-abstractas)
    - [Con interfaces](#con-interfaces)
  - [Herencia](#herencia)
  - [Encapsulacion](#encapsulacion)
  - [Polimorfismo](#polimorfismo)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

# Conceptos Base en la Programacion Orientada a Objetos Aplicado

Para estos ejercicios se utilizo **.Net8** en una Consola Simple

... El resto del contenido de tu README ...


## Abstraccion

La abstracci�n es un principio fundamental de la Programaci�n Orientada a Objetos (POO) que consiste en:

> Modelar solo los aspectos relevantes de un objeto, ocultando los detalles de implementaci�n.

En otras palabras:

* Te enfocas en qu� hace un objeto, no c�mo lo hace.
* Permite simplificar sistemas complejos, exponiendo solo lo necesario a trav�s de interfaces o clases abstractas.

En .NET puedes aplicar abstracci�n de dos maneras principales:

### Con clases abstractas

* Son clases base que no pueden instanciarse.
* Pueden definir m�todos implementados y no implementados.
* Los m�todos abstractos deben implementarse en las clases derivadas.

El ejemplo se puede encontrar en la carpeta `Abstraccion`

### Con interfaces

Se puede aplicar Abstraccion utilizando interfaces siguiendo este orden:

Interfaz => Abstraccion => Clase a implementar

* Una interfaz define un contrato que las clases deben cumplir.
* No tiene l�gica interna ni estado, solo firmas de m�todos o propiedades.
* Una clase puede implementar m�ltiples interfaces (a diferencia de la herencia simple).

**Diferencias entre Abstraccion y Encapsulacion**


| Concepto          | Qu� hace                                                             | C�mo se aplica                          |
| ----------------- | -------------------------------------------------------------------- | --------------------------------------- |
| **Encapsulaci�n** | Oculta los **datos** internos de un objeto                           | Uso de `private`, `public`, propiedades |
| **Abstracci�n**   | Oculta los **detalles de implementaci�n** y muestra solo lo esencial | Clases abstractas, interfaces           |




El ejemplo se puede encontrar en la carpeta `AbstraccionInterfaces`


## Herencia

Crear una nueva clase (derivada o hija) a partir de una clase existente (base o padre), heredando sus propiedades, m�todos y comportamiento.

Esto permite reutilizar c�digo, extender funcionalidades y mantener una estructura jer�rquica en el dise�o.


| T�rmino                   | Significado                                                                                                           |
| ------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| **Clase base (padre)**    | La clase original que contiene atributos y m�todos comunes.                                                           |
| **Clase derivada (hija)** | La clase que hereda de la base y puede agregar o modificar comportamiento.                                            |
| **Herencia simple**       | En C#, una clase **solo puede heredar de una clase base**.                                                            |
| **Palabras clave**        | `:` (dos puntos) para heredar, `base` para acceder al constructor o m�todos del padre, `override` para sobreescribir. |

## Encapsulacion

La encapsulaci�n es el principio de ocultar los datos internos de un objeto y controlar c�mo se accede o modifica esa informaci�n.

Objetivo

* Evitar acceso directo a los datos (por ejemplo, que se modifiquen sin control).
* Asegurar consistencia en el estado del objeto.
* Separar la implementaci�n interna de la interfaz p�blica.

Sin la encapsulacion no hay control ni valdacion sobre los datos. Esto Rompe la integridad del objeto.

## Polimorfismo

Un mismo m�todo o acci�n puede comportarse de distintas maneras seg�n el tipo de objeto que lo ejecute.

El polimorfismo permite tratar diferentes tipos de objetos de una misma familia (por herencia) como si fueran del mismo tipo, pero ejecutando el comportamiento propio de cada uno.

Tipos de polimorfismo en C# / .NET

| Tipo                                    | Cu�ndo ocurre                     | C�mo se implementa                                  |
| --------------------------------------- | --------------------------------- | --------------------------------------------------- |
| **En tiempo de compilaci�n (est�tico)** | Durante la compilaci�n            | *Sobrecarga de m�todos* (`overloading`)             |
| **En tiempo de ejecuci�n (din�mico)**   | Durante la ejecuci�n del programa | *Sobrescritura de m�todos* (`virtual` / `override`) |


Para que un m�todo sea polim�rfico:

* Debe estar declarado como virtual o abstract en la clase base.
* Debe sobrescribirse con override en la clase derivada.

Si no usas virtual/override, C# no har� polimorfismo real,
sino que llamar� siempre al m�todo de la clase base (esto se llama ocultamiento y se hace con new, no override).