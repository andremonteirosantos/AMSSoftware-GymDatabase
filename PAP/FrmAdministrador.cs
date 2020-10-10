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
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
            sidepanel.Height = button4.Height;
            home1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Deseja terminar sessão?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    {
                        Login janela = new Login();
                        janela.Show();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            inserirCliente1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            home1.BringToFront();
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lbldata.Text = DateTime.Now.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            mapadeAulas1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button7.Height;
            sidepanel.Top = button7.Top;
            produtos2.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            inserirFuncionarios1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;
            loja1.BringToFront();
            //loja1.categoriaTA.Fill(loja1.pAPDataSet.Categoria);
            loja1.AssinarBotoes();
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button8.Height;
            sidepanel.Top = button8.Top;
            estatísca_Geral1.BringToFront();
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Deseja terminar sessão?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    {
                        Login janela = new Login();
                        janela.Show();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
