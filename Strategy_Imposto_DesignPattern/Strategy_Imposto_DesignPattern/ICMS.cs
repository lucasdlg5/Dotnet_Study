using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Imposto_DesignPattern
{
    class ICMS : Imposto
    {
        public double calculaImposto(Orcamento orcamento)
        {
            return orcamento.valor * 0.06;
        }
    }
}
