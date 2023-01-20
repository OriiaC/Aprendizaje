/*Ejercicio 2 - Do while
Escribe un programa que realice estos pasos:
Reciba al menos un número por consola
Determine si el número es positivo o negativo
Presente un contador para cada tipo (positivo y negativo).
Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo.
Tienes completa libertad para elegir el formato de la salida.*/

Console.WriteLine("Digita un numero");
int num1 = Convert.ToInt16(Console.ReadLine());

do
{
    if (num1 == 0)
    {
        Console.WriteLine("es = " + num1);
        num1++;
    }
} while (num1 == 0);

do
{   
    if (num1 > 0)
    {
        Console.WriteLine("Contador de positivos: " + num1);
        num1--;
    }    
} while (num1 > 0);

do
{
    if (num1 < 0)
    {
        Console.WriteLine("Contador de negativos: " + num1);
        num1++;
    }
} while (num1 < 0);

//tuve que ponerle los if's por que o si no igual mostraba los mensajes de los demas contadores que no tenian nada que ver con el numero solicitado