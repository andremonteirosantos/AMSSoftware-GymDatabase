namespace PAP
{
    partial class FrmGerirAula
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
            System.Windows.Forms.Label idclienteLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerirAula));
            this.txtginasio = new System.Windows.Forms.TextBox();
            this.txtduracao = new System.Windows.Forms.TextBox();
            this.txtalunos = new System.Windows.Forms.TextBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.mtxthora = new System.Windows.Forms.MaskedTextBox();
            this.cbomodalidade = new System.Windows.Forms.ComboBox();
            this.modalidadesBS = new System.Windows.Forms.BindingSource(this.components);
            this.pAPDataSet = new PAP.PAPDataSet();
            this.aula_AlunosBS = new System.Windows.Forms.BindingSource(this.components);
            this.aula_AlunosTA = new PAP.PAPDataSetTableAdapters.Aula_AlunosTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            this.cboalunos = new System.Windows.Forms.ComboBox();
            this.viewInscricoes1BS = new System.Windows.Forms.BindingSource(this.components);
            this.viewInscricoes1TA = new PAP.PAPDataSetTableAdapters.viewInscricoes1TableAdapter();
            this.modalidadesTA = new PAP.PAPDataSetTableAdapters.ModalidadesTableAdapter();
            this.aula_TreinadorBS = new System.Windows.Forms.BindingSource(this.components);
            this.aula_TreinadorTA = new PAP.PAPDataSetTableAdapters.Aula_TreinadorTableAdapter();
            this.cbotreinador = new System.Windows.Forms.ComboBox();
            this.funcionarioBS = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTA = new PAP.PAPDataSetTableAdapters.funcionarioTableAdapter();
            this.treinadordgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunosdgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btguardar = new System.Windows.Forms.Button();
            this.btguardar_A = new System.Windows.Forms.Button();
            this.btremoverT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            idmodalidadeLabel = new System.Windows.Forms.Label();
            diaDaSemanaLabel = new System.Windows.Forms.Label();
            localGinasioLabel = new System.Windows.Forms.Label();
            duracaoLabel = new System.Windows.Forms.Label();
            horaInicioLabel = new System.Windows.Forms.Label();
            idclienteLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_AlunosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInscricoes1BS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_TreinadorBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinadordgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(7, 156);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 21);
            label1.TabIndex = 25;
            label1.Text = "Número Max de Alunos";
            // 
            // idmodalidadeLabel
            // 
            idmodalidadeLabel.AutoSize = true;
            idmodalidadeLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idmodalidadeLabel.Location = new System.Drawing.Point(96, 127);
            idmodalidadeLabel.Name = "idmodalidadeLabel";
            idmodalidadeLabel.Size = new System.Drawing.Size(115, 21);
            idmodalidadeLabel.TabIndex = 24;
            idmodalidadeLabel.Text = "Modalidade";
            // 
            // diaDaSemanaLabel
            // 
            diaDaSemanaLabel.AutoSize = true;
            diaDaSemanaLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaDaSemanaLabel.Location = new System.Drawing.Point(101, 98);
            diaDaSemanaLabel.Name = "diaDaSemanaLabel";
            diaDaSemanaLabel.Size = new System.Drawing.Size(110, 21);
            diaDaSemanaLabel.TabIndex = 23;
            diaDaSemanaLabel.Text = "Dia da Aula";
            // 
            // localGinasioLabel
            // 
            localGinasioLabel.AutoSize = true;
            localGinasioLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localGinasioLabel.Location = new System.Drawing.Point(84, 69);
            localGinasioLabel.Name = "localGinasioLabel";
            localGinasioLabel.Size = new System.Drawing.Size(127, 21);
            localGinasioLabel.TabIndex = 22;
            localGinasioLabel.Text = "Local da Aula";
            // 
            // duracaoLabel
            // 
            duracaoLabel.AutoSize = true;
            duracaoLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duracaoLabel.Location = new System.Drawing.Point(26, 40);
            duracaoLabel.Name = "duracaoLabel";
            duracaoLabel.Size = new System.Drawing.Size(185, 21);
            duracaoLabel.TabIndex = 21;
            duracaoLabel.Text = "Duração em Minutos";
            // 
            // horaInicioLabel
            // 
            horaInicioLabel.AutoSize = true;
            horaInicioLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaInicioLabel.Location = new System.Drawing.Point(13, 11);
            horaInicioLabel.Name = "horaInicioLabel";
            horaInicioLabel.Size = new System.Drawing.Size(198, 21);
            horaInicioLabel.TabIndex = 20;
            horaInicioLabel.Text = "Hora de Inicio da Aula";
            // 
            // idclienteLabel
            // 
            idclienteLabel.AutoSize = true;
            idclienteLabel.Location = new System.Drawing.Point(537, 31);
            idclienteLabel.Name = "idclienteLabel";
            idclienteLabel.Size = new System.Drawing.Size(51, 17);
            idclienteLabel.TabIndex = 30;
            idclienteLabel.Text = "Alunos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 221);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 17);
            label2.TabIndex = 34;
            label2.Text = "Treinadores";
            // 
            // txtginasio
            // 
            this.txtginasio.Location = new System.Drawing.Point(217, 70);
            this.txtginasio.Name = "txtginasio";
            this.txtginasio.ReadOnly = true;
            this.txtginasio.Size = new System.Drawing.Size(200, 22);
            this.txtginasio.TabIndex = 28;
            // 
            // txtduracao
            // 
            this.txtduracao.Location = new System.Drawing.Point(217, 42);
            this.txtduracao.Name = "txtduracao";
            this.txtduracao.ReadOnly = true;
            this.txtduracao.Size = new System.Drawing.Size(100, 22);
            this.txtduracao.TabIndex = 27;
            // 
            // txtalunos
            // 
            this.txtalunos.Location = new System.Drawing.Point(217, 156);
            this.txtalunos.Name = "txtalunos";
            this.txtalunos.ReadOnly = true;
            this.txtalunos.Size = new System.Drawing.Size(100, 22);
            this.txtalunos.TabIndex = 26;
            // 
            // dtpdata
            // 
            this.dtpdata.Enabled = false;
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(217, 99);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(100, 22);
            this.dtpdata.TabIndex = 18;
            // 
            // mtxthora
            // 
            this.mtxthora.Location = new System.Drawing.Point(217, 12);
            this.mtxthora.Mask = "00:00";
            this.mtxthora.Name = "mtxthora";
            this.mtxthora.ReadOnly = true;
            this.mtxthora.Size = new System.Drawing.Size(48, 22);
            this.mtxthora.TabIndex = 17;
            this.mtxthora.ValidatingType = typeof(System.DateTime);
            // 
            // cbomodalidade
            // 
            this.cbomodalidade.DataSource = this.modalidadesBS;
            this.cbomodalidade.DisplayMember = "NomeModalidade";
            this.cbomodalidade.Enabled = false;
            this.cbomodalidade.FormattingEnabled = true;
            this.cbomodalidade.Location = new System.Drawing.Point(217, 128);
            this.cbomodalidade.Name = "cbomodalidade";
            this.cbomodalidade.Size = new System.Drawing.Size(200, 24);
            this.cbomodalidade.TabIndex = 19;
            this.cbomodalidade.ValueMember = "idModalidade";
            // 
            // modalidadesBS
            // 
            this.modalidadesBS.DataMember = "Modalidades";
            this.modalidadesBS.DataSource = this.pAPDataSet;
            // 
            // pAPDataSet
            // 
            this.pAPDataSet.DataSetName = "PAPDataSet";
            this.pAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.Aula_AlunosTableAdapter = this.aula_AlunosTA;
            this.tableAdapterManager.Aula_TreinadorTableAdapter = null;
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.AvaliacaoFisicaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaExerciciosTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.ExerciciosTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.inscricoesTableAdapter = null;
            this.tableAdapterManager.ModalidadesTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaProdutosTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // cboalunos
            // 
            this.cboalunos.DataSource = this.viewInscricoes1BS;
            this.cboalunos.DisplayMember = "nome";
            this.cboalunos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboalunos.FormattingEnabled = true;
            this.cboalunos.Location = new System.Drawing.Point(594, 28);
            this.cboalunos.Name = "cboalunos";
            this.cboalunos.Size = new System.Drawing.Size(364, 24);
            this.cboalunos.TabIndex = 31;
            this.cboalunos.ValueMember = "idcliente";
            // 
            // viewInscricoes1BS
            // 
            this.viewInscricoes1BS.DataMember = "viewInscricoes1";
            this.viewInscricoes1BS.DataSource = this.pAPDataSet;
            // 
            // viewInscricoes1TA
            // 
            this.viewInscricoes1TA.ClearBeforeFill = true;
            // 
            // modalidadesTA
            // 
            this.modalidadesTA.ClearBeforeFill = true;
            // 
            // aula_TreinadorBS
            // 
            this.aula_TreinadorBS.DataMember = "Aula_Treinador";
            this.aula_TreinadorBS.DataSource = this.pAPDataSet;
            // 
            // aula_TreinadorTA
            // 
            this.aula_TreinadorTA.ClearBeforeFill = true;
            // 
            // cbotreinador
            // 
            this.cbotreinador.DataSource = this.funcionarioBS;
            this.cbotreinador.DisplayMember = "nome";
            this.cbotreinador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotreinador.FormattingEnabled = true;
            this.cbotreinador.Location = new System.Drawing.Point(105, 218);
            this.cbotreinador.Name = "cbotreinador";
            this.cbotreinador.Size = new System.Drawing.Size(348, 24);
            this.cbotreinador.TabIndex = 35;
            this.cbotreinador.ValueMember = "idfuncionario";
            this.cbotreinador.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // funcionarioBS
            // 
            this.funcionarioBS.DataMember = "funcionario";
            this.funcionarioBS.DataSource = this.pAPDataSet;
            // 
            // funcionarioTA
            // 
            this.funcionarioTA.ClearBeforeFill = true;
            // 
            // treinadordgv
            // 
            this.treinadordgv.AllowUserToAddRows = false;
            this.treinadordgv.AllowUserToDeleteRows = false;
            this.treinadordgv.AutoGenerateColumns = false;
            this.treinadordgv.BackgroundColor = System.Drawing.Color.White;
            this.treinadordgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.treinadordgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.treinadordgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treinadordgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.treinadordgv.DataSource = this.aula_TreinadorBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.treinadordgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.treinadordgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.treinadordgv.Location = new System.Drawing.Point(17, 258);
            this.treinadordgv.Name = "treinadordgv";
            this.treinadordgv.ReadOnly = true;
            this.treinadordgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.treinadordgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.treinadordgv.RowHeadersVisible = false;
            this.treinadordgv.RowTemplate.Height = 24;
            this.treinadordgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.treinadordgv.Size = new System.Drawing.Size(436, 136);
            this.treinadordgv.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idaula";
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "idaula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idfuncionario";
            this.dataGridViewTextBoxColumn2.FillWeight = 20F;
            this.dataGridViewTextBoxColumn2.HeaderText = "idfuncionario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomeFuncionario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Treinador";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // alunosdgv
            // 
            this.alunosdgv.AllowUserToAddRows = false;
            this.alunosdgv.AllowUserToDeleteRows = false;
            this.alunosdgv.AutoGenerateColumns = false;
            this.alunosdgv.BackgroundColor = System.Drawing.Color.White;
            this.alunosdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alunosdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.alunosdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alunosdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.alunosdgv.DataSource = this.aula_AlunosBS;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alunosdgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.alunosdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.alunosdgv.Location = new System.Drawing.Point(512, 69);
            this.alunosdgv.Name = "alunosdgv";
            this.alunosdgv.ReadOnly = true;
            this.alunosdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alunosdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.alunosdgv.RowHeadersVisible = false;
            this.alunosdgv.RowTemplate.Height = 24;
            this.alunosdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alunosdgv.Size = new System.Drawing.Size(471, 325);
            this.alunosdgv.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idaula";
            this.dataGridViewTextBoxColumn4.HeaderText = "idaula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idcliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "idcliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nomeCliente";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome do Aluno";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(306, 400);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(147, 31);
            this.btguardar.TabIndex = 36;
            this.btguardar.Text = "Inserir Treinador";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btguardar_A
            // 
            this.btguardar_A.Location = new System.Drawing.Point(878, 400);
            this.btguardar_A.Name = "btguardar_A";
            this.btguardar_A.Size = new System.Drawing.Size(105, 31);
            this.btguardar_A.TabIndex = 37;
            this.btguardar_A.Text = "Inserir Aluno";
            this.btguardar_A.UseVisualStyleBackColor = true;
            this.btguardar_A.Click += new System.EventHandler(this.button2_Click);
            // 
            // btremoverT
            // 
            this.btremoverT.Location = new System.Drawing.Point(158, 400);
            this.btremoverT.Name = "btremoverT";
            this.btremoverT.Size = new System.Drawing.Size(142, 31);
            this.btremoverT.TabIndex = 38;
            this.btremoverT.Text = "Remover Treinador";
            this.btremoverT.UseVisualStyleBackColor = true;
            this.btremoverT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 31);
            this.button2.TabIndex = 39;
            this.button2.Text = "Remover Aluno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FrmGerirAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 443);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btremoverT);
            this.Controls.Add(this.btguardar_A);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.alunosdgv);
            this.Controls.Add(this.treinadordgv);
            this.Controls.Add(this.cbotreinador);
            this.Controls.Add(label2);
            this.Controls.Add(this.cboalunos);
            this.Controls.Add(idclienteLabel);
            this.Controls.Add(this.txtginasio);
            this.Controls.Add(this.txtduracao);
            this.Controls.Add(this.txtalunos);
            this.Controls.Add(label1);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.mtxthora);
            this.Controls.Add(this.cbomodalidade);
            this.Controls.Add(idmodalidadeLabel);
            this.Controls.Add(diaDaSemanaLabel);
            this.Controls.Add(localGinasioLabel);
            this.Controls.Add(duracaoLabel);
            this.Controls.Add(horaInicioLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGerirAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula";
            this.Load += new System.EventHandler(this.FrmGerirAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_AlunosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInscricoes1BS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_TreinadorBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinadordgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtginasio;
        private System.Windows.Forms.TextBox txtduracao;
        private System.Windows.Forms.TextBox txtalunos;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.MaskedTextBox mtxthora;
        private System.Windows.Forms.ComboBox cbomodalidade;
        private PAPDataSet pAPDataSet;
        private System.Windows.Forms.BindingSource aula_AlunosBS;
        private PAPDataSetTableAdapters.Aula_AlunosTableAdapter aula_AlunosTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboalunos;
        private System.Windows.Forms.BindingSource viewInscricoes1BS;
        private PAPDataSetTableAdapters.viewInscricoes1TableAdapter viewInscricoes1TA;
        private System.Windows.Forms.BindingSource modalidadesBS;
        private PAPDataSetTableAdapters.ModalidadesTableAdapter modalidadesTA;
        private System.Windows.Forms.BindingSource aula_TreinadorBS;
        private PAPDataSetTableAdapters.Aula_TreinadorTableAdapter aula_TreinadorTA;
        private System.Windows.Forms.ComboBox cbotreinador;
        private System.Windows.Forms.BindingSource funcionarioBS;
        private PAPDataSetTableAdapters.funcionarioTableAdapter funcionarioTA;
        private System.Windows.Forms.DataGridView treinadordgv;
        private System.Windows.Forms.DataGridView alunosdgv;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btguardar_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btremoverT;
        private System.Windows.Forms.Button button2;
    }
}