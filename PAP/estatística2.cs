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
    public partial class estatística : Form
    {
        public estatística()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pAPDataSet);

        }

        private void estatística2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAPDataSet.AvaliacaoFisica' table. You can move, or remove it, as needed.
            this.avaliacaoFisicaTA.Fill(this.pAPDataSet.AvaliacaoFisica);
            // TODO: This line of code loads data into the 'pAPDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTA.Fill(this.pAPDataSet.cliente);           
            Peso.Series["Avaliação"].XValueMember = "Peso";
            Peso.Series["Avaliação"].YValueMembers = "Peso";
            Peso.DataSource = pAPDataSet.AvaliacaoFisica;
            Peso.DataBind();
            //IMC.Series["Avaliação"].XValueMember = "IMC";
            //IMC.Series["Avaliação"].YValueMembers = "AvaliacaoData";
            //IMC.DataSource = pAPDataSet.AvaliacaoFisica;
            //IMC.DataBind();
            //IMG.Series["Avaliação"].XValueMember = "IMG";
            //IMG.Series["Avaliação"].YValueMembers = "AvaliacaoData";
            //IMG.DataSource = pAPDataSet.AvaliacaoFisica;
            //IMG.DataBind();
            //IMM.Series["Avaliação"].XValueMember = "IMM";
            //IMM.Series["Avaliação"].YValueMembers = "AvaliacaoData";
            //IMM.DataSource = pAPDataSet.AvaliacaoFisica;
            //IMM.DataBind();
        }

        private void Peso_Click(object sender, EventArgs e)
        {

        }
    }
}
