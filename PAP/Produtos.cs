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
    public partial class Produtos : UserControl
    {
        public Produtos()
        {
            InitializeComponent();
            this.categoriaTA.Fill(this.pAPDataSet.Categoria);
            //this.produtosTA.Fill(this.pAPDataSet.Produtos);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProdutos janela = new FrmProdutos();
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
                if (produtosdgv.RowCount > 0)
                {
                    int linha = produtosdgv.CurrentRow.Index;
                    DialogResult resposta = MessageBox.Show("Deseja eliminar o registo selecionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        DialogResult respostaII = MessageBox.Show("Vai eliminar qualquer registo deste funcionário e esta ação é irreversível!", "Confirmar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respostaII == DialogResult.Yes)
                        {
                            try
                            {

                                int valor = int.Parse(produtosdgv[0, linha].Value.ToString());
                                produtosTA.Delete(valor);
                                produtosTA.Update(pAPDataSet.Produtos);
                                produtosTA.Fill(pAPDataSet.Produtos);
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
    }
}
