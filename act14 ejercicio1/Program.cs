
class Estudiante
{
    public string Nombre;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double calcularPromedio()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }
    public string obtenerestado()
    {
        if (calcularPromedio() >= 61)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }

    public void mostrardatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Promedio: {calcularPromedio():F2}");
        Console.WriteLine($"Estado: {obtenerestado()}");
    }
}

List<Estudiante> estudiantes = new List<Estudiante>();
Console.WriteLine("CUANTOS ESTUDIANTES DESEA INGRESAR");
int cantidad = int.Parse(Console.ReadLine());

for(int i=0; i<cantidad;i++)
{
    Estudiante e=new Estudiante();
    Console.WriteLine($"INGRESE EL NOMBRE DEL ESTUDIANTE {i+1}: "); e.Nombre=Console.ReadLine();
    Console.WriteLine("NOTA 1: "); e.Nota1=double.Parse(Console.ReadLine());
    Console.WriteLine("NOTA 2: "); e.Nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine("NOTA 3: "); e.Nota3 = double.Parse(Console.ReadLine());
    estudiantes.Add(e);
}

double sumaPromedios = 0;
Estudiante mejorEstudiante = estudiantes[0];
Console.WriteLine("LISTA DE ESTUDIANTES:");
foreach(Estudiante e in estudiantes)
{
    e.mostrardatos();
    sumaPromedios += e.calcularPromedio();
    if(e.calcularPromedio() > mejorEstudiante.calcularPromedio())
    {
        mejorEstudiante = e;
    }
}
Console.WriteLine("EL PROMEDIO GENERAL ES: " + (sumaPromedios / estudiantes.Count):F2);
Console.WriteLine("EL MEJOR ESTUDIANTE ES: ");
mejorEstudiante.mostrardatos();

