using System;
using calSalario;

namespace calSalario
{
    public class Program
    {
        static void Main(string[] args)
        {
            salario nsal = new salario();
            Console.WriteLine("Digite seu salario Total Bruto:");
            nsal.salarioBruto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de desconto do seu VT: ");
            nsal.vt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do seu Plano de Saude:");
            nsal.planoSaude = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do seu Plano Odontolpgico:");
            nsal.planoOdonto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de desconto do seu VR:");
            nsal.vr = Convert.ToDouble(Console.ReadLine());
            nsal.calcularDesconto();
            Console.WriteLine("Digite qualquer tecla para fechar . . .");
            Console.ReadLine();
        }
    }
}  