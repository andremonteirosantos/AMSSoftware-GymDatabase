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
    public partial class InserirFuncionarios : UserControl
    {
        public InserirFuncionarios()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            if (txtValor.Text == "")
            {
                bttProcurar.Enabled = false;
            }
            else
            {
                bttProcurar.Enabled = true;
            }
        }

        private void clientedgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InserirFuncionarios_Load(object sender, EventArgs e)
        {
            funcionarioTA.Update(pAPDataSet.funcionario);
            funcionarioTA.Fill(pAPDataSet.funcionario);
        }

        private void InserirFuncionarios_Enter(object sender, EventArgs e)
        {
            funcionarioTA.Update(pAPDataSet.funcionario);
            funcionarioTA.Fill(pAPDataSet.funcionario);
        }

        private void funcionariodgv_Enter(object sender, EventArgs e)
        {
            funcionarioTA.Update(pAPDataSet.funcionario);
            funcionarioTA.Fill(pAPDataSet.funcionario);
        }

        private void btinserir_Click_1(object sender, EventArgs e)
        {

            try
            {
                FrmInserirFuncionario janela = new FrmInserirFuncionario("novo");
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
                int valor = int.Parse(funcionariodgv[0, funcionariodgv.CurrentRow.Index].Value.ToString());
                string nome = funcionariodgv[1, funcionariodgv.CurrentRow.Index].Value.ToString();
                string funcao = funcionariodgv[2, funcionariodgv.CurrentRow.Index].Value.ToString();
                string morada = funcionariodgv[3, funcionariodgv.CurrentRow.Index].Value.ToString();
                string telemovel = funcionariodgv[4, funcionariodgv.CurrentRow.Index].Value.ToString();
                string genero = funcionariodgv[5, funcionariodgv.CurrentRow.Index].Value.ToString();
                string data = funcionariodgv[6, funcionariodgv.CurrentRow.Index].Value.ToString();
                string nif = funcionariodgv[7, funcionariodgv.CurrentRow.Index].Value.ToString();
                string email = funcionariodgv[8, funcionariodgv.CurrentRow.Index].Value.ToString();
                string username = funcionariodgv[9, funcionariodgv.CurrentRow.Index].Value.ToString();
                string password = funcionariodgv[10, funcionariodgv.CurrentRow.Index].Value.ToString();
                string codpostal = funcionariodgv[11, funcionariodgv.CurrentRow.Index].Value.ToString();
                string localidade = funcionariodgv[12, funcionariodgv.CurrentRow.Index].Value.ToString();                
                FrmInserirFuncionario janela = new FrmInserirFuncionario("editar", nome, funcao, morada, telemovel, genero, data, email, username, password, codpostal, localidade, nif, valor);
                janela.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (funcionariodgv.RowCount > 0)
                {
                    int linha = funcionariodgv.CurrentRow.Index;
                    DialogResult resposta = MessageBox.Show("Deseja eliminar o registo selecionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        DialogResult respostaII = MessageBox.Show("Vai eliminar qualquer registo deste funcionário e esta ação é irreversível!", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respostaII == DialogResult.Yes)
                        {
                            try
                            {

                                int valor = int.Parse(funcionariodgv[0, linha].Value.ToString());
                                aula_TreinadorTA.Delete(valor);
                                funcionarioTA.Delete(valor);                               
                                funcionarioTA.Update(pAPDataSet.funcionario);
                                funcionarioTA.Fill(pAPDataSet.funcionario);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(funcionariodgv[0, funcionariodgv.CurrentRow.Index].Value.ToString());
                string nome = funcionariodgv[1, funcionariodgv.CurrentRow.Index].Value.ToString();
                string funcao = funcionariodgv[2, funcionariodgv.CurrentRow.Index].Value.ToString();
                string morada = funcionariodgv[3, funcionariodgv.CurrentRow.Index].Value.ToString();
                string telemovel = funcionariodgv[4, funcionariodgv.CurrentRow.Index].Value.ToString();
                string genero = funcionariodgv[5, funcionariodgv.CurrentRow.Index].Value.ToString();
                string data = funcionariodgv[6, funcionariodgv.CurrentRow.Index].Value.ToString();
                string nif = funcionariodgv[7, funcionariodgv.CurrentRow.Index].Value.ToString();
                string email = funcionariodgv[8, funcionariodgv.CurrentRow.Index].Value.ToString();
                string username = funcionariodgv[9, funcionariodgv.CurrentRow.Index].Value.ToString();
                string password = funcionariodgv[10, funcionariodgv.CurrentRow.Index].Value.ToString();
                string codpostal = funcionariodgv[11, funcionariodgv.CurrentRow.Index].Value.ToString();
                string localidade = funcionariodgv[12, funcionariodgv.CurrentRow.Index].Value.ToString();
                FrmInserirFuncionario janela = new FrmInserirFuncionario("visualizar", nome, funcao, morada, telemovel, genero, data, email, username, password, codpostal, localidade, nif, valor);
                janela.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbCampo.SelectedIndex)                  
                {
                    case 0://ID
                        funcionarioTA.FillById(pAPDataSet.funcionario, int.Parse(txtValor.Text)); break;
                    case 1://Nome
                        funcionarioTA.FillByNome(pAPDataSet.funcionario, "%" + txtValor.Text + "%"); break;
                    case 2://Nif
                        funcionarioTA.FillByNif(pAPDataSet.funcionario, "%" + txtValor.Text + "%"); break;                        
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

        private void bttRepor_Click(object sender, EventArgs e)
        {
            this.funcionarioTA.Fill(this.pAPDataSet.funcionario);
            txtValor.ResetText();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
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
