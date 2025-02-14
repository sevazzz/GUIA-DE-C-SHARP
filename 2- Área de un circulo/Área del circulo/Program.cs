internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio 2: "Área del círculo"
        //Objetivo: Practicar el uso de tipos de datos double y el cálculo con operaciones matemáticas.

        { Console.WriteLine("ÁREA DEL CIRCULO"); }

        //DECLARAMOS LA VARIABLE "DOOUBLE" PARA OBTENER EL RADIO Y EL AREA

        double radio;
        double area;

        //SOLICITAMOS AL USURIO QUE INDIQUE EL RADIO DEL CIRCULO
        Console.WriteLine("Introduce el radio del circulo: ");
        radio= double.Parse (Console.ReadLine());


        //CALCULAMOS EL ÁREA DEL CIRCULO
        area = radio * radio * Math.PI;

        //OBTEMOS EL ÁREA DEL CIRCULO EN METROS CUADRADOS (M²)
        Console.WriteLine("El área del circulo es: " + area); 
    }
}