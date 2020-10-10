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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAPDataSet.viewFatura' table. You can move, or remove it, as needed.
            this.viewFaturaTA.Fill(this.pAPDataSet.viewFatura);
            // TODO: This line of code loads data into the 'pAPDataSet.viewCabecalhoFatura' table. You can move, or remove it, as needed.
            this.viewCabecalhoFaturaTA.Fill(this.pAPDataSet.viewCabecalhoFatura);

        }
    }
}
