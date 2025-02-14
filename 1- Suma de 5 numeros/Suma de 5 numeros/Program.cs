internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio 1: "Suma de 5 números"
        //Objetivo: Practicar la declaración de variables numéricas y operaciones matemáticas básicas.

        { Console.WriteLine("SUMA DE 5 NÚMEROS"); }

        //DECLARACIÓN DE VARIABLES TIPO ENTERO "INT" PARA SUMAR

        int suma1, suma2, suma3, suma4, suma5, total;  //DECLARAMOS LAS DE UNA VARIABLE EN UNA SOLA LÍNEA


        Console.WriteLine("Introduce el primer número que quieres sumar: ");
        suma1= int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número que quieres sumar: ");
        suma2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el tercer número que quieres sumar: ");
        suma3 = int.Parse(Console.ReadLine());                                      //Solicitamos al usuraio introducir los números que desea sumar

        Console.WriteLine("Introduce el cuarto número que quieres sumar: ");
        suma4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el ultimo número que quieres sumar: ");
        suma5 = int.Parse(Console.ReadLine());

        total = suma1 + suma2 + suma3 + suma4 + suma5; //ADJUNTAMOS LAS VARIABLES "SUMA" A LA VARIABLE "TOTAL" PARA OBTENER LA SUMA TOTAL.

        Console.WriteLine("La suma es: " + total); //NOS PRESENTA EL TOTAL DE LAS SUMAS
    }
    }