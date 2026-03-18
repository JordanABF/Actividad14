
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

