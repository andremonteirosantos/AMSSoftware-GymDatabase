namespace PAP
{
    partial class FrmInscricoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscricoes));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cbomodalidades = new System.Windows.Forms.ComboBox();
            this.pAPDataSet = new PAP.PAPDataSet();
            this.viewInscricoesBS = new System.Windows.Forms.BindingSource(this.components);
            this.viewInscricoesTA = new PAP.PAPDataSetTableAdapters.viewInscricoesTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            this.viewInscricoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadesBS = new System.Windows.Forms.BindingSource(this.components);
            this.modalidadesTA = new PAP.PAPDataSetTableAdapters.ModalidadesTableAdapter();
            this.clienteBS = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTA = new PAP.PAPDataSetTableAdapters.clienteTableAdapter();
            this.inscricoesBS = new System.Windows.Forms.BindingSource(this.components);
            this.inscricoesTA = new PAP.PAPDataSetTableAdapters.inscricoesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInscricoesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInscricoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBS)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data de Inscrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome da Modalidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome do Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(260, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 22);
            this.textBox1.TabIndex = 21;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(260, 98);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(172, 22);
            this.dtpData.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(800, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Inscrever";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbomodalidades
            // 
            this.cbomodalidades.DataSource = this.modalidadesBS;
            this.cbomodalidades.DisplayMember = "NomeModalidade";
            this.cbomodalidades.FormattingEnabled = true;
            this.cbomodalidades.Location = new System.Drawing.Point(260, 56);
            this.cbomodalidades.Margin = new System.Windows.Forms.Padding(4);
            this.cbomodalidades.Name = "cbomodalidades";
            this.cbomodalidades.Size = new System.Drawing.Size(315, 24);
            this.cbomodalidades.TabIndex = 18;
            this.cbomodalidades.ValueMember = "idModalidade";
            // 
            // pAPDataSet
            // 
            this.pAPDataSet.DataSetName = "PAPDataSet";
            this.pAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewInscricoesBS
            // 
            this.viewInscricoesBS.DataMember = "viewInscricoes";
            this.viewInscricoesBS.DataSource = this.pAPDataSet;
            // 
            // viewInscricoesTA
            // 
            this.viewInscricoesTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.AvaliacaoFisicaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTA;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.inscricoesTableAdapter = this.inscricoesTA;
            this.tableAdapterManager.ModalidadesTableAdapter = this.modalidadesTA;
            //this.tableAdapterManager.ProdutosTableAdapter = null;
            //this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // viewInscricoesDataGridView
            // 
            this.viewInscricoesDataGridView.AllowUserToAddRows = false;
            this.viewInscricoesDataGridView.AllowUserToDeleteRows = false;
            this.viewInscricoesDataGridView.AutoGenerateColumns = false;
            this.viewInscricoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewInscricoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2});
            this.viewInscricoesDataGridView.DataSource = this.viewInscricoesBS;
            this.viewInscricoesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewInscricoesDataGridView.Location = new System.Drawing.Point(0, 136);
            this.viewInscricoesDataGridView.Name = "viewInscricoesDataGridView";
            this.viewInscricoesDataGridView.ReadOnly = true;
            this.viewInscricoesDataGridView.RowTemplate.Height = 24;
            this.viewInscricoesDataGridView.Size = new System.Drawing.Size(941, 220);
            this.viewInscricoesDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InscricoesData";
            this.dataGridViewTextBoxColumn2.FillWeight = 70F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Data de inscrições";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NomeModalidade";
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome da Modalidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idcliente";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modalidadesBS
            // 
            this.modalidadesBS.DataMember = "Modalidades";
            this.modalidadesBS.DataSource = this.pAPDataSet;
            // 
            // modalidadesTA
            // 
            this.modalidadesTA.ClearBeforeFill = true;
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
            // inscricoesBS
            // 
            this.inscricoesBS.DataMember = "inscricoes";
            this.inscricoesBS.DataSource = this.pAPDataSet;
            // 
            // inscricoesTA
            // 
            this.inscricoesTA.ClearBeforeFill = true;
            // 
            // FrmInscricoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 356);
            this.Controls.Add(this.viewInscricoesDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbomodalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInscricoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrições";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInscricoes_FormClosing);
            this.Load += new System.EventHandler(this.FrmInscricoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInscricoesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInscricoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricoesBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbomodalidades;
        private PAPDataSet pAPDataSet;
        private System.Windows.Forms.BindingSource viewInscricoesBS;
        private PAPDataSetTableAdapters.viewInscricoesTableAdapter viewInscricoesTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView viewInscricoesDataGridView;
        private PAPDataSetTableAdapters.ModalidadesTableAdapter modalidadesTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource modalidadesBS;
        private PAPDataSetTableAdapters.clienteTableAdapter clienteTA;
        private System.Windows.Forms.BindingSource clienteBS;
        private PAPDataSetTableAdapters.inscricoesTableAdapter inscricoesTA;
        private System.Windows.Forms.BindingSource inscricoesBS;
    }
}