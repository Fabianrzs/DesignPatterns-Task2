using Domain.Entities;

namespace Domain.Factories;

public class CalzadoFactory : ProductoFactory
{
    public override Producto CrearProducto()
    {
        return new Calzado();
    }
}
