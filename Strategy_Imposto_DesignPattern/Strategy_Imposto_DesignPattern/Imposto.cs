using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Imposto_DesignPattern
{
    public interface Imposto
    {
        public double calculaImposto(Orcamento orcamento);
    }
}
