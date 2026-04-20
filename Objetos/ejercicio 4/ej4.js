const alumnos = [
    { nombre: "Lucas", nota: 8 },
    { nombre: "Sofía", nota: 9 },
    { nombre: "Martín", nota: 7 }
];
let mejor = alumnos[0];
for (let alumno of alumnos) {
    if (alumno.nota > mejor.nota) {
        mejor = alumno;
    }
}
console.log(mejor.nombre); 