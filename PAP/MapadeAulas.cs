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
    public partial class MapadeAulas : UserControl
    {
        public MapadeAulas()
        {
            InitializeComponent();
        }

        private void aulaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aulaBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void MapadeAulas_Load(object sender, EventArgs e)
        {
            aulaTA.Update(pAPDataSet.Aula);
            aulaTA.Fill(pAPDataSet.Aula);
            modalidadesTA.Update(pAPDataSet.Modalidades);
            modalidadesTA.Fill(pAPDataSet.Modalidades);
        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmModalidades janela = new FrmModalidades();
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
                if (modalidadesdgv.RowCount > 0)
                {
                    int linha = modalidadesdgv.CurrentRow.Index;
                    DialogResult resposta = MessageBox.Show("Deseja eliminar o registo selecionado", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        DialogResult respostaII = MessageBox.Show("Vai eliminar qualquer registo deste cliente e esta ação é irreversível!", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (respostaII == DialogResult.Yes)
                        {
                            try
                            {
                                int valor = int.Parse(modalidadesdgv[0, linha].Value.ToString());
                                aulaTA.Delete(valor);
                                modalidadesTA.Delete(valor);
                                modalidadesTA.Update(pAPDataSet.Modalidades);
                                this.modalidadesTA.Fill(this.pAPDataSet.Modalidades);
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAulas janela = new FrmAulas ("novo");
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
            aulaTA.Update(pAPDataSet.Aula);
            aulaTA.Fill(pAPDataSet.Aula);
            modalidadesTA.Update(pAPDataSet.Modalidades);
            modalidadesTA.Fill(pAPDataSet.Modalidades);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(auladgv[0, auladgv.CurrentRow.Index].Value.ToString());
                string horainicio = auladgv[1, auladgv.CurrentRow.Index].Value.ToString();
                string duracao = auladgv[2, auladgv.CurrentRow.Index].Value.ToString();
                string local = auladgv[3, auladgv.CurrentRow.Index].Value.ToString();
                string dia = auladgv[4, auladgv.CurrentRow.Index].Value.ToString();
                string alunos = auladgv[5, auladgv.CurrentRow.Index].Value.ToString();
                string idmod = auladgv[6, auladgv.CurrentRow.Index].Value.ToString();
                FrmAulas janela = new FrmAulas("editar", horainicio, duracao, local, dia, alunos, idmod, valor);
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
                int valor = int.Parse(auladgv[0, auladgv.CurrentRow.Index].Value.ToString());
                string horainicio = auladgv[1, auladgv.CurrentRow.Index].Value.ToString();
                string duracao = auladgv[2, auladgv.CurrentRow.Index].Value.ToString();
                string local = auladgv[3, auladgv.CurrentRow.Index].Value.ToString();
                string dia = auladgv[4, auladgv.CurrentRow.Index].Value.ToString();
                string alunos = auladgv[5, auladgv.CurrentRow.Index].Value.ToString();
                string idmod = auladgv[6, auladgv.CurrentRow.Index].Value.ToString();
                FrmGerirAula janela = new FrmGerirAula(horainicio, duracao, local, dia, alunos, idmod,valor);
                janela.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (auladgv.RowCount > 0)
                {
                    int linha = auladgv.CurrentRow.Index;
                    DialogResult resposta = MessageBox.Show("Deseja eliminar o registo selecionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        DialogResult respostaII = MessageBox.Show("Vai eliminar qualquer registo deste funcionário e esta ação é irreversível!", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respostaII == DialogResult.Yes)
                        {
                            try
                            {

                                int valor = int.Parse(auladgv[0, linha].Value.ToString());
                                aula_AlunosTA.Delete(valor);
                                aula_TreinadorTA.Delete(valor);
                                aulaTA.Delete(valor);
                                aulaTA.Update(pAPDataSet.Aula);
                                aulaTA.Fill(pAPDataSet.Aula);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
                        
