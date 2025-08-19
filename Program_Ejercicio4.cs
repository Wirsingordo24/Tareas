using System;

class Program
{
    // 1️⃣ Método que devuelve el producto de dos números
    static int CalcularProducto(int a, int b)
    {
        return a * b;
    }

    // 2️⃣ Método que calcula el área de un rectángulo
    static int CalcularArea(int ancho, int alto)
    {
        return ancho * alto;
    }

    // 3️⃣ Método que verifica si un número es par o impar
    static string EsParOImpar(int numero)
    {
        return (numero % 2 == 0) ? "Par" : "Impar";
    }

    // 4️⃣ Método que calcula el valor total del producto
    static double CalcularTotal(double precio, int cantidad)
    {
        return precio * cantidad;
    }

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== EJERCICIOS #4 – MÉTODOS EN C# =====");
            Console.WriteLine("1) Calcular producto de dos números");
            Console.WriteLine("2) Calcular área de un rectángulo");
            Console.WriteLine("3) Verificar si un número es par o impar");
            Console.WriteLine("4) Calcular total de un producto");
            Console.WriteLine("5) Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            Console.Clear();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el primer número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El producto es: {CalcularProducto(n1, n2)}");
                    break;

                case "2":
                    Console.Write("Ingrese el ancho del rectángulo: ");
                    int ancho = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el alto del rectángulo: ");
                    int alto = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El área del rectángulo es: {CalcularArea(ancho, alto)}");
                    break;

                case "3":
                    Console.Write("Ingrese un número: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El número {numero} es {EsParOImpar(numero)}.");
                    break;

                case "4":
                    Console.Write("Ingrese la descripción del producto: ");
                    string descripcion = Console.ReadLine();
                    Console.Write("Ingrese el precio unitario: ");
                    double precio = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    double total = CalcularTotal(precio, cantidad);
                    Console.WriteLine();
                    Console.WriteLine($"Producto: {descripcion}");
                    Console.WriteLine($"Precio: Q{precio} | Cantidad: {cantidad}");
                    Console.WriteLine($"Total a pagar: Q{total}");
                    break;

                case "5":
                    Console.WriteLine("¡Gracias por usar el programa!");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
