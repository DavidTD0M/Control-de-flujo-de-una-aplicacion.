using System;

{
    // Área del triángulo: (base * altura) / 2
    public static double AreaTriangulo(double baseTriangulo, double altura)
    {
        return (baseTriangulo * altura) / 2;
    }

    // Área del cuadrado: lado * lado
    public static double AreaCuadrado(double lado)
    {
        return lado * lado;
    }
}

// Área del círculo: PI * radio * radio
public static double AreaCirculo(double radio)
{
    return Math.PI * radio * radio;
}

// Verificar si una persona es mayor o menor de edad
public static string VerificarEdad(int edad)
{
    if (edad >= 18)
    {
        return "Mayor de edad";
    }
    else
    {
        return "Menor de edad";
    }
}

public class Programa
{
    public static double AreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    public static string VerificarEdad(int edad)
    {
        return edad >= 18 ? "Mayor de edad" : "Menor de edad";
    }

    public static void Main()
    {
        double resultadoCirculo = AreaCirculo(5);
        Console.WriteLine("Área del círculo: " + resultadoCirculo);

        string resultadoEdad = VerificarEdad(20);
        Console.WriteLine("Resultado de edad: " + resultadoEdad);

        string resultadoEdad2 = VerificarEdad(15);
        Console.WriteLine("Resultado de edad: " + resultadoEdad2);
    }
}




