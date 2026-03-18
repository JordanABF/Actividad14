class Empleado
{
    public string Nombre;
    public string Puesto;
    public double SalarioMensual;
    public double CalcularSalarioAnual() { return SalarioMensual * 12; }
    public double CalcularBono()
    {
        if (SalarioMensual >= 5000) return SalarioMensual * 0.15;
        else return SalarioMensual * 0.08;
    }
    public string ClasificarSalario()
    {
        if (SalarioMensual >= 7000) return "Salario alto";
        else if (SalarioMensual >= 4000) return "Salario medio";
        else return "Salario básico";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} | Puesto: {Puesto}");
        Console.WriteLine($"Salario mensual: Q{SalarioMensual:F2} | Salario anual: Q{CalcularSalarioAnual():F2}");
        Console.WriteLine($" Bono: Q{ CalcularBono():F2} | Nivel: { ClasificarSalario()}");
    }
}
