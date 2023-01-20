using System.Diagnostics;
/*Ejercicio 3 - For
Escribe un programa que realice estos pasos:
Reciba 3 datos:
ancho
alto
relleno o no
Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla.*/

Console.Write("Digita el ancho: ");
int ancho = Convert.ToInt16(Console.ReadLine());

Console.Write("Digita el alto: ");
int alto = Convert.ToInt16(Console.ReadLine());

Console.Write("Lo quiere con relleno: false/true ");
bool relleno = Convert.ToBoolean(Console.ReadLine());

Console.Write("Cantidad de cuadrados: ");
int cantidad = Convert.ToInt16(Console.ReadLine());

int? contadorAncho = null;
int? contadorAlto = null;
int? contadorcantidad = null;
int ancho2 = ancho;

for (contadorcantidad = 1; contadorcantidad <= cantidad; contadorcantidad++)
{
    for (contadorAncho = 1; contadorAncho <= ancho; contadorAncho++)
    {
        if (contadorAncho == 1)
        {
            Console.Write("\n@");
        }
        else { Console.Write("@"); };
    }

    for (contadorAlto = 1; contadorAlto <= alto - 2; contadorAlto++)
    {
        for (int contador2 = ancho2; contador2 >= 1; contador2--)
        {
            if (contador2 == ancho2)
            {
                Console.Write("\n@");
            }

            else if (contador2 == 1)
            {
                Console.Write("@");
            }
            else
                if (relleno == true)
            {
                Console.Write("@");
            }
                else { Console.Write(" "); }

        }
    }
    for (contadorAncho = 1; contadorAncho <= ancho; contadorAncho++)
    {
        if (contadorAncho == 1)
        {
            Console.Write("\n@");
        }
        else { Console.Write("@"); }
    }
    Console.Write("\n\n");
}