public class Main {
    public static void main(String[] args) {
        Cliente cliente = new Cliente();
        Trabajador trabajador = new Trabajador();
        //Crea ahora un objeto de la clase Cliente
        //que debe tener como propiedades la edad, el telefono,
        //el nombre y el credito, tienes que darles valor y mostrarlas por pantalla.
        cliente.setNombre("Edison");
        System.out.println("Nombre del cliente: "+cliente.getNombre());

        cliente.setEdad(27);
        System.out.println("Edad del cliente: "+cliente.getEdad());

        cliente.setTelefono(7928833);
        System.out.println("Numero de telefono del cliente: "+cliente.getTelefono());

        cliente.setCredito(10000);
        System.out.println("El credito del cliente es de: "+cliente.getCredito());

        //Una vez hecho esto, haz lo mismo con la clase Trabajador que herede de Persona,
        //y con una variable salario que solo tenga la clase Trabajador.
        trabajador.setSalario(200);
        System.out.println("El salario del trabajador es de: "+trabajador.getSalario());


    }
    static class Persona {
        int edad;
        String nombre;
        int telefono;

        public void setEdad(int edad){
            this.edad = edad;
        }
        public int getEdad(){
            return this.edad;
        }

        public void setNombre(String nombre){
            this.nombre = nombre;
        }
        public String getNombre(){
            return this.nombre;
        }

        public void setTelefono(int telefono){
            this.telefono = telefono;
        }
        public int getTelefono(){
            return this.telefono;
        }

    }
    static class Cliente extends Persona{
        int credito;

        public void setCredito(int credito){
            this.credito = credito;
        }
        public int getCredito(){
            return this.credito;
        }
    }

    static class Trabajador extends Cliente{
        int salario;
        public void setSalario(int salario){
            this.salario = salario;
        }
        public int getSalario(){
            return this.salario;
        }

    }
}