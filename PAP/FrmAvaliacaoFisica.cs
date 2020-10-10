using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAP
{
    public partial class FrmAvaliacaoFisica : Form
    {
        int _codCliente;
        public FrmAvaliacaoFisica(int codCliente, string nome, string altura,string sexo)
        {
            InitializeComponent();
            _codCliente = codCliente;
            textBox6.Text = nome;
            txtaltura.Text = altura;
            textBox1.Text = sexo;
        }
        private bool Validar1()
        {
            bool temerros = false;
            erros.Clear();


            if (txtpeso.Text == "")
            {
                erros.SetError(txtpeso, "Peso Obrigatório");
                temerros = true;
            }

            if (txtidade.Text == "")
            {
                erros.SetError(txtidade, "Idade Obrigatória");
                temerros = true;
            }
            return temerros;
        }
        private bool Validar2()
        {
            bool temerros = false;
            erros.Clear();

            if (txtidade.Text == "")
            {
                erros.SetError(txtimc, "Idade Obrigatória");
                temerros = true;
            }

            if (txtimc.Text == "")
            {
                erros.SetError(txtimc, "Índice de Massa Gorda Obrigatório");
                temerros = true;
            }

            if (txtmg.Text == "")
            {
                erros.SetError(txtmg, "Massa Gorda Obrigatória");
                temerros = true;
            }

            if (txtmm.Text == "")
            {
                erros.SetError(txtmm, "Massa Magra Obrigatória");
                temerros = true;
            }

            int nresgisto = avaliacaoFisicaTA.GetDataByAvaliacaodata(dtpavaliacao.Text).Rows.Count;
            if ((nresgisto >= 1))
            {
                erros.SetError(dtpavaliacao, "O Cliente já foi avaliado nesse dia!");
                temerros = true;
            }
            return temerros;
        }

        private void FrmAvaliacaoFisica_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'pAPDataSet.cliente' table. You can move, or remove it, as needed.
                this.clienteTA.Fill(this.pAPDataSet.cliente);
                // TODO: This line of code loads data into the 'pAPDataSet.AvaliacaoFisica' table. You can move, or remove it, as needed.
                this.avaliacaoFisicaTA.Fill(this.pAPDataSet.AvaliacaoFisica);
                this.viewAvaliacaoTA.Fill(this.pAPDataSet.viewAvaliacao, _codCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtimc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar1() == false)
            {
                try
                {
                    if (textBox1.Text == "Masculino")
                    {
                        txtimc.Text = (double.Parse(txtpeso.Text) / (double.Parse(txtaltura.Text) * double.Parse(txtaltura.Text) / 10000)).ToString();
                        txtmg.Text = (((1.20 * (double.Parse(txtimc.Text))) + ((0.23 * (double.Parse(txtidade.Text))) - ((10.8 * 1)) - 5.4))).ToString();
                        txtmm.Text = (100 - double.Parse(txtmg.Text)).ToString();
                        txtimc.Text = Math.Round(double.Parse(txtimc.Text), 1, MidpointRounding.ToEven).ToString();
                        txtmg.Text = Math.Round(double.Parse(txtmg.Text), 1, MidpointRounding.ToEven).ToString();
                        txtmm.Text = Math.Round(double.Parse(txtmm.Text), 1, MidpointRounding.ToEven).ToString();
                    }
                    if (textBox1.Text == "Feminino")
                    {
                        txtimc.Text = (double.Parse(txtpeso.Text) / (double.Parse(txtaltura.Text) * double.Parse(txtaltura.Text) / 10000)).ToString();
                        txtmg.Text = (((1.20 * (double.Parse(txtimc.Text))) + ((0.23 * (double.Parse(txtidade.Text))) - ((10.8 * 0)) - 5.4))).ToString();
                        txtmm.Text = (100 - double.Parse(txtmg.Text)).ToString();
                        txtimc.Text = Math.Round(double.Parse(txtimc.Text), 1, MidpointRounding.ToEven).ToString();
                        txtmg.Text = Math.Round(double.Parse(txtmg.Text), 1, MidpointRounding.ToEven).ToString();
                        txtmm.Text = Math.Round(double.Parse(txtmm.Text), 1, MidpointRounding.ToEven).ToString();
                    }
                    pictureBox11.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtmg_TextChanged(object sender, EventArgs e)
        {
            txtmm.Text = (100 - double.Parse(txtmg.Text)).ToString();
            txtmm.Text = Math.Round(double.Parse(txtmm.Text), 1, MidpointRounding.ToEven).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Validar2() == false)
            {
                try
                {
                    avaliacaoFisicaTA.Insert(_codCliente, DateTime.Parse(dtpavaliacao.Text), txtpeso.Text, txtimc.Text, txtmg.Text, txtmm.Text, txtidade.Text);
                    avaliacaoFisicaTA.Update(pAPDataSet.AvaliacaoFisica);
                    avaliacaoFisicaTA.Fill(pAPDataSet.AvaliacaoFisica);
                    viewAvaliacaoTA.Fill(this.pAPDataSet.viewAvaliacao, _codCliente);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {                                 
                    string imc = txtimc.Text;
                    TabelasdeRecomendacao janela = new TabelasdeRecomendacao(imc);
                    janela.ShowDialog();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtimc.ReadOnly = false;
            txtmg.ReadOnly = false;
            txtmm.ReadOnly = false;
        }

        private void txtimc_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
