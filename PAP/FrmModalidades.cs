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
    public partial class FrmModalidades : Form
    {
        public FrmModalidades()
        {
            InitializeComponent();
        }

        private void modalidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modalidadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void FrmModalidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAPDataSet.Modalidades' table. You can move, or remove it, as needed.
            this.modalidadesTableAdapter.Fill(this.pAPDataSet.Modalidades);

        }

        private void button4_Click(object sender, EventArgs e)
        {
                try
                {
                    modalidadesTableAdapter.Insert(txtnome.Text);
                    modalidadesTableAdapter.Update(pAPDataSet.Modalidades);
                    modalidadesTableAdapter.Fill(pAPDataSet.Modalidades);
                    DialogResult resposta = MessageBox.Show("Modalidade inserida com sucesso!", "Modalidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void FrmModalidades_FormClosing(object sender, FormClosingEventArgs e)
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
