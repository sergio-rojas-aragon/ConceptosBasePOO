// See https://aka.ms/new-console-template for more information
using ConceptosBasePOO.Abstraccion;
using ConceptosBasePOO.AbstraccionInterfaces;
using ConceptosBasePOO.Encapsulacion;
using ConceptosBasePOO.Genericos;
using ConceptosBasePOO.Herencia;
using ConceptosBasePOO.Polimorfismo;

Console.WriteLine("Hello, World!");
var Abstraccion = new UsoAbstraccion();
Console.WriteLine("Fin Abstraccion");

var AbtracionInterfaces = new UsoAbstraccionInterfaz();
Console.WriteLine("Fin AbtracionInterfaces");

// Herencia

var herencia = new UsoHerencia();
Console.WriteLine("Fin UsoHerencia");


// Encapsulacion

var encapsulacion = new UsoEncapsulacion();
Console.WriteLine("Fin Encapsulacion");

// Polimorfismo

var polimorfismo = new UsoPolimorfismo();
Console.WriteLine("Fin Polimorfismo");

// Genericos

var genericoBasico = new UsoGenericoBasico();
var genericoRepositorio= new UsoGenericoRepositorio();
var genericoRestricciones = new UsoGenericoRestricciones();

Console.WriteLine("Fin Genericos");
