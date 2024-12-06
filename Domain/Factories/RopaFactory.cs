using Domain.Entities;

namespace Domain.Factories;

public class RopaFactory : ProductoFactory
{
    public override Producto CrearProducto()
    {
        return new Ropa();
    }
}
