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
    public partial class FrmSecretario : Form
    {
        public FrmSecretario()
        {
            InitializeComponent();
            sidepanel.Height = button4.Height;
            home1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            loja1.BringToFront();
            loja1.categoriaTA.Fill(loja1.pAPDataSet.Categoria);
            loja1.AssinarBotoes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            mapadeAulas1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            inserirCliente1.BringToFront();

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

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            home1.BringToFront();
        }

        private void FrmFuncionario_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAPDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTA.Fill(this.pAPDataSet.cliente);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblhora_Click(object sender, EventArgs e)
        {
            
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lbldata.Text = DateTime.Now.ToLongDateString();
        }

        private void inserirCliente1_Enter(object sender, EventArgs e)
        {
            clienteTA.Update(pAPDataSet.cliente);
            clienteTA.Fill(pAPDataSet.cliente);
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void inserirCliente1_Load(object sender, EventArgs e)
        {
            clienteTA.Update(pAPDataSet.cliente);
            clienteTA.Fill(pAPDataSet.cliente);
        }
    }
}
