namespace CalculadoraDeDescontos.CalcularSalario.CalcularDescontos
{
    public static class CalcularINSS
    {
        public static double CalcularDescontoINSS(double salarioBruto)
        {
            double descontoINSS;
            if (salarioBruto <= 1412.00)
            {
                descontoINSS = (0.075 * salarioBruto);
            }
            else if (salarioBruto >= 1412.01 && salarioBruto <= 2666.68)
            {
                descontoINSS = 105.9 + (salarioBruto - 1412) * 0.09;
            }
            else if (salarioBruto >= 2666.68 && salarioBruto <= 3856.94)
            {
                descontoINSS = ((salarioBruto - 2571.29) * 0.12) + ((2571.29 - 1302) * 0.09) + (1302 * 0.075);
            }
            else if (salarioBruto >= 3856.95 && salarioBruto <= 7507.49)
            {
                descontoINSS = ((salarioBruto - 3856.95) * 0.14) + ((3856.94 - 2571.29) * 0.12) + ((2571.29 - 1302) * 0.09) + (1302 * 0.075);
            }
            else
            {
                descontoINSS = ((7507.49 - 3856.95) * 0.14) + ((3856.94 - 2571.29) * 0.12) + ((2571.29 - 1302) * 0.09) + (1302 * 0.075);
            }

            return descontoINSS;
        }
    }
}
