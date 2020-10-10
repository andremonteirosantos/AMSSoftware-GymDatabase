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
    public partial class FrmInserirCliente : Form
    {
        string _operacao;
        int _valor;

        public FrmInserirCliente(string operacao)
        {
            InitializeComponent();
            _operacao = operacao;
        }

        public FrmInserirCliente(string operacao, string nome, string morada, string codpostal, string localidade, string nif, string data, string genero, string altura, string telemovel, string email, string email2, string datainsc, string tipopagamento, string valormonetario,string observacoes, int valor)
        {
            InitializeComponent();
            _operacao = operacao;
            _valor = valor;

            txtnome.Text = nome;
            txtmorada.Text = morada;
            mtxtcodpostal.Text = codpostal;
            txtlocalidade.Text = localidade;
            mtxtnif.Text = nif;
            mtxtnif.ReadOnly = true;
            mtxtdata.Text = data;
            mtxtaltura.Text = altura;
            if (genero == "Masculino")
                rbm.Checked = true;
            else
                rbf.Checked = true;
            mtxttelemovel.Text = telemovel;
            txtemail.Text = email;
            txtemail2.Text = email2;
            mtxtdatainsc.Text = datainsc;
            cbotipo.Text = tipopagamento;
            txtvalor.Text = valormonetario;
            txtobs.Text = observacoes;
        }

        private bool Validar()
        {
            bool temerros = false;
            erros.Clear();


            if (txtnome.Text == "")
            {
                erros.SetError(txtnome, "Nome Obrigatório");
                temerros = true;
            }

            if (txtmorada.Text == "")
            {
                erros.SetError(txtmorada, "Morada Obrigatória");
                temerros = true;
            }

            if (!mtxtdata.MaskFull)
            {
                erros.SetError(mtxtdata, "Data de Nascimento Obrigatória");
                temerros = true;
            }

            if (txtlocalidade.Text == "")
            {
                erros.SetError(txtlocalidade, "Localidade Obrigatória");
                temerros = true;
            }

            if (!mtxtnif.MaskFull)
            {
                erros.SetError(mtxtnif, "NIF Obrigatório");
                temerros = true;
            }

            int nresgisto = clienteTA.GetDataByNif(mtxtnif.Text).Rows.Count;
            if ((nresgisto >= 1) && (_operacao == "novo"))
            {
                DialogResult resposta = MessageBox.Show("Este NIF já está regístado na base de dados!", "Fechar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                temerros = true;
            }


            if (!mtxtcodpostal.MaskFull)
            {
                erros.SetError(mtxtcodpostal, "Campo Obrigatório");
                temerros = true;
            }

            if (mtxttelemovel.Text == "")
            {
                erros.SetError(mtxttelemovel, "NºTelemóvel Obrigatório");
                temerros = true;
            }

            if (mtxtaltura.Text == "")
            {
                erros.SetError(mtxtaltura, "Altura Obrigatória");
                temerros = true;
            }

            if (txtemail.Text == "")
            {
                erros.SetError(txtemail, "Email Obrigatório");
                temerros = true;
            }

            if (mtxtdatainsc.Text == "")
            {
                erros.SetError(mtxtdatainsc, "Data de Inscrição Obrigatória");
                temerros = true;
            }

            if (cbotipo.Text == "")
            {
                erros.SetError(cbotipo, "Tipo de Pagamento Obrigatório");
                temerros = true;
            }
            return temerros;
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void FrmInserirCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'pAPDataSet.cliente' table. You can move, or remove it, as needed.
                this.clienteTA.Fill(this.pAPDataSet.cliente);
                this.cbotipo.DropDownStyle = ComboBoxStyle.DropDownList;
                if (_operacao == "visualizar")
                {
                    txtnome.ReadOnly = true;
                    mtxtdata.ReadOnly = true;
                    mtxtnif.ReadOnly = true;
                    txtmorada.ReadOnly = true;
                    mtxtcodpostal.ReadOnly = true;
                    txtlocalidade.ReadOnly = true;
                    mtxtaltura.ReadOnly = true;
                    mtxttelemovel.ReadOnly = true;
                    txtemail.ReadOnly = true;
                    txtemail2.ReadOnly = true;
                    mtxtdatainsc.ReadOnly = true;
                    cbotipo.Enabled = false;
                    txtvalor.ReadOnly = true;
                    groupBox4.Enabled = false;
                    button2.Visible = false;
                    txtobs.ReadOnly = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

         }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void clienteBS_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FrmInserirCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_operacao == "novo")
            {
                DialogResult resposta = MessageBox.Show("Deseja fechar? Todos os dados preenchidos serão limpos!", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.No)
                {
                    {
                        InserirCliente janela = new InserirCliente();
                        janela.Show();
                        Close();
                    }
                }
            }
            if (_operacao == "editar")
            {
                DialogResult resposta = MessageBox.Show("Deseja fechar? Qualquer edição realizada não será guardada!", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.No)
                {
                    {
                        InserirCliente janela = new InserirCliente();
                        janela.Show();
                        Close();
                    }
                }
            }
            if (_operacao == "visualizar")
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Validar() == false)
            {
                try
                {
                    string genero = rbm.Text;
                    if (_operacao == "novo")
                    {
                        if (rbm.Checked)
                            genero = rbm.Text;
                        else
                            genero = rbf.Text;
                        clienteTA.Insert(txtnome.Text, txtmorada.Text, mtxtcodpostal.Text, txtlocalidade.Text, mtxtnif.Text, mtxtdata.Text, genero, mtxtaltura.Text, mtxttelemovel.Text, txtemail.Text, txtemail2.Text, DateTime.Parse(mtxtdatainsc.Text), cbotipo.Text, decimal.Parse(txtvalor.Text), txtobs.Text);
                        clienteTA.Update(pAPDataSet.cliente);
                        this.clienteTA.Fill(this.pAPDataSet.cliente);
                        DialogResult resposta = MessageBox.Show("Cliente inserido com sucesso! Deseja sair?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.Yes)
                        {
                            {
                                InserirCliente janela = new InserirCliente();
                                janela.Show();
                                Close();
                            }
                        }
                    }
                    if (_operacao == "editar")
                    {
                        if (rbm.Checked)
                            genero = rbm.Text;
                        else
                            genero = rbf.Text;
                        clienteTA.Update(txtnome.Text, txtmorada.Text, mtxtcodpostal.Text, txtlocalidade.Text, mtxtnif.Text, mtxtdata.Text, genero, mtxtaltura.Text, mtxttelemovel.Text, txtemail.Text, txtemail2.Text, mtxtdatainsc.Text, cbotipo.Text, decimal.Parse(txtvalor.Text), txtobs.Text, _valor, _valor);
                        DialogResult resposta = MessageBox.Show("Cliente editado com sucesso! Deseja sair?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.Yes)
                        {
                            {
                                InserirCliente janela = new InserirCliente();
                                janela.Show();
                                Close();
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
}
