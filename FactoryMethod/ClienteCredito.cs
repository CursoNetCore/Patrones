using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public sealed class ClienteCredito : Cliente
    {
        protected override Pedido CrearPedido(double importe) => new PedidoCredito(importe);
    }
}
