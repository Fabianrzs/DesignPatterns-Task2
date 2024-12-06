namespace Domain.Entities;

public class Pedido
{
    public int IdPedido { get; set; }
    public int IdCliente { get; set; }
    public string Estado { get; set; } = string.Empty;
    public ICollection<Producto> Productos { get; set; } = [];
    public Cliente Cliente { get; set; } = new();
}
