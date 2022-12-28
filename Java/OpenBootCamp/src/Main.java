public class Main {
    public static void main(String[] args) {
        suma(1, 2, 3);
        Coche miCoche = new Coche(); /*Me genera error aca, no entiendo por que*/
        miCoche.ponerPuerta();
    }

    public static void suma(int Num1, int Num2, int Num3) {
        int Total = Num1 + Num2 + Num3;
        System.out.println(Total);
    }
class Coche {
    public int puertas = 5;

    public void ponerPuerta(){
        this.puertas++;
        System.out.println(puertas);
    }
    }
}