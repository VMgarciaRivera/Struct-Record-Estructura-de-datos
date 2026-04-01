// Definición del "struct" usando type
type Estudiante = {
    nombre: string;
    edad: number;
    promedio: number;
};

// Inicialización
const e1: Estudiante = { nombre: "Juan", edad: 20, promedio: 4.5 };
const e2: Estudiante = { nombre: "Ana", edad: 22, promedio: 4.8 };
const e3: Estudiante = { nombre: "Luis", edad: 19, promedio: 3.9 };

// Arreglo
const estudiantes: Estudiante[] = [e1, e2, e3];

// Recorrido
console.log("Lista de estudiantes:");
estudiantes.forEach(e => {
    console.log(`Nombre: ${e.nombre}, Edad: ${e.edad}, Promedio: ${e.promedio}`);
});

// Modificación
estudiantes[1].promedio = 4.9;

console.log("\nDespués de modificar:");
estudiantes.forEach(e => {
    console.log(`Nombre: ${e.nombre}, Edad: ${e.edad}, Promedio: ${e.promedio}`);
});