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
    public partial class FrmPlanosdeTreino : Form
    {
        int _idcliente;
        public FrmPlanosdeTreino(int idcliente)
        {
            InitializeComponent();
            AssinarBotoes();
            _idcliente = idcliente;
            this.viewplanosTreinoTableAdapter.Fill(this.pAPDataSet.viewplanosTreino, _idcliente);
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
        }
        private void CarregarBotoes()
        {

            Button[] botoes = { btt1, btt2, btt3, btt4, btt5, btt6, btt7, btt8, btt9, btt10, btt11, btt12, btt13, btt14, btt15};


            foreach (Button botao in botoes)
            {
                botao.Visible = false;
            }

            for (int linha = 0; linha <= dgv.Rows.Count - 1; linha++)
            {
                botoes[linha].Visible = true;
                botoes[linha].Text = dgv[3, linha].Value.ToString();
                botoes[linha].Tag = dgv[0, linha].Value.ToString();
            }

        }

        

        private void FrmPlanosdeTreino_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAPDataSet.viewplanosTreino' table. You can move, or remove it, as needed.
        
            //// TODO: This line of code loads data into the 'pAPDataSet.CategoriaExercicios' table. You can move, or remove it, as needed.
            this.categoriaExerciciosTA.Fill(this.pAPDataSet.CategoriaExercicios);
            //// TODO: This line of code loads data into the 'pAPDataSet.Exercicios' table. You can move, or remove it, as needed.
            this.exerciciosTA.Fill(this.pAPDataSet.Exercicios);
            //// TODO: This line of code loads data into the 'pAPDataSet.Exercicios' table. You can move, or remove it, as needed.

        }        

        private void btt1_Click(object sender, EventArgs e)
        {
            //try
            //{
                int exercicio = int.Parse(((Button)sender).Tag.ToString());
                string nome = exerciciosTA.GetDataByID(exercicio)[0][1].ToString();
                string grupo = exerciciosTA.GetDataByID(exercicio)[0][4].ToString();
                string descricao = exerciciosTA.GetDataByID(exercicio)[0][3].ToString();

            planodeTreinoTA.Insert(_idcliente, exercicio);
            planodeTreinoTA.Update(pAPDataSet.PlanodeTreino);

            this.viewplanosTreinoTableAdapter.Fill(this.pAPDataSet.viewplanosTreino,_idcliente);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex != -1)
            {
                exerciciosTA.FillByCategoria(pAPDataSet.Exercicios, int.Parse(cbCategoria.SelectedValue.ToString()));
                CarregarBotoes();
            }
        }

        private void bttRemover_Click(object sender, EventArgs e)
        {
           
        }

        private void bttRemover_Click_1(object sender, EventArgs e)
        {
            if (dgvplano.Rows.Count > 0)
            {
                int idplano = int.Parse(dgvplano[1,dgvplano.CurrentRow.Index].Value.ToString());
                planodeTreinoTA.Delete(idplano);
                planodeTreinoTA.Update(pAPDataSet.PlanodeTreino);
                planodeTreinoTA.Fill(pAPDataSet.PlanodeTreino);

                this.viewplanosTreinoTableAdapter.Fill(this.pAPDataSet.viewplanosTreino, _idcliente);
            }
        }
    }   
}
