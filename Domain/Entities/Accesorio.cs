namespace Domain.Entities;

public class Accesorio : Producto
{
    public string NombreDiseniador { get; set; } = string.Empty;    
    public DateTime FechaElaboracion { get; set; }
    public string Material { get; set; } = string.Empty;    
}
