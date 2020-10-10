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
    public partial class frmFatura : Form
    {
        public frmFatura(DataGridView grelha, string total)
        {
            InitializeComponent();

            int totalLinhas = grelha.Rows.Count;
            for (int linha = 0; linha <= totalLinhas - 1; linha++)
            {
                dgvCesto.Rows.Add(grelha[0, linha].Value, grelha[1, linha].Value, grelha[2, linha].Value, grelha[3, linha].Value);
              }
            lbTotal.Text = total;
        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            this.vendaProdutosTA.Fill(this.pAPDataSet.VendaProdutos);
            this.vendaTA.FillByUltimaVenda(this.pAPDataSet.Venda);
            this.clienteTA.Fill(this.pAPDataSet.cliente);

        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            //Guardar cabeçalho da venda
            vendaTA.Insert(DateTime.Parse(dtpData.Text), int.Parse(cbCliente.SelectedValue.ToString()));
            this.vendaTA.FillByUltimaVenda(this.pAPDataSet.Venda);
            int ultima = int.Parse(dgvVenda[0, 0].Value.ToString());

            //guardar os produtos vendidos
            for (int linha =0; linha <= dgvCesto.Rows.Count -1; linha++)
            {
                int produto = int.Parse(dgvCesto [0,linha].Value.ToString ());
                string descricao = dgvCesto[1, linha].Value.ToString();
                int qta = int.Parse(dgvCesto[2, linha].Value.ToString());
                decimal preco = decimal.Parse(dgvCesto[3, linha].Value.ToString());
                vendaProdutosTA.Insert(ultima, produto, qta, descricao, preco);
                vendaProdutosTA.Update(this.pAPDataSet.VendaProdutos);
            }
            Close();
        }
    }
}
