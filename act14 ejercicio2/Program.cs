
class Producto
{
    public string Nombre;
    public double Precio;
    public int Cantidad;

    public double calcularvalorinventario()
    {
        return Precio * Cantidad;
    }
    public string evaluarstock()
    {
        if (Cantidad == 0)
        {
            return "SIN EXISTENCIA";
        }
        else if (Cantidad <= 5)
        {
            return "STOCK BAJO";
        }
        else
        {
            return "STOCK SUFICIENTE";
        }
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Producto: {Nombre} | Precio: Q{Precio:F2} | Cantidad: {Cantidad} | Total: Q{calcularvalorinventario():F2} | Estado: {evaluarstock()}");
    }
}

List<Producto> productos = new List<Producto>();
Console.WriteLine("¿CUÁNTOS PRODUCTOS DESEA INGRESAR?");
int cantidad=int.Parse(Console.ReadLine());

for (int i = 0; i < cantidad; i++)
{
    Producto p = new Producto();
    Console.WriteLine($"INGRESE EL NOMBRE DEL PRODUCTO {i + 1}: "); p.Nombre = Console.ReadLine();
    Console.WriteLine("PRECIO: "); p.Precio = double.Parse(Console.ReadLine());
    Console.WriteLine("CANTIDAD: "); p.Cantidad = int.Parse(Console.ReadLine());
    productos.Add(p);
}

double totalInventario = 0;
Producto MasCostoso = productos[0];
Console.WriteLine("--INVENTARIO--");
foreach (Producto p in productos)
{
    p.MostrarDatos();
    totalInventario += p.calcularvalorinventario();
    if (p.Precio > MasCostoso.Precio)
    {
        MasCostoso = p;
    }
}

Console.WriteLine($"VALOR TOTAL DEL INVENTARIO: Q{totalInventario:F2}");
Console.WriteLine("PRODUCTO MÁS COSTOSO:");
MasCostoso.MostrarDatos();
