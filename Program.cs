Console.WriteLine("Ingrese el nombre del estudiante: ");
string nombreIngresado = Console.ReadLine();

double[] notasIngresadas = new double[3];

for (int i = 0; i < notasIngresadas.Length; i++)
{
    double nota;
    Console.Write($"Ingrese la nota {i + 1} (0-10): ");
    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
    {
        Console.Write("Por favor, ingrese una nota válida entre 0 y 10: ");
    }
    notasIngresadas[i] = nota;
}

// Crear Objeto Usando Constructores
Estudiante alumno = new Estudiante(nombreIngresado, notasIngresadas);

double prom = alumno.CalcularPromedio();
string estado = (prom >= 6) ? "aprobado/a" : "reprobado/a";

Console.WriteLine($"\n{alumno.Nombre} tiene un promedio de {prom:F2} y está {estado}.");

//creamos Clases
class Estudiante
{
    public string Nombre { get; set; }
    public double[] Notas { get; set; }

    // Constructor
    public Estudiante(string nombre, double[] notas)
    {
        Nombre = nombre;
        Notas = notas;
    }

    // Método para Calcular Promedio
    public double CalcularPromedio()
    {
        double suma = 0;
        foreach (double nota in Notas)
        {
            suma += nota;
        }
        return suma / Notas.Length;
    }
}