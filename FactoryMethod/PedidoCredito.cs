using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PedidoCredito : Pedido
    {
        public PedidoCredito(double importe) : base(importe)
        {
        }

        public override void Paga()
        {
            Console.WriteLine(string.Format("El pago del pedido a credito de: {0} se ha realizado", importe));
        }

        public override bool Valida() => importe >= 1000 && importe <= 5000;
    }
}
