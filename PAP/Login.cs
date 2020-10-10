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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool temerros = false;
            erros.Clear();

            if (txtuser.Text == "Username")
            {
                erros.SetError(txtuser, "Username Obrigatório");
                temerros = true;
            }

            if (txtuser.Text == "")
            {
                erros.SetError(txtuser, "Username Obrigatório");
                temerros = true;
            }

            if (txtpass.Text == "Password")
            {
                erros.SetError(txtpass, "Password Obrigatória");
                temerros = true;
            }

            if (txtpass.Text == "")
            {
                erros.SetError(txtpass, "Password Obrigatória");
                temerros = true;
            }
            else
            {
                int total = funcionarioTA.GetDataByLogin(txtuser.Text, txtpass.Text).Rows.Count;               
                if (total == 0)
                {
                    DialogResult resposta = MessageBox.Show("Credenciais Inválidas!", "Fechar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    temerros = true;
                }
            }
            return temerros;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAPDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTA.Fill(this.pAPDataSet.funcionario);
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

     

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (Validar() == false)
            {
                string funcao = Convert.ToString(funcionarioTA.GetDataByUser(txtuser.Text).Rows[0][8]);
                if (funcao == "Administrador")
                {
                    FrmAdministrador janela = new FrmAdministrador();
                    janela.Show();

                }
                if (funcao == "Treinador")
                {
                    FrmTreinador janela = new FrmTreinador();
                    janela.Show();
                }
                if (funcao == "Secretário")
                {
                    FrmSecretario janela = new FrmSecretario();
                    janela.Show();
                }
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //DialogResult resposta = MessageBox.Show("Deseja encerrar a aplicação?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (resposta == DialogResult.Yes)
            //{
            //    {
            Application.Exit();
            //    }
            //}
        }

        private void txtuser_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
