//Definición de la clase
class Estudiante
{
    public required string Nombre { get; set; }
    public int Edad { get; set; }
    public double Promedio { get; set; }

    //Método para mostrar información
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Promedio: {Promedio}");
    }

    //Método para modificar el promedio
    public void SetPromedio(double nuevoPromedio)
    {
        Promedio = nuevoPromedio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Inicialización (instancias)
        Estudiante e1 = new Estudiante { Nombre = "Juan", Edad = 20, Promedio = 4.5 };
        Estudiante e2 = new Estudiante { Nombre = "Ana", Edad = 22, Promedio = 4.8 };
        Estudiante e3 = new Estudiante { Nombre = "Luis", Edad = 19, Promedio = 3.9 };

        //Lista de objetos
        Estudiante[] estudiantes = { e1, e2, e3 };

        //Recorrido llamando método
        Console.WriteLine("Lista de estudiantes:");
        foreach (var e in estudiantes)
        {
            e.MostrarInfo();
        }

        //Modificación usando método
        estudiantes[1].SetPromedio(4.9);

        Console.WriteLine("\nDespués de modificar:");
        foreach (var e in estudiantes)
        {
            e.MostrarInfo();
        }
    }
}