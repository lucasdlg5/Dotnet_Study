using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Imposto_DesignPattern
{
    public class CalculadorDeImposto
    {
        public void realizaCalculoImposto(Orcamento orcamento, Imposto imposto)
        {
            double valorCalculado = imposto.calculaImposto(orcamento);
            Console.WriteLine(valorCalculado);
        }
    }
}
