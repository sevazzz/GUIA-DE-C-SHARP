internal class Program
{
    private static void Main(String[] Args)
    {
        //Ejercicio 3: Intercambio de valores
        //Objetivo: Practicar la manipulación de valores de variables.

        { Console.WriteLine("INTERCAMBIO DE VALORES DE VARIABLES"); }

        //DECLARAMOS VARIABLES "INT" QUE VAMOS A UTILIZAR PARA INTERCAMBIAR
        int a;
        int b;

        //LE PEDIMOS AL USUARIO QUE AGREGE UN VALOR A LAS VARIABLES "INT" (A Y B)
        Console.Write("INGRESE EL PRIMER VALOR DE SU VARIABLE, A: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("INGRESE EL SEGUNDO VALOR DE SU VARIABLE, B: ");
        b = int.Parse(Console.ReadLine());

        //INVERTIMOS EL VALOR DE LAS VARIABLES
        (a, b) = (b, a);

        //MOSTRAMOS EL RESULTADO DE LAS VARIABLES "A" Y "B" INVERTIDAS
        Console.WriteLine("AHORA EL VALOR DE LA VARIABLE A ES: " + a);
        Console.WriteLine("AHORA EL VALOR DE LA VARIABLE B ES: " + b);
    }
}