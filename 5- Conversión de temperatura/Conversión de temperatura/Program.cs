using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio 5: "Conversión de temperatura"
        //Objetivo: Practicar la conversión entre diferentes unidades de medida.

        Console.WriteLine("CONVERSIÓN DE TEMPERATURA");

        //ASIGNAMOS VARIABLES DOUBLE LLAMADA F (FAHRENHEIT) Y C (CELSIUS)
        double f;
        double C;

        Console.Write("ASIGNE LOS GRADOS FAHRENHEIT QUE DESEE CONVERTIR A CELSIUS: ");
        f = double.Parse (Console.ReadLine());

        //CONVERTIMOS LOS GRADOS "F" A "C"
        C = (f - 32) * 5 / 9; 

        //MOSTRAMOS LA CONVERSIÓN DE LOS GRADOS "F" A "C"
        Console.Write("LOS GRADOS CELSIUS SON: "+C);
    }
}