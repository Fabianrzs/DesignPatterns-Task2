namespace Domain.Entities;

public class Ciudad
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int DepartamentoId { get; set; }
    public Departamento Departamento { get; set; } = new();
}
