using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_E5
{
    interface IEntregable
    {
        void Entregar();
        void Devolver();
        bool Entregador();
        object CompararCon(Object a);
    }
}
