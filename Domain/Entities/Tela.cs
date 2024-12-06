namespace Domain.Entities;

public class Tela
{
    public int IdTela { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string MaterialPrincipal { get; set; } = string.Empty;
    public double PorcentajeUso { get; set; }   
    public ICollection<Ropa> Ropas { get; set; } = [];
}
