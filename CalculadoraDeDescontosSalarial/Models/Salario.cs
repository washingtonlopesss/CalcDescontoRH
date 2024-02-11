using System;

namespace calSalario
{
    class salario
    {
        public double salarioBruto { get; set; }
        public double vt { get; set; }
        public double planoSaude { get; set; }
        public double planoOdonto { get; set; }
        public double vr { get; set; }
        public void calcularDesconto()
        {
            salarioBruto = salarioBruto - (vt + planoSaude + planoOdonto + vr);
            double descontoINSS;
            if (salarioBruto <= 1302.00)
            {
                descontoINSS = (0.075 * salarioBruto);
            }
            else if (salarioBruto >= 1302.01 && salarioBruto <= 2571.29)
            {
                descontoINSS = (1302 * 0.075 + ((salarioBruto - 1302) * 0.09));
            }
            else if (salarioBruto >= 2571.30 && salarioBruto <= 3856.94)
            {
                descontoINSS = ((salarioBruto - 2571.29) * 0.12) + ((2571.29 - 1302) * 0.09) + (1302 * 0.075);
            }
            else if (salarioBruto >= 3856.95 && salarioBruto <= 7507.49)
            {
                descontoINSS = ((salarioBruto - 3856.95) * 0.14) + ((3856.94 - 2571.29) * 0.12) + ((2571.29 - 1302) * 0.09) + (1302 * 0.075);
            }
            else if (salarioBruto >= 3856.95)
            {
                descontoINSS = ((7507.49 - 3856.95) * 0.14) + ((3856.94 - 2571.29) * 0.12) + ((2571.29 - 1302) * 0.09) + (1302 * 0.075);
            }
        }
    }
}
