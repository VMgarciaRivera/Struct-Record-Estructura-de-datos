// Definición de la clase
class Estudiante {
    nombre: string;
    edad: number;
    promedio: number;

    constructor(nombre: string, edad: number, promedio: number) {
        this.nombre = nombre;
        this.edad = edad;
        this.promedio = promedio;
    }

    // Método para mostrar información
    mostrarInfo(): void {
        console.log(`Nombre: ${this.nombre}, Edad: ${this.edad}, Promedio: ${this.promedio}`);
    }

    // Método para modificar promedio
    setPromedio(nuevoPromedio: number): void {
        this.promedio = nuevoPromedio;
    }
}

// Inicialización
const e1 = new Estudiante("Juan", 20, 4.5);
const e2 = new Estudiante("Ana", 22, 4.8);
const e3 = new Estudiante("Luis", 19, 3.9);

// Arreglo
const estudiantes: Estudiante[] = [e1, e2, e3];

// Recorrido
console.log("Lista de estudiantes:");
estudiantes.forEach(e => e.mostrarInfo());

// Modificación
estudiantes[1].setPromedio(4.9);

console.log("\nDespués de modificar:");
estudiantes.forEach(e => e.mostrarInfo());