using Domain.Entities;

namespace Domain.Builder;

public class CalzadoBuilder : IProductoBuilder
{
    private readonly Calzado calzado = new();

    public void SetNombre(string nombre)
    {
        calzado.Nombre = nombre;
    }

    public void SetPrecio(decimal precio)
    {
        calzado.PrecioBase = precio;
    }

    public void SetCierre(string cierre)
    {
        calzado.Cierre = cierre;
    }

    public void SetSuela(string suela)
    {
        calzado.Suela = suela;
    }

    public void SetCapella(string nombreTela)
    {
        calzado.Capellada = nombreTela;
    }
    public Producto Build()
    {
        return calzado;
    }
}

