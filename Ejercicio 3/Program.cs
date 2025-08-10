using System;

class Libro
{
    public string Nombre = "";
    public int año;
    public string Genero = "";
    public string Autor = "";

    public void Saludar()
    {
        Console.WriteLine($"El libro se llama {Nombre}, es del año {año}, es del género {Genero}, y su autor es {Autor}.");
    }
}

class Program
{
    static void Main()
    {
        Libro miLibro = new Libro();
        miLibro.Nombre = "Cien años de soledad";
        miLibro.año = 1967;
        miLibro.Genero = "Realismo mágico";
        miLibro.Autor = "Gabriel García Márquez";

        miLibro.Saludar();
    }
}
