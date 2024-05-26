using System;
using MathLibrary;
namespace MathConsoleApp


{
    class Program
    {
        static void MostrarMenu(){
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
        }
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();
            bool exit = false;
            while (!exit)
            {
                MostrarMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1"://sumar
                        Console.WriteLine("Ingrese el primer número:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {mathOps.Sumar(a, b)}");
                        break;
                    case "2"://resta
                        Console.WriteLine("Ingrese el primer número:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {mathOps.Restar(a, b)}");
                        break;
                    case "3"://multiplicar
                        Console.WriteLine("Ingrese el primer número:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {mathOps.Multiplicar(a, b)}");
                        break;
                    case "4"://dividir
                        Console.WriteLine("Ingrese el primer número:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        b = double.Parse(Console.ReadLine());
                        if (b != 0)
                        {
                        Console.WriteLine($"Resultado: {mathOps.Dividir(a, b)}");
                        }
                        else
                        {
                        Console.WriteLine("Error: División por cero.");
                        }
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
