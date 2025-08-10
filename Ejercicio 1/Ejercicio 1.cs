using System;

class Ejercicio1
{
    static void Main()
    {
        Console.Write("Primer número:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Segundo número:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"La suma es: {a + b}");
    }
}
