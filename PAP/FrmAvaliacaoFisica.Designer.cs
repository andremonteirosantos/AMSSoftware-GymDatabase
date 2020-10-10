namespace PAP
{
    partial class FrmAvaliacaoFisica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label iMGLabel;
            System.Windows.Forms.Label iMCLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtmm = new System.Windows.Forms.TextBox();
            this.txtmg = new System.Windows.Forms.TextBox();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.dtpavaliacao = new System.Windows.Forms.DateTimePicker();
            this.viewAvaliacaodgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAvaliacaoBS = new System.Windows.Forms.BindingSource(this.components);
            this.pAPDataSet = new PAP.PAPDataSet();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.avaliacaoFisicaBS = new System.Windows.Forms.BindingSource(this.components);
            this.avaliacaoFisicaTA = new PAP.PAPDataSetTableAdapters.AvaliacaoFisicaTableAdapter();
            this.clienteBS = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTA = new PAP.PAPDataSetTableAdapters.clienteTableAdapter();
            this.viewAvaliacaoTA = new PAP.PAPDataSetTableAdapters.viewAvaliacaoTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            iMGLabel = new System.Windows.Forms.Label();
            iMCLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAvaliacaodgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAvaliacaoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoFisicaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Red;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(43, 33);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 25);
            label1.TabIndex = 97;
            label1.Text = "Nome";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Red;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(43, 75);
            label3.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 25);
            label3.TabIndex = 96;
            label3.Text = "Altura (Cm)";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Red;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.Control;
            label4.Location = new System.Drawing.Point(43, 156);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 25);
            label4.TabIndex = 91;
            label4.Text = "Peso (Kg)";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Red;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(598, 28);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(185, 25);
            label2.TabIndex = 107;
            label2.Text = "% Massa Magra";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iMGLabel
            // 
            iMGLabel.BackColor = System.Drawing.Color.Red;
            iMGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iMGLabel.ForeColor = System.Drawing.SystemColors.Control;
            iMGLabel.Location = new System.Drawing.Point(318, 28);
            iMGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iMGLabel.Name = "iMGLabel";
            iMGLabel.Size = new System.Drawing.Size(185, 25);
            iMGLabel.TabIndex = 106;
            iMGLabel.Text = "% Massa Gorda ";
            iMGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iMCLabel
            // 
            iMCLabel.BackColor = System.Drawing.Color.Red;
            iMCLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iMCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iMCLabel.ForeColor = System.Drawing.SystemColors.Control;
            iMCLabel.Location = new System.Drawing.Point(38, 28);
            iMCLabel.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            iMCLabel.Name = "iMCLabel";
            iMCLabel.Size = new System.Drawing.Size(185, 25);
            iMCLabel.TabIndex = 105;
            iMCLabel.Text = "% Massa Corporal ";
            iMCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Red;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(43, 196);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 25);
            label5.TabIndex = 102;
            label5.Text = "Idade";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Red;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(43, 115);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(91, 25);
            label6.TabIndex = 104;
            label6.Text = "Sexo";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.viewAvaliacaodgv);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 552);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.txtmm);
            this.panel2.Controls.Add(this.txtmg);
            this.panel2.Controls.Add(this.txtimc);
            this.panel2.Controls.Add(iMCLabel);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(iMGLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 84);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(928, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 112;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.pictureBox11.Image = global::PAP.Properties.Resources.icons8_info_24;
            this.pictureBox11.Location = new System.Drawing.Point(1096, 0);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 111;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Visible = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1026, 52);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 28);
            this.button4.TabIndex = 101;
            this.button4.Text = "Inserir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtmm
            // 
            this.txtmm.Location = new System.Drawing.Point(779, 28);
            this.txtmm.Margin = new System.Windows.Forms.Padding(4);
            this.txtmm.Multiline = true;
            this.txtmm.Name = "txtmm";
            this.txtmm.ReadOnly = true;
            this.txtmm.Size = new System.Drawing.Size(67, 25);
            this.txtmm.TabIndex = 110;
            // 
            // txtmg
            // 
            this.txtmg.Location = new System.Drawing.Point(499, 28);
            this.txtmg.Margin = new System.Windows.Forms.Padding(4);
            this.txtmg.Multiline = true;
            this.txtmg.Name = "txtmg";
            this.txtmg.ReadOnly = true;
            this.txtmg.Size = new System.Drawing.Size(67, 25);
            this.txtmg.TabIndex = 109;
            this.txtmg.TextChanged += new System.EventHandler(this.txtmg_TextChanged);
            // 
            // txtimc
            // 
            this.txtimc.Location = new System.Drawing.Point(219, 28);
            this.txtimc.Margin = new System.Windows.Forms.Padding(4);
            this.txtimc.Multiline = true;
            this.txtimc.Name = "txtimc";
            this.txtimc.ReadOnly = true;
            this.txtimc.Size = new System.Drawing.Size(67, 25);
            this.txtimc.TabIndex = 108;
            this.txtimc.TextChanged += new System.EventHandler(this.txtimc_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtaltura);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.txtidade);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtpeso);
            this.panel1.Controls.Add(this.dtpavaliacao);
            this.panel1.Controls.Add(label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 238);
            this.panel1.TabIndex = 0;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(132, 75);
            this.txtaltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtaltura.Multiline = true;
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.ReadOnly = true;
            this.txtaltura.Size = new System.Drawing.Size(67, 25);
            this.txtaltura.TabIndex = 106;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(81, 25);
            this.textBox1.TabIndex = 105;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(132, 196);
            this.txtidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtidade.Multiline = true;
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(67, 25);
            this.txtidade.TabIndex = 103;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1026, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 100;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 33);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(281, 25);
            this.textBox6.TabIndex = 98;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(132, 156);
            this.txtpeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtpeso.Multiline = true;
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(67, 25);
            this.txtpeso.TabIndex = 92;
            // 
            // dtpavaliacao
            // 
            this.dtpavaliacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpavaliacao.Location = new System.Drawing.Point(1010, 13);
            this.dtpavaliacao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpavaliacao.Name = "dtpavaliacao";
            this.dtpavaliacao.Size = new System.Drawing.Size(103, 22);
            this.dtpavaliacao.TabIndex = 84;
            // 
            // viewAvaliacaodgv
            // 
            this.viewAvaliacaodgv.AllowUserToAddRows = false;
            this.viewAvaliacaodgv.AllowUserToDeleteRows = false;
            this.viewAvaliacaodgv.AutoGenerateColumns = false;
            this.viewAvaliacaodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAvaliacaodgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1});
            this.viewAvaliacaodgv.DataSource = this.viewAvaliacaoBS;
            this.viewAvaliacaodgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAvaliacaodgv.Location = new System.Drawing.Point(0, 0);
            this.viewAvaliacaodgv.Name = "viewAvaliacaodgv";
            this.viewAvaliacaodgv.ReadOnly = true;
            this.viewAvaliacaodgv.RowTemplate.Height = 24;
            this.viewAvaliacaodgv.Size = new System.Drawing.Size(1126, 225);
            this.viewAvaliacaodgv.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idcliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "idcliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn8.FillWeight = 150F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Idade";
            this.dataGridViewTextBoxColumn9.FillWeight = 30F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Peso";
            this.dataGridViewTextBoxColumn3.FillWeight = 30F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Peso (kg)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IMC";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Índice de Massa Corporal (%)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IMG";
            this.dataGridViewTextBoxColumn5.FillWeight = 30F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Índice de Massa Gorda (%)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IMM";
            this.dataGridViewTextBoxColumn6.FillWeight = 30F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Índice de Massa Magra (%)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AvaliacaoData";
            this.dataGridViewTextBoxColumn1.FillWeight = 65F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Data da Avaliação";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // viewAvaliacaoBS
            // 
            this.viewAvaliacaoBS.DataMember = "viewAvaliacao";
            this.viewAvaliacaoBS.DataSource = this.pAPDataSet;
            // 
            // pAPDataSet
            // 
            this.pAPDataSet.DataSetName = "PAPDataSet";
            this.pAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // erros
            // 
            this.erros.BlinkRate = 0;
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            // 
            // avaliacaoFisicaBS
            // 
            this.avaliacaoFisicaBS.DataMember = "AvaliacaoFisica";
            this.avaliacaoFisicaBS.DataSource = this.pAPDataSet;
            // 
            // avaliacaoFisicaTA
            // 
            this.avaliacaoFisicaTA.ClearBeforeFill = true;
            // 
            // clienteBS
            // 
            this.clienteBS.DataMember = "cliente";
            this.clienteBS.DataSource = this.pAPDataSet;
            // 
            // clienteTA
            // 
            this.clienteTA.ClearBeforeFill = true;
            // 
            // viewAvaliacaoTA
            // 
            this.viewAvaliacaoTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Aula_AlunosTableAdapter = null;
            this.tableAdapterManager.Aula_TreinadorTableAdapter = null;
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.AvaliacaoFisicaTableAdapter = this.avaliacaoFisicaTA;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTA;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.inscricoesTableAdapter = null;
            this.tableAdapterManager.ModalidadesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmAvaliacaoFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 552);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAvaliacaoFisica";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação Física";
            this.Load += new System.EventHandler(this.FrmAvaliacaoFisica_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAvaliacaodgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAvaliacaoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoFisicaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private PAPDataSet pAPDataSet;
        private PAPDataSetTableAdapters.AvaliacaoFisicaTableAdapter avaliacaoFisicaTA;
        private System.Windows.Forms.BindingSource avaliacaoFisicaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource clienteBS;
        private PAPDataSetTableAdapters.clienteTableAdapter clienteTA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmm;
        private System.Windows.Forms.TextBox txtmg;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.DateTimePicker dtpavaliacao;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.BindingSource viewAvaliacaoBS;
        private PAPDataSetTableAdapters.viewAvaliacaoTableAdapter viewAvaliacaoTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView viewAvaliacaodgv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button button2;
    }
}