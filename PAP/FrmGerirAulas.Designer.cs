namespace PAP
{
    partial class FrmGerirAulas
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
            System.Windows.Forms.Label idmodalidadeLabel;
            System.Windows.Forms.Label diaDaSemanaLabel;
            System.Windows.Forms.Label localGinasioLabel;
            System.Windows.Forms.Label duracaoLabel;
            System.Windows.Forms.Label horaInicioLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerirAulas));
            this.txtginasio = new System.Windows.Forms.TextBox();
            this.txtduracao = new System.Windows.Forms.TextBox();
            this.txtalunos = new System.Windows.Forms.TextBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.cbomodalidade = new System.Windows.Forms.ComboBox();
            this.lbltreinador = new System.Windows.Forms.Label();
            this.cbotreinador = new System.Windows.Forms.ComboBox();
            this.funcionarioBS = new System.Windows.Forms.BindingSource(this.components);
            this.pAPDataSet = new PAP.PAPDataSet();
            this.funcionarioTA = new PAP.PAPDataSetTableAdapters.funcionarioTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            this.aula_PresencaBS = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboclientes = new System.Windows.Forms.ComboBox();
            this.clienteBS = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTA = new PAP.PAPDataSetTableAdapters.clienteTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.aula_Treinadordgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula_TreinadorBS = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.aula_TreinadorTA = new PAP.PAPDataSetTableAdapters.Aula_TreinadorTableAdapter();
            this.aula_AlunosBS = new System.Windows.Forms.BindingSource(this.components);
            this.aula_AlunosTA = new PAP.PAPDataSetTableAdapters.Aula_AlunosTableAdapter();
            this.aula_AlunosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            idmodalidadeLabel = new System.Windows.Forms.Label();
            diaDaSemanaLabel = new System.Windows.Forms.Label();
            localGinasioLabel = new System.Windows.Forms.Label();
            duracaoLabel = new System.Windows.Forms.Label();
            horaInicioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_PresencaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aula_Treinadordgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_TreinadorBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_AlunosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_AlunosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(21, 159);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 21);
            label1.TabIndex = 26;
            label1.Text = "Número Max de Alunos";
            // 
            // idmodalidadeLabel
            // 
            idmodalidadeLabel.AutoSize = true;
            idmodalidadeLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idmodalidadeLabel.Location = new System.Drawing.Point(110, 130);
            idmodalidadeLabel.Name = "idmodalidadeLabel";
            idmodalidadeLabel.Size = new System.Drawing.Size(115, 21);
            idmodalidadeLabel.TabIndex = 25;
            idmodalidadeLabel.Text = "Modalidade";
            // 
            // diaDaSemanaLabel
            // 
            diaDaSemanaLabel.AutoSize = true;
            diaDaSemanaLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaDaSemanaLabel.Location = new System.Drawing.Point(115, 101);
            diaDaSemanaLabel.Name = "diaDaSemanaLabel";
            diaDaSemanaLabel.Size = new System.Drawing.Size(110, 21);
            diaDaSemanaLabel.TabIndex = 24;
            diaDaSemanaLabel.Text = "Dia da Aula";
            // 
            // localGinasioLabel
            // 
            localGinasioLabel.AutoSize = true;
            localGinasioLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localGinasioLabel.Location = new System.Drawing.Point(98, 72);
            localGinasioLabel.Name = "localGinasioLabel";
            localGinasioLabel.Size = new System.Drawing.Size(127, 21);
            localGinasioLabel.TabIndex = 23;
            localGinasioLabel.Text = "Local da Aula";
            // 
            // duracaoLabel
            // 
            duracaoLabel.AutoSize = true;
            duracaoLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duracaoLabel.Location = new System.Drawing.Point(40, 43);
            duracaoLabel.Name = "duracaoLabel";
            duracaoLabel.Size = new System.Drawing.Size(185, 21);
            duracaoLabel.TabIndex = 22;
            duracaoLabel.Text = "Duração em Minutos";
            // 
            // horaInicioLabel
            // 
            horaInicioLabel.AutoSize = true;
            horaInicioLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaInicioLabel.Location = new System.Drawing.Point(27, 14);
            horaInicioLabel.Name = "horaInicioLabel";
            horaInicioLabel.Size = new System.Drawing.Size(198, 21);
            horaInicioLabel.TabIndex = 21;
            horaInicioLabel.Text = "Hora de Inicio da Aula";
            // 
            // txtginasio
            // 
            this.txtginasio.Location = new System.Drawing.Point(231, 73);
            this.txtginasio.Name = "txtginasio";
            this.txtginasio.ReadOnly = true;
            this.txtginasio.Size = new System.Drawing.Size(200, 22);
            this.txtginasio.TabIndex = 29;
            // 
            // txtduracao
            // 
            this.txtduracao.Location = new System.Drawing.Point(231, 45);
            this.txtduracao.Name = "txtduracao";
            this.txtduracao.ReadOnly = true;
            this.txtduracao.Size = new System.Drawing.Size(100, 22);
            this.txtduracao.TabIndex = 28;
            // 
            // txtalunos
            // 
            this.txtalunos.Location = new System.Drawing.Point(231, 159);
            this.txtalunos.Name = "txtalunos";
            this.txtalunos.ReadOnly = true;
            this.txtalunos.Size = new System.Drawing.Size(100, 22);
            this.txtalunos.TabIndex = 27;
            // 
            // dtpdata
            // 
            this.dtpdata.Enabled = false;
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(231, 102);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(100, 22);
            this.dtpdata.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Inserir Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(231, 15);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(48, 22);
            this.maskedTextBox2.TabIndex = 17;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // cbomodalidade
            // 
            this.cbomodalidade.DisplayMember = "NomeModalidade";
            this.cbomodalidade.Enabled = false;
            this.cbomodalidade.FormattingEnabled = true;
            this.cbomodalidade.Location = new System.Drawing.Point(231, 131);
            this.cbomodalidade.Name = "cbomodalidade";
            this.cbomodalidade.Size = new System.Drawing.Size(200, 24);
            this.cbomodalidade.TabIndex = 19;
            this.cbomodalidade.ValueMember = "idModalidade";
            // 
            // lbltreinador
            // 
            this.lbltreinador.AutoSize = true;
            this.lbltreinador.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltreinador.Location = new System.Drawing.Point(14, 15);
            this.lbltreinador.Name = "lbltreinador";
            this.lbltreinador.Size = new System.Drawing.Size(175, 21);
            this.lbltreinador.TabIndex = 30;
            this.lbltreinador.Text = "Nome do Treinador \r\n";
            // 
            // cbotreinador
            // 
            this.cbotreinador.DataSource = this.funcionarioBS;
            this.cbotreinador.DisplayMember = "Nome";
            this.cbotreinador.FormattingEnabled = true;
            this.cbotreinador.Location = new System.Drawing.Point(195, 15);
            this.cbotreinador.Name = "cbotreinador";
            this.cbotreinador.Size = new System.Drawing.Size(265, 24);
            this.cbotreinador.TabIndex = 32;
            this.cbotreinador.ValueMember = "idfuncionario";
            this.cbotreinador.SelectedIndexChanged += new System.EventHandler(this.cbotreinador_SelectedIndexChanged);
            // 
            // funcionarioBS
            // 
            this.funcionarioBS.DataMember = "funcionario";
            this.funcionarioBS.DataSource = this.pAPDataSet;
            // 
            // pAPDataSet
            // 
            this.pAPDataSet.DataSetName = "PAPDataSet";
            this.pAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTA
            // 
            this.funcionarioTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Aula_AlunosTableAdapter = null;
            this.tableAdapterManager.Aula_TreinadorTableAdapter = null;
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.AvaliacaoFisicaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = this.funcionarioTA;
            this.tableAdapterManager.inscricoesTableAdapter = null;
            this.tableAdapterManager.ModalidadesTableAdapter = null;
            //this.tableAdapterManager.ProdutosTableAdapter = null;
            //this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Clientes";
            // 
            // cboclientes
            // 
            this.cboclientes.DataSource = this.clienteBS;
            this.cboclientes.DisplayMember = "Nome";
            this.cboclientes.FormattingEnabled = true;
            this.cboclientes.Location = new System.Drawing.Point(102, 59);
            this.cboclientes.Name = "cboclientes";
            this.cboclientes.Size = new System.Drawing.Size(265, 24);
            this.cboclientes.TabIndex = 35;
            this.cboclientes.ValueMember = "idcliente";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.aula_AlunosDataGridView);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cboclientes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 237);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 2);
            this.panel1.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.maskedTextBox2);
            this.panel3.Controls.Add(this.cbomodalidade);
            this.panel3.Controls.Add(this.dtpdata);
            this.panel3.Controls.Add(idmodalidadeLabel);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(horaInicioLabel);
            this.panel3.Controls.Add(diaDaSemanaLabel);
            this.panel3.Controls.Add(this.txtginasio);
            this.panel3.Controls.Add(this.txtalunos);
            this.panel3.Controls.Add(duracaoLabel);
            this.panel3.Controls.Add(localGinasioLabel);
            this.panel3.Controls.Add(this.txtduracao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 197);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.aula_Treinadordgv);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.lbltreinador);
            this.panel4.Controls.Add(this.cbotreinador);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(463, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 197);
            this.panel4.TabIndex = 38;
            // 
            // aula_Treinadordgv
            // 
            this.aula_Treinadordgv.AllowUserToAddRows = false;
            this.aula_Treinadordgv.AllowUserToDeleteRows = false;
            this.aula_Treinadordgv.AutoGenerateColumns = false;
            this.aula_Treinadordgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.aula_Treinadordgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aula_Treinadordgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.aula_Treinadordgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aula_Treinadordgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.aula_Treinadordgv.DataSource = this.aula_TreinadorBS;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aula_Treinadordgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.aula_Treinadordgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.aula_Treinadordgv.Location = new System.Drawing.Point(146, 57);
            this.aula_Treinadordgv.Name = "aula_Treinadordgv";
            this.aula_Treinadordgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aula_Treinadordgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.aula_Treinadordgv.RowHeadersVisible = false;
            this.aula_Treinadordgv.RowTemplate.Height = 24;
            this.aula_Treinadordgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aula_Treinadordgv.Size = new System.Drawing.Size(258, 67);
            this.aula_Treinadordgv.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idaula";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "idaula";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idfuncionario";
            this.dataGridViewTextBoxColumn4.HeaderText = "idfuncionario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // aula_TreinadorBS
            // 
            this.aula_TreinadorBS.DataMember = "Aula_Treinador";
            this.aula_TreinadorBS.DataSource = this.pAPDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 33;
            this.button2.Text = "Inserir Treinador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aula_TreinadorTA
            // 
            this.aula_TreinadorTA.ClearBeforeFill = true;
            // 
            // aula_AlunosBS
            // 
            this.aula_AlunosBS.DataMember = "Aula_Alunos";
            this.aula_AlunosBS.DataSource = this.pAPDataSet;
            // 
            // aula_AlunosTA
            // 
            this.aula_AlunosTA.ClearBeforeFill = true;
            // 
            // aula_AlunosDataGridView
            // 
            this.aula_AlunosDataGridView.AllowUserToAddRows = false;
            this.aula_AlunosDataGridView.AllowUserToDeleteRows = false;
            this.aula_AlunosDataGridView.AutoGenerateColumns = false;
            this.aula_AlunosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.aula_AlunosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aula_AlunosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.aula_AlunosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aula_AlunosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.aula_AlunosDataGridView.DataSource = this.aula_AlunosBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aula_AlunosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.aula_AlunosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.aula_AlunosDataGridView.Location = new System.Drawing.Point(641, 24);
            this.aula_AlunosDataGridView.Name = "aula_AlunosDataGridView";
            this.aula_AlunosDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aula_AlunosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.aula_AlunosDataGridView.RowHeadersVisible = false;
            this.aula_AlunosDataGridView.RowTemplate.Height = 24;
            this.aula_AlunosDataGridView.Size = new System.Drawing.Size(226, 201);
            this.aula_AlunosDataGridView.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idaula";
            this.dataGridViewTextBoxColumn5.HeaderText = "idaula";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idcliente";
            this.dataGridViewTextBoxColumn6.FillWeight = 120F;
            this.dataGridViewTextBoxColumn6.HeaderText = "idcliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FrmGerirAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 434);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGerirAulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Aulas";
            this.Load += new System.EventHandler(this.FrmGerirAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_PresencaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aula_Treinadordgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_TreinadorBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_AlunosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_AlunosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtginasio;
        private System.Windows.Forms.TextBox txtduracao;
        private System.Windows.Forms.TextBox txtalunos;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ComboBox cbomodalidade;
        private System.Windows.Forms.Label lbltreinador;
        private System.Windows.Forms.ComboBox cbotreinador;
        private PAPDataSet pAPDataSet;
        private PAPDataSetTableAdapters.funcionarioTableAdapter funcionarioTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource funcionarioBS;
        private System.Windows.Forms.BindingSource aula_PresencaBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboclientes;
        private System.Windows.Forms.BindingSource clienteBS;
        private PAPDataSetTableAdapters.clienteTableAdapter clienteTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource aula_TreinadorBS;
        private PAPDataSetTableAdapters.Aula_TreinadorTableAdapter aula_TreinadorTA;
        private System.Windows.Forms.DataGridView aula_Treinadordgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource aula_AlunosBS;
        private PAPDataSetTableAdapters.Aula_AlunosTableAdapter aula_AlunosTA;
        private System.Windows.Forms.DataGridView aula_AlunosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}