int num1 = 1;
int num2 = 2;
Console.WriteLine(num1);
Console.WriteLine(num2);
int siguiente = num1 + num2;
Console.WriteLine(siguiente);
 for (int i = 0; i < 10; i++)
{
    num1 = num2;
    num2 = siguiente;
    Console.WriteLine(siguiente);
}