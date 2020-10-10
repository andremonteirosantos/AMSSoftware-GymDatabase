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
    public partial class Estatísca_Geral : UserControl
    {
        public Estatísca_Geral()
        {
            InitializeComponent();
            int total_Clientes = 0;
            total_Clientes = (int)clienteTA.ScalarQueryTOTAL_CLIENT();
            txtTotalClientes.Text = total_Clientes.ToString();

            int total_Funcionarios = 0;
            total_Funcionarios = (int)funcionarioTA.ScalarQueryTOTAL_FUNC();
            txtTOTALFUNC.Text = total_Funcionarios.ToString();            

            int total_Aulas = 0;
            total_Aulas = (int)aulaTA.ScalarQueryNUM_AULA();
            txtaulas.Text = total_Aulas.ToString();

            int total_Modalidades = 0;
            total_Modalidades = (int)modalidadesTA.ScalarQueryNUM_MOD();
            txtmodalidades.Text = total_Modalidades.ToString();

            int total_Func_Masc = 0;
            total_Func_Masc = (int)funcionarioTA.ScalarQueryTotalFuncMasculino();
            txtTotalHomens.Text = total_Func_Masc.ToString();

            int total_Func_Fem = 0;
            total_Func_Fem = (int)funcionarioTA.ScalarQueryTotalFuncFeminino();
            txtTotalMulheres.Text = total_Func_Fem.ToString();

            int total_Cliente_Masc = 0;
            total_Cliente_Masc = (int)clienteTA.ScalarQueryTotalClienteMasculino();
            txtTotalHomensCliente.Text = total_Cliente_Masc.ToString();

            int total_Cliente_Fem = 0;
            total_Cliente_Fem = (int)clienteTA.ScalarQueryTotalClienteFeminino();
            txtTotalMulheresClientes.Text = total_Cliente_Fem.ToString();

            int total_ADM = 0;
            total_ADM = (int)funcionarioTA.ScalarQueryTOTALADM();
            txtTotalADM.Text = total_ADM.ToString();

            int total_SECR = 0;
            total_SECR = (int)funcionarioTA.ScalarQueryTOTALSECR();
            txtTOTALSECR.Text = total_SECR.ToString();

            int total_Treinadores = 0;
            total_Treinadores = (int)funcionarioTA.ScalarQueryTOTALTREINADOR();
            txtTOTALTREI.Text = total_Treinadores.ToString();

            int total_Semanal = 0;
            total_Semanal = (int)clienteTA.ScalarQueryTipoSemanal();
            txtsemanal.Text = total_Semanal.ToString();

            int total_Mensal = 0;
            total_Mensal = (int)clienteTA.ScalarQueryTipoMensal();
            txtmensal.Text = total_Mensal.ToString();

            int total_Anual = 0;
            total_Anual = (int)clienteTA.ScalarQueryTipoAnual();
            txtanual.Text = total_Anual.ToString();

            int lucro = 0;
            lucro = (int)clienteTA.ScalarQueryLucro();
            txtlucro.Text = lucro.ToString() + "€";

            int total_Vendas = 0;
            total_Vendas = (int)viewCabecalhoFaturaTA.ScalarQueryTotalVendas();
            txttotalvendas.Text = total_Vendas.ToString();

            int lucroLoja = 0;
            lucroLoja = (int)viewFaturaTA.LucroLoja();
            txtlucrovendas.Text = lucroLoja.ToString() + "€";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlucro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
