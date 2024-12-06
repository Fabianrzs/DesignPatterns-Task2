namespace Domain.Entities;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Identificacion { get; set; } = string.Empty;
    public int CiudadId { get; set; }
    public Ciudad Ciudad { get; set; } = new();
    public ICollection<Pedido> Pedidos { get; set; } = [];
}
