namespace PAP
{
    partial class FrmProdutos
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
            System.Windows.Forms.Label nome_ProdutoLabel;
            System.Windows.Forms.Label marca_ProdutoLabel;
            System.Windows.Forms.Label descricao_produtoLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label nomeBotaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.pAPDataSet = new PAP.PAPDataSet();
            this.produtosBS = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTA = new PAP.PAPDataSetTableAdapters.ProdutosTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            this.categoriaTA = new PAP.PAPDataSetTableAdapters.CategoriaTableAdapter();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBS = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtnomeBotao = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            nome_ProdutoLabel = new System.Windows.Forms.Label();
            marca_ProdutoLabel = new System.Windows.Forms.Label();
            descricao_produtoLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            nomeBotaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBS)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_ProdutoLabel
            // 
            nome_ProdutoLabel.AutoSize = true;
            nome_ProdutoLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_ProdutoLabel.Location = new System.Drawing.Point(44, 14);
            nome_ProdutoLabel.Name = "nome_ProdutoLabel";
            nome_ProdutoLabel.Size = new System.Drawing.Size(65, 22);
            nome_ProdutoLabel.TabIndex = 1;
            nome_ProdutoLabel.Text = "Nome\r\n";
            // 
            // marca_ProdutoLabel
            // 
            marca_ProdutoLabel.AutoSize = true;
            marca_ProdutoLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marca_ProdutoLabel.Location = new System.Drawing.Point(42, 55);
            marca_ProdutoLabel.Name = "marca_ProdutoLabel";
            marca_ProdutoLabel.Size = new System.Drawing.Size(71, 22);
            marca_ProdutoLabel.TabIndex = 2;
            marca_ProdutoLabel.Text = "Marca";
            // 
            // descricao_produtoLabel
            // 
            descricao_produtoLabel.AutoSize = true;
            descricao_produtoLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricao_produtoLabel.Location = new System.Drawing.Point(18, 99);
            descricao_produtoLabel.Name = "descricao_produtoLabel";
            descricao_produtoLabel.Size = new System.Drawing.Size(101, 22);
            descricao_produtoLabel.TabIndex = 4;
            descricao_produtoLabel.Text = "Descrição";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.Location = new System.Drawing.Point(469, 14);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(63, 22);
            precoLabel.TabIndex = 6;
            precoLabel.Text = "Preço";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(428, 56);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(104, 22);
            categoriaLabel.TabIndex = 8;
            categoriaLabel.Text = "Categoria";
            // 
            // nomeBotaoLabel
            // 
            nomeBotaoLabel.AutoSize = true;
            nomeBotaoLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeBotaoLabel.Location = new System.Drawing.Point(377, 103);
            nomeBotaoLabel.Name = "nomeBotaoLabel";
            nomeBotaoLabel.Size = new System.Drawing.Size(155, 22);
            nomeBotaoLabel.TabIndex = 10;
            nomeBotaoLabel.Text = "Nome do Botão";
            // 
            // pAPDataSet
            // 
            this.pAPDataSet.DataSetName = "PAPDataSet";
            this.pAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBS
            // 
            this.produtosBS.DataMember = "Produtos";
            this.produtosBS.DataSource = this.pAPDataSet;
            // 
            // produtosTA
            // 
            this.produtosTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Aula_AlunosTableAdapter = null;
            this.tableAdapterManager.Aula_TreinadorTableAdapter = null;
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.AvaliacaoFisicaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTA;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.inscricoesTableAdapter = null;
            this.tableAdapterManager.ModalidadesTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTA;
            this.tableAdapterManager.UpdateOrder = PAP.PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaProdutosTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // categoriaTA
            // 
            this.categoriaTA.ClearBeforeFill = true;
            // 
            // cbocategoria
            // 
            this.cbocategoria.DataSource = this.categoriaBS;
            this.cbocategoria.DisplayMember = "NomeCategoria";
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(538, 56);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(211, 24);
            this.cbocategoria.TabIndex = 12;
            this.cbocategoria.ValueMember = "idCategoria";
            // 
            // categoriaBS
            // 
            this.categoriaBS.DataMember = "Categoria";
            this.categoriaBS.DataSource = this.pAPDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(125, 13);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(229, 22);
            this.txtnome.TabIndex = 14;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(125, 55);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(229, 22);
            this.txtmarca.TabIndex = 15;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(125, 99);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(229, 131);
            this.txtdesc.TabIndex = 16;
            // 
            // txtnomeBotao
            // 
            this.txtnomeBotao.Location = new System.Drawing.Point(538, 103);
            this.txtnomeBotao.Name = "txtnomeBotao";
            this.txtnomeBotao.Size = new System.Drawing.Size(229, 22);
            this.txtnomeBotao.TabIndex = 17;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(538, 15);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(229, 22);
            this.txtpreco.TabIndex = 18;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 242);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtnomeBotao);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbocategoria);
            this.Controls.Add(nomeBotaoLabel);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(precoLabel);
            this.Controls.Add(descricao_produtoLabel);
            this.Controls.Add(marca_ProdutoLabel);
            this.Controls.Add(nome_ProdutoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PAPDataSet pAPDataSet;
        private System.Windows.Forms.BindingSource produtosBS;
        private PAPDataSetTableAdapters.ProdutosTableAdapter produtosTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PAPDataSetTableAdapters.CategoriaTableAdapter categoriaTA;
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.BindingSource categoriaBS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtnomeBotao;
        private System.Windows.Forms.TextBox txtpreco;
    }
}