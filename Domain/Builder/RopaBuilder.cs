using Domain.Entities;

namespace Domain.Builder;

public class RopaBuilder : IProductoBuilder
{
    private readonly Ropa ropa = new();

    public void SetNombre(string nombre)
    {
        ropa.Nombre = nombre;
    }

    public void SetPrecio(decimal precio)
    {
        ropa.PrecioBase = precio;
    }

    public void SetColor(string color)
    {
        ropa.Color = color;
    }

    public void SetTalla(string talla)
    {
        ropa.Talla = talla;
    }

    public void SetNombreTela(string nombreTela)
    {
        ropa.Tela.Nombre = nombreTela;
    }

    public void SetPorcentajeUsoTela(double porcentajeUsoTela)
    {
        ropa.Tela.PorcentajeUso = porcentajeUsoTela;
    }

    public void SetMaterialPrincipalTela(string materialPrincipalTela)
    {
        ropa.Tela.MaterialPrincipal = materialPrincipalTela;
    }

    public void SetNombreMarca(string nombreMarca)
    {
        ropa.Marca.Nombre = nombreMarca;
    }

    public void SetPaisMarca(string paisMarca)
    {
        ropa.Marca.Pais = paisMarca;
    }

    public Producto Build()
    {
        return ropa;
    }
}

