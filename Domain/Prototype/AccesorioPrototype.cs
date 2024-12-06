namespace Domain.Prototype;

public class AccesorioPrototype : ProductoPrototype
{
    public string NombreDiseñador { get; set; } = string.Empty;
    public override ProductoPrototype Clonar()
    {
        return (ProductoPrototype)this.MemberwiseClone();
    }
}
