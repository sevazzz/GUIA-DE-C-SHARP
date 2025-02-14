using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {

        //Ejercicio 4: "Promedio de tres números"
        //Objetivo: Practicar el cálculo de promedios y el uso de variables numéricas.

        Console.WriteLine("PROMEDIO DE 3 NÚMEROS");

        //DECLARAMOS LAS VARIABLES DOUBLE
        double nota1;
        double nota2;
        double nota3;
        double promedio;

        //LE SOLICITAMOS AL USUARIO QUE LE ASIGNE UN VALOR A LAS VARIABLES "NOTA"
        Console.Write("INTRODUZCA SU PRIMERA NOTA: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.Write("INTRODUZCA SU SEGUNDA NOTA: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.Write("INTRODUZCA SU TERCERA NOTA: ");
        nota3 = double.Parse(Console.ReadLine());

        //CALCULAMOS EL PROMEDIO DE LOS VALORES SUMANDOLO Y DIVIDIENDOLO POR LOS 3 VALORES
        promedio = (nota1 + nota2 + nota3) / 3;
       
        //MOSTRAMOS EL RESULTADO DEL PROMEDIO
        Console.WriteLine("SU PROMEDIO ES: " + promedio);
        Console.ReadLine();
    }
}