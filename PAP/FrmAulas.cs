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
    public partial class FrmAulas : Form
    {
        string _operacao;
        int _valor;
        int _idMod;
        public FrmAulas(string operacao)
        {
            InitializeComponent();
            _operacao = operacao;
        }

        public FrmAulas(string operacao, string horainicio, string duracao,string local, string dia, string alunos, string idmod, int valor)
        {
            InitializeComponent();
            _operacao = operacao;
            _valor = valor;

            maskedTextBox2.Text = horainicio;
            txtduracao.Text = duracao;
            txtginasio.Text = local;
            dtpdata.Text = dia;
            txtalunos.Text = alunos;
            _idMod = int.Parse(idmod);
            cbomodalidade.SelectedValue = _idMod;
        }

        private void aulaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aulaBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void FrmAulas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'pAPDataSet.Modalidades' table. You can move, or remove it, as needed.
                this.modalidadesTA.Fill(this.pAPDataSet.Modalidades);
                // TODO: This line of code loads data into the 'pAPDataSet.Aula_Presenca' table. You can move, or remove it, as needed.
                //this.aula_PresencaTableAdapter.Fill(this.pAPDataSet.Aula_Presenca);
                // TODO: This line of code loads data into the 'pAPDataSet.Aula' table. You can move, or remove it, as needed.
                this.aulaTA.Fill(this.pAPDataSet.Aula);
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
                if (_operacao == "novo")
                {
                    aulaTA.Insert(maskedTextBox2.Text, txtduracao.Text, txtginasio.Text, int.Parse(cbomodalidade.SelectedValue.ToString()), dtpdata.Text, txtalunos.Text);
                    aulaTA.Update(pAPDataSet.Aula);
                    aulaTA.Fill(pAPDataSet.Aula);
                    DialogResult resposta = MessageBox.Show("Aula criada com sucesso!", "Aulas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                if (_operacao == "editar")
                {                   
                    aulaTA.Update(maskedTextBox2.Text, txtduracao.Text, txtginasio.Text, int.Parse(cbomodalidade.SelectedValue.ToString()), dtpdata.Text, txtalunos.Text, _valor, _valor);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtalunos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtduracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
