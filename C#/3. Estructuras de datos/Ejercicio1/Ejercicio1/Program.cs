/*Crea una estructura de datos para un cliente con estos campos:
Nombre completo
Teléfono
Dirección
Email
Si es nuevo cliente
Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)*/

using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
Cliente nuevocliente = new Cliente("Edison", 3132661099, "Mz 48 casa 38 San Joaquin", "edison_agudelo@hotmail.com", false);
Console.WriteLine(nuevocliente);
public struct Cliente
{
    public Cliente(string nombreCompleto, long telefono, string direccion, string email, bool nuevoCliente)
    {
     
        N = nombreCompleto;
        T = telefono;
        D = direccion;
        E = email;
        NC = nuevoCliente;
    }
    public string N { get; set; }
    public long T { get; set; }
    public string D { get; set; }
    public string E { get; set; }
    public bool NC { get; set; }

    //public override string ToString() => $"({N}, {T}, {D}, {E}, {NC})";
    public override string ToString()
    {
        return "Su nombre es: "+N+", su telefono es: "+T+", su direccion es: "+D+", su email es: "+E+", nuevo cliente: "+NC;
    }
}