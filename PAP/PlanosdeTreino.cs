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
    public partial class PlanosdeTreino : UserControl
    {
        public PlanosdeTreino()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void PlanosdeTreino_Load(object sender, EventArgs e)
        {
            clienteTA.Update(pAPDataSet.cliente);
            clienteTA.Fill(pAPDataSet.cliente);
        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            int idcliente = int.Parse(clientedgv[0,clientedgv.CurrentRow.Index ].Value.ToString ());
            FrmPlanosdeTreino janela = new FrmPlanosdeTreino(idcliente);
            janela.ShowDialog();           
        }
    }
}
