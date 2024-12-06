namespace Domain.Entities;

public class Ropa : Producto
{
    public int IdTela { get; set; }
    public int IdMarca { get; set; }
    public string Color { get; set; } = string.Empty;
    public string Talla { get; set; } = string.Empty;
    public Tela Tela { get; set; } = new();
    public Marca Marca { get; set; } = new();
}
