using CalculadoraDeDescontos.CalcularSalario.CalcularDescontos;

namespace Interface.CalcularSalario
{
    public static class CalcularSalarioLiquido
    {
        public static double CalcularSalario(double salarioBruto, double valeAlimentacao, double planoOdontologico, double planoSaude, bool valeTransporte) 
        {
            double descontoINSS = CalcularINSS.CalcularDescontoINSS(salarioBruto);

            double descontoValeTransporte = 0;

            if (valeTransporte)
            {
                descontoValeTransporte = CalcularValeTransporte.DescontoValeTransporte(salarioBruto);
            }

            return (salarioBruto - (valeAlimentacao + planoOdontologico + planoSaude + descontoINSS + descontoValeTransporte));
        }
    }
}
