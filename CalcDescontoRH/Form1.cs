using Interface.CalcularSalario;
using Interface.Configs;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Leave += TextBox_Leave;
            textBox2.Leave += TextBox_Leave;
            textBox3.Leave += TextBox_Leave;
            textBox4.Leave += TextBox_Leave;

            textBox1.KeyPress += TextBox_KeyPress;
            textBox2.KeyPress += TextBox_KeyPress;
            textBox3.KeyPress += TextBox_KeyPress;
            textBox4.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (decimal.TryParse(textBox.Text, out decimal num))
                {
                    textBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", num);
                }
                else
                {
                    textBox.Clear();
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != ',')
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double salarioBruto = MaskedRemove.RemoveFormatacao(textBox1.Text);
            double valeAlimentacao = MaskedRemove.RemoveFormatacao(textBox2.Text);
            double planoOdontologico = MaskedRemove.RemoveFormatacao(textBox3.Text);
            double planoSaude = MaskedRemove.RemoveFormatacao(textBox4.Text);

            bool valeTransporte = checkBox1.Checked;

            double salarioLiquido = CalcularSalarioLiquido.CalcularSalario(salarioBruto, valeAlimentacao, planoOdontologico, planoSaude, valeTransporte);

            ReturnText.Text = $"O Salário calculado é: R$ {salarioLiquido.ToString("F2")}";
        }
    }
}
