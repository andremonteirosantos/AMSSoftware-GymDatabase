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
    public partial class FrmGerirAulas : Form
    {
        int _valor;
        public FrmGerirAulas(int valor, string horainicio, string duracao, string local, string dia, string alunos, string idmod)
        {
            InitializeComponent();
            _valor = valor;

            maskedTextBox2.Text = horainicio;
            txtduracao.Text = duracao;
            txtginasio.Text = local;
            dtpdata.Text = dia;
            txtalunos.Text = alunos;
            cbomodalidade.Text = idmod;
        }
        

        private void FrmGerirAulas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'pAPDataSet.Aula_Treinador' table. You can move, or remove it, as needed.
                this.aula_TreinadorTA.Fill(this.pAPDataSet.Aula_Treinador, _valor);
                this.aula_AlunosTA.Fill(this.pAPDataSet.Aula_Alunos, _valor);
                // TODO: This line of code loads data into the 'pAPDataSet.cliente' table. You can move, or remove it, as needed.
                this.clienteTA.Fill(this.pAPDataSet.cliente);
                // TODO: This line of code loads data into the 'pAPDataSet.Aula_Presenca' table. You can move, or remove it, as needed.
                //this.aula_PresencaTA.Fill(this.pAPDataSet.Aula_Presenca);
                // TODO: This line of code loads data into the 'pAPDataSet.Aula_Presenca' table. You can move, or remove it, as needed.
                //this.aula_PresencaTA.Fill(this.pAPDataSet.Aula_Presenca);
                // TODO: This line of code loads data into the 'pAPDataSet.funcionario' table. You can move, or remove it, as needed.
                this.funcionarioTA.Fill(this.pAPDataSet.funcionario);

                if (aula_Treinadordgv.RowCount >= 1)
                {
                    cbotreinador.Text = "";
                    cbotreinador.Visible = false;
                    lbltreinador.Visible = false;
                    button2.Visible = false;
                }
                cboclientes.DropDownStyle = ComboBoxStyle.DropDownList;
                cbotreinador.DropDownStyle = ComboBoxStyle.DropDownList;
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
                aula_TreinadorTA.Insert(_valor, int.Parse(cbotreinador.SelectedValue.ToString()));
                aula_TreinadorTA.Update(pAPDataSet.Aula_Treinador);
                this.aula_TreinadorTA.Fill(this.pAPDataSet.Aula_Treinador, _valor);
                DialogResult resposta = MessageBox.Show("Treinador escolhido com sucesso!", "Aulas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Visible = false;
                cbotreinador.Visible = false;
                lbltreinador.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbotreinador_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                aula_AlunosTA.Insert(_valor, int.Parse(cboclientes.SelectedValue.ToString()));
                aula_AlunosTA.Update(pAPDataSet.Aula_Alunos);
                this.aula_AlunosTA.Fill(this.pAPDataSet.Aula_Alunos, _valor);
                DialogResult resposta = MessageBox.Show("Aluno inserido com sucesso!", "Aulas", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
