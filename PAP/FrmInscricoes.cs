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
    public partial class FrmInscricoes : Form
    {
        int _codCliente;
        public FrmInscricoes(int codCliente, string nomecliente)
        {
            InitializeComponent();
            _codCliente = codCliente;
            textBox1.Text = nomecliente;
        }

        private void FrmInscricoes_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'pAPDataSet.inscricoes' table. You can move, or remove it, as needed.
                this.inscricoesTA.Fill(this.pAPDataSet.inscricoes);
                // TODO: This line of code loads data into the 'pAPDataSet.cliente' table. You can move, or remove it, as needed.
                this.clienteTA.Fill(this.pAPDataSet.cliente);
                // TODO: This line of code loads data into the 'pAPDataSet.Modalidades' table. You can move, or remove it, as needed.
                this.modalidadesTA.Fill(this.pAPDataSet.Modalidades);
                this.viewInscricoesTA.Fill(this.pAPDataSet.viewInscricoes, _codCliente);
                this.cbomodalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            try
            {
                inscricoesTA.Insert(_codCliente, int.Parse(cbomodalidades.SelectedValue.ToString()), DateTime.Parse(dtpData.Text));
                inscricoesTA.Update(pAPDataSet.inscricoes);
                inscricoesTA.Fill(pAPDataSet.inscricoes);
                this.viewInscricoesTA.Fill(this.pAPDataSet.viewInscricoes, _codCliente);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmInscricoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem a certeza que deseja fechar?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
