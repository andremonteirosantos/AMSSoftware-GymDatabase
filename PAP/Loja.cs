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
    public partial class Loja : UserControl
    {
        public Loja()
        {
            InitializeComponent();
        }
        public void AssinarBotoes()
        {
            btt2.Click += btt1_Click;
            btt3.Click += btt1_Click;
            btt4.Click += btt1_Click;
            btt5.Click += btt1_Click;
            btt6.Click += btt1_Click;
            btt7.Click += btt1_Click;
            btt8.Click += btt1_Click;
            btt9.Click += btt1_Click;
            btt10.Click += btt1_Click;
            btt11.Click += btt1_Click;
            btt12.Click += btt1_Click;
            btt13.Click += btt1_Click;
            btt14.Click += btt1_Click;
            btt15.Click += btt1_Click;
            btt16.Click += btt1_Click;
            btt17.Click += btt1_Click;
            btt18.Click += btt1_Click;
            btt19.Click += btt1_Click;
            btt20.Click += btt1_Click;
        }
        private void CarregarBotoes()
        {

            Button[] botoes = { btt1, btt2, btt3, btt4, btt5, btt6, btt7, btt8, btt9, btt10, btt11, btt12, btt13, btt14, btt15, btt16, btt17, btt18, btt19, btt20 };


            foreach (Button botao in botoes)
            {
                botao.Visible = false;
            }

            for (int linha = 0; linha <= dgv.Rows.Count - 1; linha++)
            {
                botoes[linha].Visible = true;
                decimal preco = decimal.Parse(dgv[4, linha].Value.ToString());
                botoes[linha].Text = dgv[6, linha].Value.ToString() + "\n" + preco.ToString("c2");
                botoes[linha].Tag = dgv[0, linha].Value.ToString();
            }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex != -1)
            {
                produtosTA.FillByCategoria(pAPDataSet.Produtos, int.Parse(cbCategoria.SelectedValue.ToString()));
                CarregarBotoes();
            }
        }


        private void CalcularTotal ()
        {
            decimal totalFatura = 0;
            decimal valor = 0;
            for (int linha = 0; linha <= dgvCesto.Rows.Count - 1; linha++)
            {
                valor = decimal.Parse (dgvCesto [3,linha].Value .ToString ());
                totalFatura += valor;
            }

            lbTotal.Text = totalFatura.ToString("c2");
        }
        private void btt1_Click(object sender, EventArgs e)
        {
            int produto = int.Parse(((Button)sender).Tag.ToString());
            string descricao = produtosTA.GetDataByID(produto)[0][1].ToString();
            decimal preco = decimal.Parse(produtosTA.GetDataByID(produto)[0][4].ToString());
            bool encontrouproduto = false;
            int linhaEncontrou = 0;
            //inserir na grelha
            for (int linha = 0; linha <= dgvCesto.Rows.Count - 1; linha++)
            {
                if (dgvCesto[0, linha].Value.ToString() == produto.ToString())
                {
                    encontrouproduto = true;
                    linhaEncontrou = linha;
                }
            }

            if (encontrouproduto == true)
            {
                int qta = int.Parse(dgvCesto[2, linhaEncontrou].Value.ToString());
                qta++;
                dgvCesto [2, linhaEncontrou].Value = qta;
                dgvCesto[3, linhaEncontrou].Value = preco * qta;
            }
            else
            {
                dgvCesto.Rows.Add(produto, descricao, 1, preco);
            }

            CalcularTotal();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCesto_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotal();
        }

        private void bttFinalizar_Click(object sender, EventArgs e)
        {
            frmFatura janela = new frmFatura(dgvCesto, lbTotal.Text );
            janela.ShowDialog();
        }

        private void btquantidade_Click(object sender, EventArgs e)
        {
            dgvCesto.Rows.Remove(dgvCesto.CurrentRow);
            CalcularTotal();
        }

        private void Loja_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHistorico janela = new FrmHistorico();
            janela.ShowDialog();
        }
    }
}
