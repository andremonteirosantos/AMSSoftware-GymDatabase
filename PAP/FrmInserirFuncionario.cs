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
    public partial class FrmInserirFuncionario : Form
    {
        string _operacao;
        int _valor;

        public FrmInserirFuncionario(string operacao)
        {
            InitializeComponent();
            _operacao = operacao;
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

            if (!mtxtdata.MaskFull)
            {
                erros.SetError(mtxtdata, "Data de Nascimento Obrigatória");
                temerros = true;
            }

            if (!mtxtnif.MaskFull)
            {
                erros.SetError(mtxtnif, "NIF Obrigatório");
                temerros = true;
            }

            int nresgisto = funcionarioTA.GetDataByNif(mtxtnif.Text).Rows.Count;
            if ((nresgisto >= 1) && (_operacao == "novo"))
            {
                DialogResult resposta = MessageBox.Show("Este NIF já está regístado na base de dados!", "Fechar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                temerros = true;
            }

            if (txtmorada.Text == "")
            {
                erros.SetError(txtmorada, "Morada Obrigatória");
                temerros = true;
            }

            if (!mtxtcodpostal.MaskFull)
            {
                erros.SetError(mtxtcodpostal, "Campo Obrigatório");
                temerros = true;
            }

            if (txtlocalidade.Text == "")
            {
                erros.SetError(txtlocalidade, "Localidade Obrigatória");
                temerros = true;
            }

            if (mtxttelemovel.Text == "")
            {
                erros.SetError(mtxttelemovel, "NºTelemóvel Obrigatório");
                temerros = true;
            }

            if (txtemail.Text == "")
            {
                erros.SetError(txtemail, "Email Obrigatório");
                temerros = true;
            }

            if (txtuser.Text == "")
            {
                erros.SetError(txtuser, "Username Obrigatório");
                temerros = true;
            }

            int nresgisto_user = funcionarioTA.GetDataByUser(txtuser.Text).Rows.Count;
            if ((nresgisto_user >= 1) && (_operacao == "novo"))
            {
                DialogResult resposta = MessageBox.Show("Este Username já está regístado na base de dados!", "Fechar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                temerros = true;
            }

            if (txtpass.Text == "")
            {
                erros.SetError(txtpass, "Password Obrigatória");
                temerros = true;
            }
            return temerros;
        }

        public FrmInserirFuncionario(string operacao, string nome, string funcao, string morada, string telemovel, string genero, string data, string email, string username, string password, string codpostal, string localidade, string nif, int valor)
        {
            InitializeComponent();
            _operacao = operacao;
            _valor = valor;

            txtnome.Text = nome;
            cbofuncao.Text = funcao;
            txtmorada.Text = morada;
            mtxttelemovel.Text = telemovel;
            if (genero == "Masculino")
                rbm.Checked = true;
            else
                rbf.Checked = true;
            mtxtdata.Text = data;
            txtemail.Text = email;
            txtuser.Text = username;
            txtpass.Text = password;
            mtxtcodpostal.Text = codpostal;
            txtlocalidade.Text = localidade;
            mtxtnif.Text = nif;
            mtxtnif.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
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
                        funcionarioTA.Insert(txtnome.Text, txtmorada.Text, mtxtcodpostal.Text, txtlocalidade.Text, mtxtnif.Text, mtxtdata.Text, genero, cbofuncao.Text, mtxttelemovel.Text, txtemail.Text, txtuser.Text, txtpass.Text);
                        funcionarioTA.Update(pAPDataSet.funcionario);
                        this.funcionarioTA.Fill(this.pAPDataSet.funcionario);
                        DialogResult resposta = MessageBox.Show("Funcionário inserido com sucesso!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (_operacao == "editar")
                    {
                        if (rbm.Checked)
                            genero = rbm.Text;
                        else
                            genero = rbf.Text;
                        funcionarioTA.Update(txtnome.Text, txtmorada.Text, mtxtcodpostal.Text, txtlocalidade.Text, mtxtnif.Text, mtxtdata.Text, genero, cbofuncao.Text, mtxttelemovel.Text, txtemail.Text, txtuser.Text, txtpass.Text, _valor, _valor);
                    }
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void FrmInserirFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'pAPDataSet.funcionario' table. You can move, or remove it, as needed.
                this.funcionarioTA.Fill(this.pAPDataSet.funcionario);
                // TODO: This line of code loads data into the 'pAPDataSet.funcionario' table. You can move, or remove it, as needed.
                this.funcionarioTA.Fill(this.pAPDataSet.funcionario);
                this.cbofuncao.DropDownStyle = ComboBoxStyle.DropDownList;
                if (_operacao == "visualizar")
                {
                    txtnome.ReadOnly = true;
                    cbofuncao.Enabled = false;
                    mtxtdata.ReadOnly = true;
                    mtxtnif.ReadOnly = true;
                    txtmorada.ReadOnly = true;
                    mtxtcodpostal.ReadOnly = true;
                    txtlocalidade.ReadOnly = true;
                    mtxttelemovel.ReadOnly = true;
                    txtemail.ReadOnly = true;
                    //groupBox4.Enabled = false;
                    button2.Visible = false;
                    txtuser.ReadOnly = true;
                    txtpass.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void funcionarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void FrmInserirFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_operacao == "novo")
            {
                DialogResult resposta = MessageBox.Show("Tem a certeza que deseja fechar?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.No)
                {
                    {
                        e.Cancel = true;
                    }
                }
                
            }
            if (_operacao == "editar")
            {
                DialogResult resposta = MessageBox.Show("Tem a certeza que deseja fechar?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.No)
                {
                    {
                        e.Cancel = true;
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
    }
}

