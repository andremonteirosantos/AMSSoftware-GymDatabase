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
    public partial class AvaliacoesFisicas : UserControl
    {
        public AvaliacoesFisicas()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void AvaliacoesFisicas_Load(object sender, EventArgs e)
        {
            clienteTA.Update(pAPDataSet.cliente);
            clienteTA.Fill(pAPDataSet.cliente);
        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientedgv.Rows.Count > 0)
                {
                    int codigo = int.Parse(clientedgv[0, clientedgv.CurrentRow.Index].Value.ToString());
                    string nome = clientedgv[1, clientedgv.CurrentRow.Index].Value.ToString();
                    string altura = clientedgv[8, clientedgv.CurrentRow.Index].Value.ToString();
                    string sexo = clientedgv[7, clientedgv.CurrentRow.Index].Value.ToString();
                    FrmAvaliacaoFisica janela = new FrmAvaliacaoFisica(codigo, nome,altura, sexo);
                    janela.ShowDialog();
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
