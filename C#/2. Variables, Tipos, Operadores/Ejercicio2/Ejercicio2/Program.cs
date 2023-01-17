/*Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
Coche: puertas, ruedas, marca, ITV vigente
Mesa: peso, largo, material, color*/

//Coche
string coche = "Coche";
int? puertas = null;
int? ruedas = null;
string? marca = null;
bool? ITV_vigente = null;
//Mesa
string? mesa = "Mesa";
float? peso = null;
float? largo = null;
string? material = null;
string? color = null;

//las siguientes son para que no genere los warnings de que no se estan usando las variables
//lo de concatenar con el + lo deje ayer cuando estaba investigando lo de coger la hora y vi esta opcion que me parece mas facil - {0}{1}{2}....
Console.WriteLine("el {0} tiene {1} puerta/s y {2} ruedas, es marca {3} y su vigencia es: {4}", coche, puertas, ruedas, marca, ITV_vigente);
Console.WriteLine("La {0} pesa {1}Kg y mide {2}cm de largo, esta hecha en material {3} de color {4}",mesa,peso,largo,material,color);