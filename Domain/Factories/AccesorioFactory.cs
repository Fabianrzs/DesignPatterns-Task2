using Domain.Entities;

namespace Domain.Factories;

public class AccesorioFactory : ProductoFactory
{
    public override Producto CrearProducto()
    {
        return new Accesorio();
    }
}
