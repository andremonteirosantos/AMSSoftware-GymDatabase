namespace PAP
{
    partial class FrmPlanosdeTreino
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
            this.viewplanosTreinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAPDataSet = new PAP.PAPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaExerciciosBS = new System.Windows.Forms.BindingSource(this.components);
            this.exerciciosBS = new System.Windows.Forms.BindingSource(this.components);
            this.btt5 = new System.Windows.Forms.Button();
            this.btt4 = new System.Windows.Forms.Button();
            this.btt3 = new System.Windows.Forms.Button();
            this.btt2 = new System.Windows.Forms.Button();
            this.btt1 = new System.Windows.Forms.Button();
            this.btt10 = new System.Windows.Forms.Button();
            this.btt9 = new System.Windows.Forms.Button();
            this.btt8 = new System.Windows.Forms.Button();
            this.btt7 = new System.Windows.Forms.Button();
            this.btt6 = new System.Windows.Forms.Button();
            this.btt11 = new System.Windows.Forms.Button();
            this.btt12 = new System.Windows.Forms.Button();
            this.btt13 = new System.Windows.Forms.Button();
            this.btt14 = new System.Windows.Forms.Button();
            this.btt15 = new System.Windows.Forms.Button();
            this.exerciciosTA = new PAP.PAPDataSetTableAdapters.ExerciciosTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            this.categoriaExerciciosTA = new PAP.PAPDataSetTableAdapters.CategoriaExerciciosTableAdapter();
            this.viewplanosTreinoTableAdapter = new PAP.PAPDataSetTableAdapters.viewplanosTreinoTableAdapter();
            this.planodeTreinoTA = new PAP.PAPDataSetTableAdapters.PlanodeTreinoTableAdapter();
            this.bttRemover = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvplano = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewplanosTreinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaExerciciosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciciosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplano)).BeginInit();
            this.SuspendLayout();
            // 
            // viewplanosTreinoBindingSource
            // 
            this.viewplanosTreinoBindingSource.DataMember = "viewplanosTreino";
            this.viewplanosTreinoBindingSource.DataSource = this.pAPDataSet;
            // 
            // pAPDataSet
            // 
            this.pAPDataSet.DataSetName = "PAPDataSet";
            this.pAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Exercício";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataSource = this.categoriaExerciciosBS;
            this.cbCategoria.DisplayMember = "NomeCategoriaExer";
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(144, 25);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(215, 24);
            this.cbCategoria.TabIndex = 2;
            this.cbCategoria.ValueMember = "idCategoriaExer";
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            this.cbCategoria.SelectedValueChanged += new System.EventHandler(this.cbCategoria_SelectedValueChanged_1);
            // 
            // categoriaExerciciosBS
            // 
            this.categoriaExerciciosBS.DataMember = "CategoriaExercicios";
            this.categoriaExerciciosBS.DataSource = this.pAPDataSet;
            // 
            // exerciciosBS
            // 
            this.exerciciosBS.DataMember = "Exercicios";
            this.exerciciosBS.DataSource = this.pAPDataSet;
            // 
            // btt5
            // 
            this.btt5.Location = new System.Drawing.Point(613, 85);
            this.btt5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt5.Name = "btt5";
            this.btt5.Size = new System.Drawing.Size(143, 73);
            this.btt5.TabIndex = 11;
            this.btt5.Text = "button5";
            this.btt5.UseVisualStyleBackColor = true;
            // 
            // btt4
            // 
            this.btt4.Location = new System.Drawing.Point(465, 85);
            this.btt4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt4.Name = "btt4";
            this.btt4.Size = new System.Drawing.Size(143, 73);
            this.btt4.TabIndex = 10;
            this.btt4.Text = "button4";
            this.btt4.UseVisualStyleBackColor = true;
            // 
            // btt3
            // 
            this.btt3.Location = new System.Drawing.Point(315, 85);
            this.btt3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt3.Name = "btt3";
            this.btt3.Size = new System.Drawing.Size(143, 73);
            this.btt3.TabIndex = 9;
            this.btt3.Text = "button3";
            this.btt3.UseVisualStyleBackColor = true;
            // 
            // btt2
            // 
            this.btt2.Location = new System.Drawing.Point(166, 85);
            this.btt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt2.Name = "btt2";
            this.btt2.Size = new System.Drawing.Size(143, 73);
            this.btt2.TabIndex = 8;
            this.btt2.Text = "button2";
            this.btt2.UseVisualStyleBackColor = true;
            // 
            // btt1
            // 
            this.btt1.Location = new System.Drawing.Point(17, 85);
            this.btt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(143, 73);
            this.btt1.TabIndex = 7;
            this.btt1.Text = "button1";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // btt10
            // 
            this.btt10.Location = new System.Drawing.Point(613, 162);
            this.btt10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt10.Name = "btt10";
            this.btt10.Size = new System.Drawing.Size(143, 73);
            this.btt10.TabIndex = 16;
            this.btt10.Text = "button5";
            this.btt10.UseVisualStyleBackColor = true;
            // 
            // btt9
            // 
            this.btt9.Location = new System.Drawing.Point(465, 162);
            this.btt9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt9.Name = "btt9";
            this.btt9.Size = new System.Drawing.Size(143, 73);
            this.btt9.TabIndex = 15;
            this.btt9.Text = "button4";
            this.btt9.UseVisualStyleBackColor = true;
            // 
            // btt8
            // 
            this.btt8.Location = new System.Drawing.Point(315, 162);
            this.btt8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt8.Name = "btt8";
            this.btt8.Size = new System.Drawing.Size(143, 73);
            this.btt8.TabIndex = 14;
            this.btt8.Text = "button3";
            this.btt8.UseVisualStyleBackColor = true;
            // 
            // btt7
            // 
            this.btt7.Location = new System.Drawing.Point(166, 162);
            this.btt7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt7.Name = "btt7";
            this.btt7.Size = new System.Drawing.Size(143, 73);
            this.btt7.TabIndex = 13;
            this.btt7.Text = "button2";
            this.btt7.UseVisualStyleBackColor = true;
            // 
            // btt6
            // 
            this.btt6.Location = new System.Drawing.Point(17, 162);
            this.btt6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt6.Name = "btt6";
            this.btt6.Size = new System.Drawing.Size(143, 73);
            this.btt6.TabIndex = 12;
            this.btt6.Text = "btt6";
            this.btt6.UseVisualStyleBackColor = true;
            // 
            // btt11
            // 
            this.btt11.Location = new System.Drawing.Point(613, 239);
            this.btt11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt11.Name = "btt11";
            this.btt11.Size = new System.Drawing.Size(143, 73);
            this.btt11.TabIndex = 21;
            this.btt11.Text = "button5";
            this.btt11.UseVisualStyleBackColor = true;
            // 
            // btt12
            // 
            this.btt12.Location = new System.Drawing.Point(465, 239);
            this.btt12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt12.Name = "btt12";
            this.btt12.Size = new System.Drawing.Size(143, 73);
            this.btt12.TabIndex = 20;
            this.btt12.Text = "button4";
            this.btt12.UseVisualStyleBackColor = true;
            // 
            // btt13
            // 
            this.btt13.Location = new System.Drawing.Point(315, 239);
            this.btt13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt13.Name = "btt13";
            this.btt13.Size = new System.Drawing.Size(143, 73);
            this.btt13.TabIndex = 19;
            this.btt13.Text = "button3";
            this.btt13.UseVisualStyleBackColor = true;
            // 
            // btt14
            // 
            this.btt14.Location = new System.Drawing.Point(166, 239);
            this.btt14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt14.Name = "btt14";
            this.btt14.Size = new System.Drawing.Size(143, 73);
            this.btt14.TabIndex = 18;
            this.btt14.Text = "button2";
            this.btt14.UseVisualStyleBackColor = true;
            // 
            // btt15
            // 
            this.btt15.Location = new System.Drawing.Point(17, 239);
            this.btt15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt15.Name = "btt15";
            this.btt15.Size = new System.Drawing.Size(143, 73);
            this.btt15.TabIndex = 17;
            this.btt15.Text = "button1";
            this.btt15.UseVisualStyleBackColor = true;
            // 
            // exerciciosTA
            // 
            this.exerciciosTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Aula_AlunosTableAdapter = null;
            this.tableAdapterManager.Aula_TreinadorTableAdapter = null;
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.AvaliacaoFisicaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaExerciciosTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.ExerciciosTableAdapter = this.exerciciosTA;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.inscricoesTableAdapter = null;
            this.tableAdapterManager.ModalidadesTableAdapter = null;
            this.tableAdapterManager.PlanodeTreinoTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaProdutosTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // categoriaExerciciosTA
            // 
            this.categoriaExerciciosTA.ClearBeforeFill = true;
            // 
            // viewplanosTreinoTableAdapter
            // 
            this.viewplanosTreinoTableAdapter.ClearBeforeFill = true;
            // 
            // planodeTreinoTA
            // 
            this.planodeTreinoTA.ClearBeforeFill = true;
            // 
            // bttRemover
            // 
            this.bttRemover.Location = new System.Drawing.Point(777, 596);
            this.bttRemover.Name = "bttRemover";
            this.bttRemover.Size = new System.Drawing.Size(148, 46);
            this.bttRemover.TabIndex = 22;
            this.bttRemover.Text = "remover exercicio";
            this.bttRemover.UseVisualStyleBackColor = true;
            this.bttRemover.Click += new System.EventHandler(this.bttRemover_Click_1);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn6.HeaderText = "categoria";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nomeBotao";
            this.dataGridViewTextBoxColumn5.HeaderText = "nomeBotao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descricao_Exercicio";
            this.dataGridViewTextBoxColumn4.HeaderText = "descricao_Exercicio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Exercicio";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome_Exercicio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idexercicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "idexercicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv.DataSource = this.exerciciosBS;
            this.dgv.Location = new System.Drawing.Point(961, 441);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(535, 220);
            this.dgv.TabIndex = 21;
            // 
            // dgvplano
            // 
            this.dgvplano.AllowUserToAddRows = false;
            this.dgvplano.AllowUserToDeleteRows = false;
            this.dgvplano.AutoGenerateColumns = false;
            this.dgvplano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplano.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvplano.DataSource = this.viewplanosTreinoBindingSource;
            this.dgvplano.Location = new System.Drawing.Point(70, 406);
            this.dgvplano.Name = "dgvplano";
            this.dgvplano.ReadOnly = true;
            this.dgvplano.RowTemplate.Height = 24;
            this.dgvplano.Size = new System.Drawing.Size(615, 220);
            this.dgvplano.TabIndex = 22;
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
            this.dataGridViewTextBoxColumn8.DataPropertyName = "idplano";
            this.dataGridViewTextBoxColumn8.HeaderText = "idplano";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nome_Exercicio";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nome_Exercicio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "descricao_exercicio";
            this.dataGridViewTextBoxColumn10.HeaderText = "descricao_exercicio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // FrmPlanosdeTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 681);
            this.Controls.Add(this.dgvplano);
            this.Controls.Add(this.bttRemover);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btt11);
            this.Controls.Add(this.btt12);
            this.Controls.Add(this.btt13);
            this.Controls.Add(this.btt14);
            this.Controls.Add(this.btt15);
            this.Controls.Add(this.btt10);
            this.Controls.Add(this.btt9);
            this.Controls.Add(this.btt8);
            this.Controls.Add(this.btt7);
            this.Controls.Add(this.btt6);
            this.Controls.Add(this.btt5);
            this.Controls.Add(this.btt4);
            this.Controls.Add(this.btt3);
            this.Controls.Add(this.btt2);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategoria);
            this.Name = "FrmPlanosdeTreino";
            this.Text = "FrmPlanosdeTreino";
            this.Load += new System.EventHandler(this.FrmPlanosdeTreino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewplanosTreinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaExerciciosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciciosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btt5;
        private System.Windows.Forms.Button btt4;
        private System.Windows.Forms.Button btt3;
        private System.Windows.Forms.Button btt2;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Button btt10;
        private System.Windows.Forms.Button btt9;
        private System.Windows.Forms.Button btt8;
        private System.Windows.Forms.Button btt7;
        private System.Windows.Forms.Button btt6;
        private System.Windows.Forms.Button btt11;
        private System.Windows.Forms.Button btt12;
        private System.Windows.Forms.Button btt13;
        private System.Windows.Forms.Button btt14;
        private System.Windows.Forms.Button btt15;
        private PAPDataSet pAPDataSet;
        private System.Windows.Forms.BindingSource exerciciosBS;
        private PAPDataSetTableAdapters.ExerciciosTableAdapter exerciciosTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource categoriaExerciciosBS;
        private PAPDataSetTableAdapters.CategoriaExerciciosTableAdapter categoriaExerciciosTA;
        private System.Windows.Forms.BindingSource viewplanosTreinoBindingSource;
        private PAPDataSetTableAdapters.viewplanosTreinoTableAdapter viewplanosTreinoTableAdapter;
        private PAPDataSetTableAdapters.PlanodeTreinoTableAdapter planodeTreinoTA;
        private System.Windows.Forms.Button bttRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridView dgvplano;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}