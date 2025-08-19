using System;

class Program
{
    // -------------------------------
    // 1) Método SIN PARÁMETROS
    // Verifica si una persona puede votar
    // -------------------------------
    static void VerificarVoto()
    {
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("✅ Puede votar.");
        else
            Console.WriteLine("❌ No puede votar.");
    }

    // -------------------------------
    // 2) Método CON RETORNO
    // Clasifica el día como inicio, mediados o fin de semana
    // -------------------------------
    static string ClasificarDia(int dia)
    {
        if (dia >= 1 && dia <= 2) return "Inicio de Semana";
        if (dia >= 3 && dia <= 5) return "Mediados de Semana";
        if (dia == 6 || dia == 7) return "Fin de Semana";
        return "Día inválido";
    }

    // -------------------------------
    // 3) Método CON PARÁMETRO
    // Muestra la tabla de multiplicar del número recibido
    // -------------------------------
    static void MostrarTabla(int numero)
    {
        Console.WriteLine($"\nTabla del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    // -------------------------------
    // APLICACIÓN PRINCIPAL (MENÚ)
    // -------------------------------
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== EJERCICIOS #2.1 =====");
            Console.WriteLine("1) Verificar si una persona puede votar");
            Console.WriteLine("2) Clasificar el día de la semana");
            Console.WriteLine("3) Mostrar la tabla del 7");
            Console.WriteLine("4) Salir");
            Console.Write("\nSeleccione una opción: ");
            string opcion = Console.ReadLine();

            Console.Clear();

            switch (opcion)
            {
                case "1":
                    // Método sin parámetros
                    VerificarVoto();
                    break;

                case "2":
                    // Método con retorno
                    Console.Write("Ingrese el número de día (1=Lunes ... 7=Domingo): ");
                    int dia = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultado: {ClasificarDia(dia)}");
                    break;

                case "3":
                    // Método con parámetro
                    MostrarTabla(7);
                    break;

                case "4":
                    Console.WriteLine("¡Hasta luego!");
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
