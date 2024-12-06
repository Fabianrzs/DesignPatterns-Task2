using Domain.Entities;

namespace Domain.Builder;

public interface IProductoBuilder
{
    void SetNombre(string nombre);
    void SetPrecio(decimal precio);
    Producto Build();
}