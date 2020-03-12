using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PedidoContado : Pedido
    {
        public PedidoContado(double importe) : base(importe)
        {
        }

        public override void Paga()
        {
            Console.WriteLine(string.Format("El pago del pedido por importe de: {0} se ha realizado", importe));
        }

        public override bool Valida()
        {
            return true;
        }
    }
}
