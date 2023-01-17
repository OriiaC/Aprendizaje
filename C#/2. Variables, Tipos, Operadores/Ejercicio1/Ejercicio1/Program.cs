/*Variables Escribe un programa que reciba datos de una persona y genera un mensaje, 
usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.*/

Console.Write("Digita tu nombre: ");
string? nombre =Console.ReadLine();
Console.Write("Digita tu apellido: ");
string? apellido = Console.ReadLine();
Console.Write("Digita tu edad: ");
int? edad = Convert.ToInt32(Console.ReadLine());
Console.Write("Digita tu telefono celular: ");
long? telefonoC = Convert.ToInt64(Console.ReadLine());
Console.Write("Digita tu direccion: ");
string? direccion = Console.ReadLine();
Console.Write("Digita tu ciudad: ");
string? ciudad = Console.ReadLine();
Console.Write("Digita tu pais: ");
string? pais = Console.ReadLine();
Console.Write("Digita tu correo: ");
string? correo = Console.ReadLine();
Console.Write("sabes programar? Si/No: ");
string? programador = (Console.ReadLine());
Console.Write("Eres hombre o mujer? Hombre/Mujer: ");
string? genero = (Console.ReadLine());
string mensaje = "Hola, "+nombre+" "+apellido+", tienes "+edad+" años y tu telefono celular es: "+telefonoC+", vives en la direccion: "+direccion+" en "+ciudad+"-"+pais+" y tu correo electronico es: "+ correo+", "+programador+" sabes programar y eres "+genero;
Console.WriteLine(mensaje);