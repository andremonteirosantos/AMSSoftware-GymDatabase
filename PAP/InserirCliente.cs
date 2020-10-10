using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAP
{
    public partial class InserirCliente : UserControl
    {
        public InserirCliente()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.clienteTA.Fill(this.pAPDataSet.cliente);
            if (txtValor.Text == "")
            {
                bttProcurar.Enabled = false;
            }
            else
            {
                bttProcurar.Enabled = true;
            }
        }

        private void InserirClienteII_Load(object sender, EventArgs e)
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

        private void InserirCliente_Enter(object sender, EventArgs e)
        {
            clienteTA.Update(pAPDataSet.cliente);
            clienteTA.Fill(pAPDataSet.cliente);
        }

        private void clientedgv_Enter(object sender, EventArgs e)
        {
            clienteTA.Update(pAPDataSet.cliente);
            clienteTA.Fill(pAPDataSet.cliente);
        }

        private void clientedgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void clientedgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void clientedgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btinserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmInserirCliente janela = new FrmInserirCliente("novo");
                janela.ShowDialog();
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
                int valor = int.Parse(clientedgv[0, clientedgv.CurrentRow.Index].Value.ToString());
                string nome = clientedgv[1, clientedgv.CurrentRow.Index].Value.ToString();
                string morada = clientedgv[2, clientedgv.CurrentRow.Index].Value.ToString();
                string codpostal = clientedgv[3, clientedgv.CurrentRow.Index].Value.ToString();
                string localidade = clientedgv[4, clientedgv.CurrentRow.Index].Value.ToString();
                string nif = clientedgv[5, clientedgv.CurrentRow.Index].Value.ToString();
                string data = clientedgv[6, clientedgv.CurrentRow.Index].Value.ToString();
                string genero = clientedgv[7, clientedgv.CurrentRow.Index].Value.ToString();
                string altura = clientedgv[8, clientedgv.CurrentRow.Index].Value.ToString();
                string telemovel = clientedgv[9, clientedgv.CurrentRow.Index].Value.ToString();
                string email = clientedgv[10, clientedgv.CurrentRow.Index].Value.ToString();
                string email2 = clientedgv[11, clientedgv.CurrentRow.Index].Value.ToString();
                string datainsc = clientedgv[12, clientedgv.CurrentRow.Index].Value.ToString();
                string tipopagamento = clientedgv[13, clientedgv.CurrentRow.Index].Value.ToString();
                string valormonetario = clientedgv[14, clientedgv.CurrentRow.Index].Value.ToString();
                string observacoes = clientedgv[15, clientedgv.CurrentRow.Index].Value.ToString();
                FrmInserirCliente janela = new FrmInserirCliente("editar", nome, morada, codpostal, localidade, nif, data, genero, altura, telemovel, email, email2, datainsc, tipopagamento, valormonetario,observacoes, valor);
                janela.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(clientedgv[0, clientedgv.CurrentRow.Index].Value.ToString());
                string nome = clientedgv[1, clientedgv.CurrentRow.Index].Value.ToString();
                string morada = clientedgv[2, clientedgv.CurrentRow.Index].Value.ToString();
                string codpostal = clientedgv[3, clientedgv.CurrentRow.Index].Value.ToString();
                string localidade = clientedgv[4, clientedgv.CurrentRow.Index].Value.ToString();
                string nif = clientedgv[5, clientedgv.CurrentRow.Index].Value.ToString();
                string data = clientedgv[6, clientedgv.CurrentRow.Index].Value.ToString();
                string genero = clientedgv[7, clientedgv.CurrentRow.Index].Value.ToString();
                string altura = clientedgv[8, clientedgv.CurrentRow.Index].Value.ToString();
                string telemovel = clientedgv[9, clientedgv.CurrentRow.Index].Value.ToString();
                string email = clientedgv[10, clientedgv.CurrentRow.Index].Value.ToString();
                string email2 = clientedgv[11, clientedgv.CurrentRow.Index].Value.ToString();
                string datainsc = clientedgv[12, clientedgv.CurrentRow.Index].Value.ToString();
                string tipopagamento = clientedgv[13, clientedgv.CurrentRow.Index].Value.ToString();
                string valormonetario = clientedgv[14, clientedgv.CurrentRow.Index].Value.ToString();
                string observacoes = clientedgv[15, clientedgv.CurrentRow.Index].Value.ToString();
                FrmInserirCliente janela = new FrmInserirCliente("visualizar", nome, morada, codpostal, localidade, nif, data, genero, altura, telemovel, email, email2, datainsc, tipopagamento, valormonetario,observacoes, valor);
                janela.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientedgv.RowCount > 0)
                {
                    int linha = clientedgv.CurrentRow.Index;
                    DialogResult resposta = MessageBox.Show("Deseja eliminar o registo selecionado", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        DialogResult respostaII = MessageBox.Show("Vai eliminar qualquer registo deste cliente e esta ação é irreversível!", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (respostaII == DialogResult.Yes)
                        {
                            try
                            {

                                int valor = int.Parse(clientedgv[0, linha].Value.ToString());
                                avaliacaoFisicaTA.Delete(valor);
                                inscricoesTA.Delete(valor);
                                aula_AlunosTA.Delete(valor);
                                clienteTA.Delete(valor);
                                clienteTA.Update(pAPDataSet.cliente);
                                this.clienteTA.Fill(this.pAPDataSet.cliente);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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
            try
            {
                if (clientedgv.Rows.Count > 0)
                {
                    int codigo = int.Parse(clientedgv[0, clientedgv.CurrentRow.Index].Value.ToString());
                    string nome = clientedgv[1, clientedgv.CurrentRow.Index].Value.ToString();
                    FrmInscricoes janela = new FrmInscricoes(codigo, nome);
                    janela.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttProcurar_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (cbCampo.SelectedIndex)
                {
                    case 0://ID
                        clienteTA.FillByID(pAPDataSet.cliente, int.Parse(txtValor.Text)); break;
                    case 1://Nome
                        clienteTA.FillByNome(pAPDataSet.cliente, "%" + txtValor.Text + "%"); break;
                    case 2://Nif
                        clienteTA.FillByNIf(pAPDataSet.cliente, "%" + txtValor.Text + "%"); break;
                }
                if (cbCampo.Text == "")
                    MessageBox.Show("Campo de Pesquisa Vazio!", "Procura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttRepor_Click_1(object sender, EventArgs e)
        {
            this.clienteTA.Fill(this.pAPDataSet.cliente);
            txtValor.ResetText();
        }

        private void txtValor_TextChanged_1(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                bttProcurar.Enabled = false;
            }
            else
            {
                bttProcurar.Enabled = true;
            }
        }
    }
}
