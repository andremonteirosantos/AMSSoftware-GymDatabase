namespace PAP
{
    partial class estatística
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pAPDataSet = new PAP.PAPDataSet();
            this.clienteBS = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTA = new PAP.PAPDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            this.avaliacaoFisicaBS = new System.Windows.Forms.BindingSource(this.components);
            this.avaliacaoFisicaTA = new PAP.PAPDataSetTableAdapters.AvaliacaoFisicaTableAdapter();
            this.avaliacaoFisicaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Peso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoFisicaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoFisicaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peso)).BeginInit();
            this.SuspendLayout();
            // 
            // pAPDataSet
            // 
            this.pAPDataSet.DataSetName = "PAPDataSet";
            this.pAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.Aula_AlunosTableAdapter = null;
            this.tableAdapterManager.Aula_TreinadorTableAdapter = null;
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.AvaliacaoFisicaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaExerciciosTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTA;
            this.tableAdapterManager.ExerciciosTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.inscricoesTableAdapter = null;
            this.tableAdapterManager.ModalidadesTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaProdutosTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
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
            // avaliacaoFisicaDataGridView
            // 
            this.avaliacaoFisicaDataGridView.AutoGenerateColumns = false;
            this.avaliacaoFisicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avaliacaoFisicaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.avaliacaoFisicaDataGridView.DataSource = this.avaliacaoFisicaBS;
            this.avaliacaoFisicaDataGridView.Location = new System.Drawing.Point(545, 12);
            this.avaliacaoFisicaDataGridView.Name = "avaliacaoFisicaDataGridView";
            this.avaliacaoFisicaDataGridView.RowTemplate.Height = 24;
            this.avaliacaoFisicaDataGridView.Size = new System.Drawing.Size(27, 231);
            this.avaliacaoFisicaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "idcliente";
            this.dataGridViewTextBoxColumn17.HeaderText = "idcliente";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "AvaliacaoData";
            this.dataGridViewTextBoxColumn18.HeaderText = "AvaliacaoData";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Peso";
            this.dataGridViewTextBoxColumn19.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "IMC";
            this.dataGridViewTextBoxColumn20.HeaderText = "IMC";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "IMG";
            this.dataGridViewTextBoxColumn21.HeaderText = "IMG";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "IMM";
            this.dataGridViewTextBoxColumn22.HeaderText = "IMM";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Idade";
            this.dataGridViewTextBoxColumn23.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // IMG
            // 
            chartArea5.Name = "ChartArea1";
            this.IMG.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.IMG.Legends.Add(legend5);
            this.IMG.Location = new System.Drawing.Point(12, 262);
            this.IMG.Name = "IMG";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Avaliação";
            series5.YValuesPerPoint = 4;
            this.IMG.Series.Add(series5);
            this.IMG.Size = new System.Drawing.Size(527, 231);
            this.IMG.TabIndex = 5;
            this.IMG.Text = "chart3";
            // 
            // Peso
            // 
            chartArea6.Area3DStyle.Enable3D = true;
            chartArea6.Area3DStyle.Inclination = 10;
            chartArea6.Name = "ChartArea1";
            this.Peso.ChartAreas.Add(chartArea6);
            this.Peso.DataSource = this.avaliacaoFisicaBS;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.Peso.Legends.Add(legend6);
            this.Peso.Location = new System.Drawing.Point(12, 12);
            this.Peso.Name = "Peso";
            series6.ChartArea = "ChartArea1";
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.Name = "Avaliação";
            series6.XValueMember = "Peso";
            series6.YValueMembers = "AvaliacaoData";
            series6.YValuesPerPoint = 4;
            this.Peso.Series.Add(series6);
            this.Peso.Size = new System.Drawing.Size(527, 231);
            this.Peso.TabIndex = 7;
            this.Peso.Text = "chart3";
            title3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Peso";
            title3.Text = "Peso";
            this.Peso.Titles.Add(title3);
            this.Peso.Click += new System.EventHandler(this.Peso_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // estatística
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 505);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.IMG);
            this.Controls.Add(this.avaliacaoFisicaDataGridView);
            this.Name = "estatística";
            this.Text = "estatística2";
            this.Load += new System.EventHandler(this.estatística2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoFisicaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacaoFisicaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PAPDataSet pAPDataSet;
        private System.Windows.Forms.BindingSource clienteBS;
        private PAPDataSetTableAdapters.clienteTableAdapter clienteTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource avaliacaoFisicaBS;
        private PAPDataSetTableAdapters.AvaliacaoFisicaTableAdapter avaliacaoFisicaTA;
        private System.Windows.Forms.DataGridView avaliacaoFisicaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataVisualization.Charting.Chart IMG;
        private System.Windows.Forms.DataVisualization.Charting.Chart Peso;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}