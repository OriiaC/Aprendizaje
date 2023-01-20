/*Ejercicio 1 - While
Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:
1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10*/

using System.Xml.Schema;

Console.WriteLine("Digite el numero a multiplicar: ");
int numero = Convert.ToInt16(Console.ReadLine());
int contador = 1;

while (contador <= 10)
{
    int total = numero * contador;
    Console.WriteLine(numero+"*"+contador+"="+total);
    contador++;
}