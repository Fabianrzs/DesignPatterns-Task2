namespace Domain.Entities;

public class Marca
{
    public int IdMarca { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Pais { get; set; } = string.Empty;
    public ICollection<Ropa> Ropas { get; set; } = [];
}