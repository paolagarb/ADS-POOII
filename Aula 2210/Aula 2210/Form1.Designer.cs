namespace Aula_2210
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gpBoxLancamento = new System.Windows.Forms.GroupBox();
            this.radioBtnSim = new System.Windows.Forms.RadioButton();
            this.radioBtnNao = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dtpickerDate = new System.Windows.Forms.DateTimePicker();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.mskRazaoSocial = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskEndereco = new System.Windows.Forms.MaskedTextBox();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.mskProduto = new System.Windows.Forms.MaskedTextBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRazaoSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLancamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpBoxLancamento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALMOXARIFADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "FORNECEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "COMPRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Razão Social";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 30);
            this.label9.TabIndex = 12;
            this.label9.Text = "Lançamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(307, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 30);
            this.label10.TabIndex = 11;
            this.label10.Text = "Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(307, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(307, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 30);
            this.label12.TabIndex = 9;
            this.label12.Text = "Produto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(307, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 30);
            this.label13.TabIndex = 8;
            this.label13.Text = "Categoria";
            // 
            // gpBoxLancamento
            // 
            this.gpBoxLancamento.Controls.Add(this.radioBtnNao);
            this.gpBoxLancamento.Controls.Add(this.radioBtnSim);
            this.gpBoxLancamento.Location = new System.Drawing.Point(401, 250);
            this.gpBoxLancamento.Name = "gpBoxLancamento";
            this.gpBoxLancamento.Size = new System.Drawing.Size(141, 28);
            this.gpBoxLancamento.TabIndex = 13;
            this.gpBoxLancamento.TabStop = false;
            // 
            // radioBtnSim
            // 
            this.radioBtnSim.AutoSize = true;
            this.radioBtnSim.Location = new System.Drawing.Point(16, 9);
            this.radioBtnSim.Name = "radioBtnSim";
            this.radioBtnSim.Size = new System.Drawing.Size(44, 17);
            this.radioBtnSim.TabIndex = 0;
            this.radioBtnSim.TabStop = true;
            this.radioBtnSim.Text = "SIM";
            this.radioBtnSim.UseVisualStyleBackColor = true;
            // 
            // radioBtnNao
            // 
            this.radioBtnNao.AutoSize = true;
            this.radioBtnNao.Location = new System.Drawing.Point(77, 9);
            this.radioBtnNao.Name = "radioBtnNao";
            this.radioBtnNao.Size = new System.Drawing.Size(48, 17);
            this.radioBtnNao.TabIndex = 1;
            this.radioBtnNao.TabStop = true;
            this.radioBtnNao.Text = "NÃO";
            this.radioBtnNao.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Snow;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGravar.Location = new System.Drawing.Point(218, 304);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(137, 33);
            this.btnGravar.TabIndex = 23;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dtpickerDate
            // 
            this.dtpickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerDate.Location = new System.Drawing.Point(401, 224);
            this.dtpickerDate.Name = "dtpickerDate";
            this.dtpickerDate.Size = new System.Drawing.Size(141, 20);
            this.dtpickerDate.TabIndex = 24;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(400, 121);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(141, 21);
            this.cboCategoria.TabIndex = 25;
            // 
            // mskID
            // 
            this.mskID.Location = new System.Drawing.Point(128, 122);
            this.mskID.Mask = "00000";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(141, 20);
            this.mskID.TabIndex = 26;
            this.mskID.ValidatingType = typeof(int);
            // 
            // mskRazaoSocial
            // 
            this.mskRazaoSocial.Location = new System.Drawing.Point(128, 156);
            this.mskRazaoSocial.Name = "mskRazaoSocial";
            this.mskRazaoSocial.Size = new System.Drawing.Size(141, 20);
            this.mskRazaoSocial.TabIndex = 27;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(128, 190);
            this.mskTelefone.Mask = "(000) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(141, 20);
            this.mskTelefone.TabIndex = 28;
            // 
            // mskEndereco
            // 
            this.mskEndereco.Location = new System.Drawing.Point(128, 224);
            this.mskEndereco.Name = "mskEndereco";
            this.mskEndereco.Size = new System.Drawing.Size(141, 20);
            this.mskEndereco.TabIndex = 29;
            // 
            // mskEmail
            // 
            this.mskEmail.Location = new System.Drawing.Point(128, 258);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.Size = new System.Drawing.Size(141, 20);
            this.mskEmail.TabIndex = 30;
            // 
            // mskProduto
            // 
            this.mskProduto.Location = new System.Drawing.Point(400, 156);
            this.mskProduto.Name = "mskProduto";
            this.mskProduto.Size = new System.Drawing.Size(141, 20);
            this.mskProduto.TabIndex = 31;
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(400, 190);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(141, 20);
            this.mskValor.TabIndex = 32;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderRazaoSocial,
            this.columnHeaderTelefone,
            this.columnHeaderEndereco,
            this.columnHeaderEmail,
            this.columnHeaderCategoria,
            this.columnHeaderProduto,
            this.columnHeaderValor,
            this.columnHeaderData,
            this.columnHeaderLancamento});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 387);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(579, 128);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 39;
            // 
            // columnHeaderRazaoSocial
            // 
            this.columnHeaderRazaoSocial.Text = "Razão Social";
            this.columnHeaderRazaoSocial.Width = 78;
            // 
            // columnHeaderTelefone
            // 
            this.columnHeaderTelefone.Text = "Telefone";
            // 
            // columnHeaderEndereco
            // 
            this.columnHeaderEndereco.Text = "Endereço";
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "E-mail";
            this.columnHeaderEmail.Width = 50;
            // 
            // columnHeaderCategoria
            // 
            this.columnHeaderCategoria.Text = "Categoria";
            // 
            // columnHeaderProduto
            // 
            this.columnHeaderProduto.Text = "Produto";
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.Width = 42;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 44;
            // 
            // columnHeaderLancamento
            // 
            this.columnHeaderLancamento.Text = "Lançamento";
            this.columnHeaderLancamento.Width = 82;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 216);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(300, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 216);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(243, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 26);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(578, 514);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mskValor);
            this.Controls.Add(this.mskProduto);
            this.Controls.Add(this.mskEmail);
            this.Controls.Add(this.mskEndereco);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskRazaoSocial);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.dtpickerDate);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gpBoxLancamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpBoxLancamento.ResumeLayout(false);
            this.gpBoxLancamento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gpBoxLancamento;
        private System.Windows.Forms.RadioButton radioBtnNao;
        private System.Windows.Forms.RadioButton radioBtnSim;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker dtpickerDate;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.MaskedTextBox mskID;
        private System.Windows.Forms.MaskedTextBox mskRazaoSocial;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskEndereco;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.MaskedTextBox mskProduto;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderRazaoSocial;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefone;
        private System.Windows.Forms.ColumnHeader columnHeaderEndereco;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoria;
        private System.Windows.Forms.ColumnHeader columnHeaderProduto;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderLancamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpar;
    }
}

