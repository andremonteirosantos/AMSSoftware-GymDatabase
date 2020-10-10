namespace PAP
{
    partial class FrmInserirCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInserirCliente));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mtxtdatainsc = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxttelemovel = new System.Windows.Forms.MaskedTextBox();
            this.txtemail2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mtxtaltura = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtnif = new System.Windows.Forms.MaskedTextBox();
            this.txtlocalidade = new System.Windows.Forms.TextBox();
            this.mtxtcodpostal = new System.Windows.Forms.MaskedTextBox();
            this.txtmorada = new System.Windows.Forms.TextBox();
            this.mtxtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pAPDataSet = new PAP.PAPDataSet();
            this.clienteBS = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTA = new PAP.PAPDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new PAP.PAPDataSetTableAdapters.TableAdapterManager();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtobs);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtvalor);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.cbotipo);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.mtxtdatainsc);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(587, 151);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(521, 230);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inscrição ";
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobs.Location = new System.Drawing.Point(145, 134);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(360, 76);
            this.txtobs.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 21);
            this.label13.TabIndex = 44;
            this.label13.Text = "Observações :";
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(93, 102);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(45, 26);
            this.txtvalor.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "Valor :";
            // 
            // cbotipo
            // 
            this.cbotipo.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "Semanal ",
            "Mensal ",
            "Anual"});
            this.cbotipo.Location = new System.Drawing.Point(191, 67);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(121, 26);
            this.cbotipo.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tipo de Pagamento :";
            // 
            // mtxtdatainsc
            // 
            this.mtxtdatainsc.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtdatainsc.Location = new System.Drawing.Point(173, 34);
            this.mtxtdatainsc.Mask = "00/00/0000";
            this.mtxtdatainsc.Name = "mtxtdatainsc";
            this.mtxtdatainsc.Size = new System.Drawing.Size(72, 26);
            this.mtxtdatainsc.TabIndex = 19;
            this.mtxtdatainsc.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Data de Inscrição :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxttelemovel);
            this.groupBox2.Controls.Add(this.txtemail2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(587, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 133);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contactos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // mtxttelemovel
            // 
            this.mtxttelemovel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxttelemovel.Location = new System.Drawing.Point(122, 27);
            this.mtxttelemovel.Mask = "000000000";
            this.mtxttelemovel.Name = "mtxttelemovel";
            this.mtxttelemovel.Size = new System.Drawing.Size(83, 26);
            this.mtxttelemovel.TabIndex = 9;
            // 
            // txtemail2
            // 
            this.txtemail2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail2.Location = new System.Drawing.Point(102, 99);
            this.txtemail2.Name = "txtemail2";
            this.txtemail2.Size = new System.Drawing.Size(405, 26);
            this.txtemail2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email 2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email 1 :";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(100, 61);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(405, 26);
            this.txtemail.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Telemóvel :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.mtxtaltura);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 117);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outros dados";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(134, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "cm";
            // 
            // mtxtaltura
            // 
            this.mtxtaltura.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtaltura.Location = new System.Drawing.Point(98, 74);
            this.mtxtaltura.Mask = "000";
            this.mtxtaltura.Name = "mtxtaltura";
            this.mtxtaltura.Size = new System.Drawing.Size(33, 26);
            this.mtxtaltura.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Altura : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbf);
            this.groupBox4.Controls.Add(this.rbm);
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(105, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 38);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(145, 13);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(82, 21);
            this.rbf.TabIndex = 35;
            this.rbf.Text = "Feminino";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Checked = true;
            this.rbm.Location = new System.Drawing.Point(18, 14);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(87, 21);
            this.rbm.TabIndex = 34;
            this.rbm.TabStop = true;
            this.rbm.Text = "Masculino";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Género : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtnif);
            this.groupBox1.Controls.Add(this.txtlocalidade);
            this.groupBox1.Controls.Add(this.mtxtcodpostal);
            this.groupBox1.Controls.Add(this.txtmorada);
            this.groupBox1.Controls.Add(this.mtxtdata);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 246);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mtxtnif
            // 
            this.mtxtnif.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtnif.Location = new System.Drawing.Point(76, 99);
            this.mtxtnif.Mask = "000000000";
            this.mtxtnif.Name = "mtxtnif";
            this.mtxtnif.Size = new System.Drawing.Size(73, 26);
            this.mtxtnif.TabIndex = 3;
            // 
            // txtlocalidade
            // 
            this.txtlocalidade.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocalidade.Location = new System.Drawing.Point(123, 203);
            this.txtlocalidade.Name = "txtlocalidade";
            this.txtlocalidade.Size = new System.Drawing.Size(157, 26);
            this.txtlocalidade.TabIndex = 6;
            // 
            // mtxtcodpostal
            // 
            this.mtxtcodpostal.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtcodpostal.Location = new System.Drawing.Point(150, 168);
            this.mtxtcodpostal.Mask = "0000-999";
            this.mtxtcodpostal.Name = "mtxtcodpostal";
            this.mtxtcodpostal.Size = new System.Drawing.Size(68, 26);
            this.mtxtcodpostal.TabIndex = 5;
            // 
            // txtmorada
            // 
            this.txtmorada.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmorada.Location = new System.Drawing.Point(98, 132);
            this.txtmorada.Name = "txtmorada";
            this.txtmorada.Size = new System.Drawing.Size(362, 26);
            this.txtmorada.TabIndex = 4;
            // 
            // mtxtdata
            // 
            this.mtxtdata.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtdata.Location = new System.Drawing.Point(191, 64);
            this.mtxtdata.Mask = "00/00/0000";
            this.mtxtdata.Name = "mtxtdata";
            this.mtxtdata.Size = new System.Drawing.Size(76, 26);
            this.mtxtdata.TabIndex = 2;
            this.mtxtdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(165, 26);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(295, 26);
            this.txtnome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Localidade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código Postal  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Morada :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIF :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo :";
            // 
            // erros
            // 
            this.erros.BlinkRate = 0;
            this.erros.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erros.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1114, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 39);
            this.button2.TabIndex = 44;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // FrmInserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInserirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInserirCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmInserirCliente_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtxtdatainsc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtxttelemovel;
        private System.Windows.Forms.TextBox txtemail2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mtxtaltura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtnif;
        private System.Windows.Forms.TextBox txtlocalidade;
        private System.Windows.Forms.MaskedTextBox mtxtcodpostal;
        private System.Windows.Forms.TextBox txtmorada;
        private System.Windows.Forms.MaskedTextBox mtxtdata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erros;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.BindingSource clienteBS;
        private PAPDataSet pAPDataSet;
        private PAPDataSetTableAdapters.clienteTableAdapter clienteTA;
        private PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}