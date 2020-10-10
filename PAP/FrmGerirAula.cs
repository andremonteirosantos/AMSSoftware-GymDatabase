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
    public partial class FrmGerirAula : Form
    {
        int _idMod;
        int _valor;
        public FrmGerirAula(string horainicio, string duracao, string local, string dia, string alunos, string idmod, int valor)
        {
            InitializeComponent();
            this.modalidadesTA.Fill(this.pAPDataSet.Modalidades);
            _idMod = int.Parse (idmod);
            _valor = valor;
            if (cbomodalidade.SelectedIndex != -1)
            {
                mtxthora.Text = horainicio;
                txtduracao.Text = duracao;
                txtginasio.Text = local;
                dtpdata.Text = dia;
                txtalunos.Text = alunos;
                cbomodalidade.SelectedValue = _idMod;
                viewInscricoes1TA.Fill(pAPDataSet.viewInscricoes1, _idMod);
                this.funcionarioTA.FillByFuncao(this.pAPDataSet.funcionario);
            }
        }

       

        private void FrmGerirAula_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAPDataSet.funcionario' table. You can move, or remove it, as needed.
            //this.funcionarioTA.Fill(this.pAPDataSet.funcionario);
            // TODO: This line of code loads data into the 'pAPDataSet.Modalidades' table. You can move, or remove it, as needed.
            //this.modalidadesTA.Fill(this.pAPDataSet.Modalidades);
            this.aula_AlunosTA.Fill(this.pAPDataSet.Aula_Alunos, _valor);
            this.aula_TreinadorTA.Fill(this.pAPDataSet.Aula_Treinador, _valor);
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aula_TreinadorTA.Insert(_valor,int.Parse(cbotreinador.SelectedValue.ToString()), cbotreinador.Text);
            aula_TreinadorTA.Update(pAPDataSet.Aula_Treinador);
            aula_TreinadorTA.Fill(pAPDataSet.Aula_Treinador, _valor);
            DialogResult resposta = MessageBox.Show("Treinador adicionado com sucesso!", "Aulas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total_Alunos = alunosdgv.RowCount;
            total_Alunos = (int)aula_AlunosTA.ScalarQueryNumAlunos();
            if (total_Alunos <= int.Parse(txtalunos.Text))
            {
                aula_AlunosTA.Insert(_valor, int.Parse(cboalunos.SelectedValue.ToString()), cboalunos.Text);
                aula_AlunosTA.Update(pAPDataSet.Aula_Alunos);
                aula_AlunosTA.Fill(pAPDataSet.Aula_Alunos, _valor);
                DialogResult resposta = MessageBox.Show("Aluno inserido com sucesso!", "Aulas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult resposta = MessageBox.Show("Lotação esgotada para esta aula!", "Aulas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {            
            try
            {
                if (alunosdgv.RowCount > 0)
                {
                    int linha = alunosdgv.CurrentRow.Index;
                    DialogResult respostaII = MessageBox.Show("Deseja Continuar?", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respostaII == DialogResult.Yes)
                    {
                        int valor = int.Parse(alunosdgv[0, linha].Value.ToString());
                        aula_AlunosTA.Delete(valor);
                        aula_AlunosTA.Update(pAPDataSet.Aula_Alunos);
                        aula_AlunosTA.Fill(pAPDataSet.Aula_Alunos,_valor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (treinadordgv.RowCount > 0)
                {
                    int linha = treinadordgv.CurrentRow.Index;
                    DialogResult respostaII = MessageBox.Show("Deseja Continuar?", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respostaII == DialogResult.Yes)
                    {
                        int valor = int.Parse(treinadordgv[0, linha].Value.ToString());
                        aula_TreinadorTA.Delete(valor);
                        aula_TreinadorTA.Update(pAPDataSet.Aula_Treinador);
                        aula_TreinadorTA.Fill(pAPDataSet.Aula_Treinador, _valor);
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
