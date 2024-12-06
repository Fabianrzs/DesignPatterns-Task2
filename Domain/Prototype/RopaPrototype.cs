namespace Domain.Prototype;

public class RopaPrototype : ProductoPrototype
{
    public string Color { get; set; } = string.Empty;
    public string Talla { get; set; } = string.Empty;

    public override ProductoPrototype Clonar()
    {
        return (ProductoPrototype)this.MemberwiseClone();
    }
}
