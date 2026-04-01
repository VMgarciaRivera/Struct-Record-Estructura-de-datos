// Definición del struct
struct Estudiante
{
    public string Nombre;
    public int Edad;
    public double Promedio;
}

class Program
{
    static void Main(string[] args)
    {
        // Inicialización de datos
        Estudiante e1 = new Estudiante { Nombre = "Juan", Edad = 20, Promedio = 4.5 };
        Estudiante e2 = new Estudiante { Nombre = "Ana", Edad = 22, Promedio = 4.8 };
        Estudiante e3 = new Estudiante { Nombre = "Luis", Edad = 19, Promedio = 3.9 };

        // Guardar en un arreglo
        Estudiante[] estudiantes = { e1, e2, e3 };

        // Recorrido del arreglo
        Console.WriteLine("Lista de estudiantes:");
        foreach (var e in estudiantes)
        {
            Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}, Promedio: {e.Promedio}");
        }

        // Modificación de un dato
        estudiantes[1].Promedio = 4.9;

        Console.WriteLine("\nDespués de modificar el promedio:");
        foreach (var e in estudiantes)
        {
            Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}, Promedio: {e.Promedio}");
        }
    }
}
