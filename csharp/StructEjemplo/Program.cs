//definicion del record
record EstudianteRecord(string Nombre, int Edad, double Promedio);

class Program
{
    static void Main(string[] args)
    {
        // Inicialización
        var e1 = new EstudianteRecord("Juan", 20, 4.5);
        var e2 = new EstudianteRecord("Ana", 22, 4.8);
        var e3 = new EstudianteRecord("Luis", 19, 3.9);

        // Arreglo
        EstudianteRecord[] estudiantes = { e1, e2, e3 };

        // Recorrido
        Console.WriteLine("Lista de estudiantes (record):");
        foreach (var e in estudiantes)
        {
            Console.WriteLine(e);
        }

        // Modificación (forma correcta en record)
        estudiantes[1] = estudiantes[1] with { Promedio = 4.9 };

        Console.WriteLine("\nDespués de modificar:");
        foreach (var e in estudiantes)
        {
            Console.WriteLine(e);
        }
    }
}
