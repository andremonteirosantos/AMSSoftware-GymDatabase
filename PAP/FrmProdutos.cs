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
    public partial class FrmProdutos : Form
    {
        int _valor;
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAPDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTA.Fill(this.pAPDataSet.Categoria);
            // TODO: This line of code loads data into the 'pAPDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTA.Fill(this.pAPDataSet.Produtos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    produtosTA.Insert(txtnome.Text, txtmarca.Text, txtdesc.Text,decimal.Parse(txtpreco.Text), int.Parse(cbocategoria.SelectedValue.ToString()), txtnomeBotao.Text);
                    produtosTA.Update(pAPDataSet.Produtos);
                    produtosTA.Fill(pAPDataSet.Produtos);
                    DialogResult resposta = MessageBox.Show("Produto criado com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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
