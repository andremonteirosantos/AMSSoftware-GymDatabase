namespace PAP
{
    partial class FrmAulas
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
            System.Windows.Forms.Label horaInicioLabel;
            System.Windows.Forms.Label duracaoLabel;
            System.Windows.Forms.Label localGinasioLabel;
            System.Windows.Forms.Label diaDaSemanaLabel;
            System.Windows.Forms.Label idmodalidadeLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAulas));
            this.pAPDataSet = new PAP.PAPDataSet();
            this.aulaBS = new System.Windows.Forms.BindingSource(this.components);
            this.aulaTA = new PAP.PAPDataSetTableAdapters.AulaTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            this.modalidadesTA = new PAP.PAPDataSetTableAdapters.ModalidadesTableAdapter();
            this.cbomodalidade = new System.Windows.Forms.ComboBox();
            this.modalidadesBS = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.txtalunos = new System.Windows.Forms.TextBox();
            this.txtduracao = new System.Windows.Forms.TextBox();
            this.txtginasio = new System.Windows.Forms.TextBox();
            horaInicioLabel = new System.Windows.Forms.Label();
            duracaoLabel = new System.Windows.Forms.Label();
            localGinasioLabel = new System.Windows.Forms.Label();
            diaDaSemanaLabel = new System.Windows.Forms.Label();
            idmodalidadeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBS)).BeginInit();
            this.SuspendLayout();
            // 
            // horaInicioLabel
            // 
            horaInicioLabel.AutoSize = true;
            horaInicioLabel.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaInicioLabel.Location = new System.Drawing.Point(25, 13);
            horaInicioLabel.Name = "horaInicioLabel";
            horaInicioLabel.Size = new System.Drawing.Size(158, 21);
            horaInicioLabel.TabIndex = 7;
            horaInicioLabel.Text = "Hora de Inicio da Aula";
            // 
            // duracaoLabel
            // 
            duracaoLabel.AutoSize = true;
            duracaoLabel.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duracaoLabel.Location = new System.Drawing.Point(32, 40);
            duracaoLabel.Name = "duracaoLabel";
            duracaoLabel.Size = new System.Drawing.Size(154, 21);
            duracaoLabel.TabIndex = 8;
            duracaoLabel.Text = "Duração em Minutos";
            // 
            // localGinasioLabel
            // 
            localGinasioLabel.AutoSize = true;
            localGinasioLabel.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localGinasioLabel.Location = new System.Drawing.Point(82, 69);
            localGinasioLabel.Name = "localGinasioLabel";
            localGinasioLabel.Size = new System.Drawing.Size(101, 21);
            localGinasioLabel.TabIndex = 9;
            localGinasioLabel.Text = "Local da Aula";
            // 
            // diaDaSemanaLabel
            // 
            diaDaSemanaLabel.AutoSize = true;
            diaDaSemanaLabel.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaDaSemanaLabel.Location = new System.Drawing.Point(99, 97);
            diaDaSemanaLabel.Name = "diaDaSemanaLabel";
            diaDaSemanaLabel.Size = new System.Drawing.Size(87, 21);
            diaDaSemanaLabel.TabIndex = 10;
            diaDaSemanaLabel.Text = "Dia da Aula";
            // 
            // idmodalidadeLabel
            // 
            idmodalidadeLabel.AutoSize = true;
            idmodalidadeLabel.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idmodalidadeLabel.Location = new System.Drawing.Point(94, 125);
            idmodalidadeLabel.Name = "idmodalidadeLabel";
            idmodalidadeLabel.Size = new System.Drawing.Size(92, 21);
            idmodalidadeLabel.TabIndex = 11;
            idmodalidadeLabel.Text = "Modalidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(11, 154);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 21);
            label1.TabIndex = 12;
            label1.Text = "Número Max de Alunos";
            // 
            // pAPDataSet
            // 
            this.pAPDataSet.DataSetName = "PAPDataSet";
            this.pAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulaBS
            // 
            this.aulaBS.DataMember = "Aula";
            this.aulaBS.DataSource = this.pAPDataSet;
            // 
            // aulaTA
            // 
            this.aulaTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Aula_AlunosTableAdapter = null;
            this.tableAdapterManager.Aula_TreinadorTableAdapter = null;
            this.tableAdapterManager.AulaTableAdapter = this.aulaTA;
            this.tableAdapterManager.AvaliacaoFisicaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.ExerciciosTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.inscricoesTableAdapter = null;
            this.tableAdapterManager.ModalidadesTableAdapter = this.modalidadesTA;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaProdutosTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // modalidadesTA
            // 
            this.modalidadesTA.ClearBeforeFill = true;
            // 
            // cbomodalidade
            // 
            this.cbomodalidade.DataSource = this.modalidadesBS;
            this.cbomodalidade.DisplayMember = "NomeModalidade";
            this.cbomodalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomodalidade.FormattingEnabled = true;
            this.cbomodalidade.Location = new System.Drawing.Point(189, 124);
            this.cbomodalidade.Name = "cbomodalidade";
            this.cbomodalidade.Size = new System.Drawing.Size(116, 24);
            this.cbomodalidade.TabIndex = 4;
            this.cbomodalidade.ValueMember = "idModalidade";
            // 
            // modalidadesBS
            // 
            this.modalidadesBS.DataMember = "Modalidades";
            this.modalidadesBS.DataSource = this.pAPDataSet;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(189, 12);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(48, 22);
            this.maskedTextBox2.TabIndex = 0;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpdata
            // 
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(189, 96);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(100, 22);
            this.dtpdata.TabIndex = 3;
            // 
            // txtalunos
            // 
            this.txtalunos.Location = new System.Drawing.Point(189, 154);
            this.txtalunos.Name = "txtalunos";
            this.txtalunos.Size = new System.Drawing.Size(72, 22);
            this.txtalunos.TabIndex = 14;
            this.txtalunos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtalunos_KeyPress);
            // 
            // txtduracao
            // 
            this.txtduracao.Location = new System.Drawing.Point(189, 40);
            this.txtduracao.Name = "txtduracao";
            this.txtduracao.Size = new System.Drawing.Size(59, 22);
            this.txtduracao.TabIndex = 15;
            this.txtduracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtduracao_KeyPress);
            // 
            // txtginasio
            // 
            this.txtginasio.Location = new System.Drawing.Point(189, 68);
            this.txtginasio.Name = "txtginasio";
            this.txtginasio.Size = new System.Drawing.Size(100, 22);
            this.txtginasio.TabIndex = 16;
            // 
            // FrmAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 199);
            this.Controls.Add(this.txtginasio);
            this.Controls.Add(this.txtduracao);
            this.Controls.Add(this.txtalunos);
            this.Controls.Add(label1);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.cbomodalidade);
            this.Controls.Add(idmodalidadeLabel);
            this.Controls.Add(diaDaSemanaLabel);
            this.Controls.Add(localGinasioLabel);
            this.Controls.Add(duracaoLabel);
            this.Controls.Add(horaInicioLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aulas";
            this.Load += new System.EventHandler(this.FrmAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PAPDataSet pAPDataSet;
        private System.Windows.Forms.BindingSource aulaBS;
        private PAPDataSetTableAdapters.AulaTableAdapter aulaTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PAPDataSetTableAdapters.ModalidadesTableAdapter modalidadesTA;
        private System.Windows.Forms.ComboBox cbomodalidade;
        private System.Windows.Forms.BindingSource modalidadesBS;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.TextBox txtalunos;
        private System.Windows.Forms.TextBox txtduracao;
        private System.Windows.Forms.TextBox txtginasio;
    }
}