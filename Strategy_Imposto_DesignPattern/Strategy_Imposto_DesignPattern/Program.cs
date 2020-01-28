using System;

namespace Strategy_Imposto_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new ICMS();
            Imposto iss = new ISS();
            Orcamento orcamento = new Orcamento (500.00);
            CalculadorDeImposto calculador = new CalculadorDeImposto();
            calculador.realizaCalculoImposto(orcamento, iss);
            calculador.realizaCalculoImposto(orcamento, icms);
            Console.ReadKey();
        }
    }
}
