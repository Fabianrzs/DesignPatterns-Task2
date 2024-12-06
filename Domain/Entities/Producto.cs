namespace Domain.Entities;

public abstract class Producto
{
    public int IdProducto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int IdCategoria { get; set; }
    public decimal PrecioBase { get; set; }
    public Categoria Categoria { get; set; } = new();   
}
