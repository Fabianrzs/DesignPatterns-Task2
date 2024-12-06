using Domain.Builder;
using Domain.Entities;
using Domain.Factories;
using Domain.Prototype;
using Domain.Services;

ProductoFactory factory = new RopaFactory();
Producto producto = factory.CrearProducto();


RopaBuilder builder = new();
builder.SetNombre("Camiseta");
builder.SetPrecio(20);
builder.SetColor("Rojo");
Ropa ropaPersonalizada = (Ropa)builder.Build();


RopaPrototype ropaOriginal = new() { Color = "Azul", Talla = "M" };
RopaPrototype ropaClonada = (RopaPrototype)ropaOriginal.Clonar();


PedidoManager manager = PedidoManager.Instancia;
manager.AgregarPedido(new Pedido { Productos = [ropaPersonalizada], Estado = "En proceso" });

Console.WriteLine($"Producto creado: {producto.Nombre}, Precio: ${producto.PrecioBase}");
