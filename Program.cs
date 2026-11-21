// Área del triángulo: (base * altura) / 2
static double AreaTriangulo(double baseTriangulo, double altura)
{
    return (baseTriangulo * altura) / 2;
}

// Área del cuadrado: lado * lado
static double AreaCuadrado(double lado)
{
    return lado * lado;
}

// Área del círculo: PI * radio * radio
static double AreaCirculo(double radio)
{
    return Math.PI * radio * radio;
}

// Verificar si una persona es mayor o menor de edad
static string VerificarEdad(int edad)
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

// Menu interactivo
Console.WriteLine("=== Menú ===");
Console.WriteLine("1. Calcular área de un triángulo");
Console.WriteLine("2. Calcular área de un cuadrado");
Console.WriteLine("3. Calcular área de un círculo");
Console.WriteLine("4. Verificar edad");
Console.WriteLine("5. Salir");
Console.Write("Seleccione una opción:");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:

        Console.Write("Ingrese la base del triángulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del triángulo:");
        double altura = Convert.ToDouble(Console.ReadLine());
        
        while (baseTriangulo <= 0 || altura <= 0)
        {
            Console.WriteLine("(!) La base y la altura deben ser mayores que cero.");
            Console.Write("Ingrese la base del triángulo:");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo:");
            altura = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("El área del triángulo es: " + AreaTriangulo(baseTriangulo, altura));
        break;
    
    case 2:
        Console.Write("Ingrese el lado del cuadrado:");
        double lado = Convert.ToDouble(Console.ReadLine());

        while (lado <= 0)
        {
            Console.WriteLine("(!) El lado debe ser mayor que cero.");
            Console.Write("Ingrese el lado del cuadrado:");
            lado = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("El área del cuadrado es: " + AreaCuadrado(lado));
        break;

    case 3:
        Console.Write("Ingrese el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        while (radio <= 0)
        {
            Console.WriteLine("(!) El radio debe ser mayor que cero.");
            Console.Write("Ingrese el radio del círculo:");
            radio = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("El área del círculo es: " + AreaCirculo(radio));
        break;
    
    case 4:
        Console.Write("Ingrese la edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        while (edad < 0)
        {
            Console.WriteLine("(!) La edad debe ser un número positivo.");
            Console.Write("Ingrese la edad:");
            edad = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("La persona es: " + VerificarEdad(edad));
        break;
    
    case 5:
        Console.WriteLine("Saliendo...");
        break;
    
    default:
        Console.WriteLine("(!) Opción no válida.");
        break;
}
