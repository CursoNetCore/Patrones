using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Cliente
    {
        protected List<Pedido> pedidos = new List<Pedido>();

        protected abstract Pedido CrearPedido(double importe);
        public void NuevoPedido(double importe)
        {
            Pedido pedido = CrearPedido(importe);
            if(pedido.Valida())
            {
                pedido.Paga();
                pedidos.Add(pedido);
            }
        }
    }
}
