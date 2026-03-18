
List<Empleado> empleados = new List<Empleado>();
Console.Write("¿Cuántos empleados desea registrar?: ");
int numero = int.Parse(Console.ReadLine());
for (int i = 0; i < numero; i++)
{
    Empleado emp = new Empleado();
    Console.WriteLine($"Empleado {i + 1}");
    Console.Write("Nombre: "); emp.Nombre = Console.ReadLine();
    Console.Write("Puesto: "); emp.Puesto = Console.ReadLine();
    Console.Write("Salario mensual: "); emp.SalarioMensual = double.Parse(Console.ReadLine());
    empleados.Add(emp);
}
Console.WriteLine("--- LISTADO DE EMPLEADOS ---");
foreach (Empleado emp in empleados)
{
    emp.MostrarDatos();
}
class Empleado
{
    public string Nombre;
    public string Puesto;
    public double SalarioMensual;
    public double CalcularSalarioAnual() { return SalarioMensual * 12; }
    public double CalcularBono()
    {
        if (SalarioMensual >= 5000) 
            return SalarioMensual * 0.15;
        else 
            return SalarioMensual * 0.08;
    }
    public string ClasificarSalario()
    {
        if (SalarioMensual >= 7000)
            return "Salario alto";
        else if (SalarioMensual >= 4000)
            return "Salario medio";
        else
            return "Salario básico";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} | Puesto: {Puesto}");
        Console.WriteLine($"Salario mensual: Q{SalarioMensual:F2} | Salario anual: Q{CalcularSalarioAnual():F2}");
        Console.WriteLine($" Bono: Q{ CalcularBono():F2} | Nivel: { ClasificarSalario()}");
    }
}

