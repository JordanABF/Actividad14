
class producto
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
}
