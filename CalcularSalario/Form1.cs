using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            // limpar os campos se estiverem preenchidos
            if (TxtHorasTrabalhadas.Text != "" || TxtHorasExtras.Text != ""
                || TxtValorHora.Text != "" || TxtSalarioMes.Text != "")
            {
                TxtHorasTrabalhadas.Clear();
                TxtHorasExtras.Clear();
                TxtValorHora.Clear();
                TxtSalarioMes.Clear();

                TxtHorasTrabalhadas.Focus();
            }

            // quando tudo estiver vazio, o campo das horas trabalhadas ficará selecionado
            else
            {
                TxtHorasTrabalhadas.Focus();
            }
        }

        private void BtnCalcularSalario_Click(object sender, EventArgs e)
        {
            // declarar variáveis
            int HorasTrabalhadas, HorasExtras;
            decimal ValorHora, SalarioMes;

            // o valor das horas trabalhadas e o valor por hora ficarem vazios
            if (TxtHorasTrabalhadas.Text == "" && TxtValorHora.Text == "")
            {
                MessageBox.Show("O valor das horas trabalhadas e o valor por hora são obrigatórios!",
                    "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // o valor das horas trabalhadas ficar vazio
            else if (TxtHorasTrabalhadas.Text == "")
            {
                MessageBox.Show("O valor das horas trabalhadas é obrigatório!", "Dados Vazios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // o valor por hora ficar vazio
            else if (TxtValorHora.Text == "")
            {
                MessageBox.Show("O valor por hora é obrigatório!", "Dados Vazios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // mostrar mensagem para confirmar o cálculo do salário com as horas extras
            else if (TxtHorasExtras.Text != "" && MessageBox.Show(this, "Deseja realmente calcular o salário do mês?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // converter as horas trabalhadas para int
                HorasTrabalhadas = Convert.ToInt32(TxtHorasTrabalhadas.Text);

                // converter as horas extras para int
                HorasExtras = Convert.ToInt32(TxtHorasExtras.Text);

                // converter o valor por hora para decimal
                ValorHora = Convert.ToDecimal(TxtValorHora.Text);

                // calcular o salário do mês
                SalarioMes = (HorasTrabalhadas * ValorHora) + (HorasExtras * ValorHora * (decimal) 1.5);

                // mostrar mensagem de que o cálculo do salário deu certo
                MessageBox.Show("O Salário foi calculado com sucesso!");

                // mostrar o salário do mês
                TxtSalarioMes.Text = "R$ " + SalarioMes.ToString("F2");
            }

            // mostrar mensagem para confirmar o cálculo do salário sem as horas extras
            else if (TxtHorasExtras.Text == "" && MessageBox.Show(this, "Deseja realmente calcular o salário do mês?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // converter as horas trabalhadas para int
                HorasTrabalhadas = Convert.ToInt32(TxtHorasTrabalhadas.Text);

                // converter o valor por hora para int
                ValorHora = Convert.ToDecimal(TxtValorHora.Text);

                // calcular o salário do mês
                SalarioMes = HorasTrabalhadas * ValorHora;

                // mostrar mensagem de que o cálculo do salário deu certo
                MessageBox.Show("O Salário foi calculado com sucesso!");

                // mostrar o salário do mês
                TxtSalarioMes.Text = "R$ " + SalarioMes.ToString("F2");
            }
        }

        private void TxtHorasTrabalhadas_KeyDown(object sender, KeyEventArgs e)
        {
            // pressionar a tecla enter sem preencher as horas trabalhadas não vai pro campo de horas extras
            if (TxtHorasTrabalhadas.Text == "" && e.KeyCode == Keys.Enter)
            {
                TxtHorasTrabalhadas.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            // pressionar a tecla enter quando preencher as horas trabalhadas vai pro campo de horas extras
            else if (TxtHorasTrabalhadas.Text != "" && e.KeyCode == Keys.Enter)
            {
                TxtHorasExtras.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtHorasExtras_KeyDown(object sender, KeyEventArgs e)
        {
            // pressionar a tecla enter sem preencher as horas extras vai pro campo de valor por hora
            if (TxtHorasExtras.Text == "" && e.KeyCode == Keys.Enter)
            {
                TxtValorHora.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            // pressionar a tecla enter quando preencher as horas extras vai pro campo de valor por hora
            else if (TxtHorasExtras.Text != "" && e.KeyCode == Keys.Enter)
            {
                TxtValorHora.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtValorHora_KeyDown(object sender, KeyEventArgs e)
        {
            // pressionar a tecla enter sem preencher o valor por hora não vai exibir a mensagem de confirmação
            if (TxtValorHora.Text == "" && e.KeyCode == Keys.Enter)
            {
                TxtValorHora.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            // pressionar a tecla enter quando preencher o valor por hora vai exibir a mensagem de confirmação
            else if (TxtValorHora.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnCalcularSalario.PerformClick();
            }
        }

        private void TxtHorasTrabalhadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir somente números para preencher as horas trabalhadas
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtHorasExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir somente números para preencher as horas extras
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtValorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir , para preencher o valor por hora
            if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {

            }

            // permitir números para preencher o valor por hora
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            TxtHorasTrabalhadas.Focus();
        }
    }
}
