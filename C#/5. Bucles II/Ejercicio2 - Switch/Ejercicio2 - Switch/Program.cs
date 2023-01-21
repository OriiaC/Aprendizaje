/*Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++.
 * Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.
Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.*/

Console.WriteLine("1. C#\n2. Java\n3. C++\n4. Python\n5. Go");
Console.Write("Seleccione el lenguaje de programacion: ");
int opt = Convert.ToInt16(Console.ReadLine());
switch (opt)
{
    case 1:
        Console.WriteLine("usted selecciono C#.");
        break;
    case 2:
        Console.WriteLine("usted selecciono Java.");
        break;
    case 3:
        Console.WriteLine("usted selecciono C++.");
        break;
    case 4:
        Console.WriteLine("usted selecciono Python.");
        break;
    case 5:
        Console.WriteLine("usted selecciono Go.");
        break;
    default: Console.WriteLine("La eleccion es invalida");
        break;
}