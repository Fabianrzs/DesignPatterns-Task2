using Domain.Entities;

namespace Domain.Services;

public class PedidoManager
{
    private static PedidoManager _instancia = new();
    private static readonly object _lock = new();
    private readonly List<Pedido> pedidos = [];

    private PedidoManager() { }

    public static PedidoManager Instancia
    {
        get
        {
            lock (_lock)
            {
                _instancia ??= new PedidoManager();
                return _instancia;
            }
        }
    }

    public void AgregarPedido(Pedido pedido)
    {
        pedidos.Add(pedido);
    }

    public List<Pedido> ObtenerPedidos()
    {
        return pedidos;
    }
}
