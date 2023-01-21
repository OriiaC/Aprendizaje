/*Pida datos a un cliente: Nombre, email, cupón
Determine si un cliente tiene un cupon descuento
Muestre un precio rebajado en función del descuento
Muestre el precio de un producto sin descuento si no hay cupón
Nota: puedes poner un precio fijo de un producto o uno variable.*/


int valorProducto = 100;
int dctoCupon = 30;
Console.Write("Ingrese su nombre: ");
string? name = Convert.ToString(Console.ReadLine());

Console.Write("Ingrese su email: ");
string? email = Convert.ToString(Console.ReadLine());

Console.Write("Tiene cupon? True/False: ");
bool? cupon = Convert.ToBoolean(Console.ReadLine());

if (cupon == true)
{
    Console.WriteLine("Sr/Sra " + name + " usted tiene un cupon de descuento del " + dctoCupon + "%, el total a pagar es de $" + ((100 - (dctoCupon * valorProducto) / 100)));
}
else
{
    Console.WriteLine("Sr/Sra " + name + " usted no tiene cupon de descuento, el total a pagar es de $" + valorProducto);
}