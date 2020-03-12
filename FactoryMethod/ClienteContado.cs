using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public sealed class ClienteContado : Cliente
    {
        protected override Pedido CrearPedido(double importe) => new PedidoContado(importe);
    }
}
