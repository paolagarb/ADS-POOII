namespace Aula_2409
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picLua = new System.Windows.Forms.PictureBox();
            this.picSol = new System.Windows.Forms.PictureBox();
            this.picSairB = new System.Windows.Forms.PictureBox();
            this.picLogoB = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSairB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(166, 160);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(85, 28);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(146, 84);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(176, 23);
            this.txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(146, 117);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(176, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aula_2409.Properties.Resources.sair;
            this.pictureBox2.Location = new System.Drawing.Point(369, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Aula_2409.Properties.Resources.kisspng_sunglasses_logo_brand_shopping_happy_hour_flyer_5adefc942d6946_796572671524563092186;
            this.picLogo.Location = new System.Drawing.Point(155, -4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(124, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // picLua
            // 
            this.picLua.Image = global::Aula_2409.Properties.Resources.lua;
            this.picLua.Location = new System.Drawing.Point(6, 4);
            this.picLua.Name = "picLua";
            this.picLua.Size = new System.Drawing.Size(23, 23);
            this.picLua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLua.TabIndex = 9;
            this.picLua.TabStop = false;
            this.picLua.Click += new System.EventHandler(this.picLua_Click);
            // 
            // picSol
            // 
            this.picSol.Image = global::Aula_2409.Properties.Resources.sol1;
            this.picSol.Location = new System.Drawing.Point(6, 5);
            this.picSol.Name = "picSol";
            this.picSol.Size = new System.Drawing.Size(23, 23);
            this.picSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSol.TabIndex = 10;
            this.picSol.TabStop = false;
            this.picSol.Click += new System.EventHandler(this.picSol_Click);
            // 
            // picSairB
            // 
            this.picSairB.Image = global::Aula_2409.Properties.Resources.sair_branco;
            this.picSairB.Location = new System.Drawing.Point(369, 5);
            this.picSairB.Name = "picSairB";
            this.picSairB.Size = new System.Drawing.Size(27, 21);
            this.picSairB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSairB.TabIndex = 11;
            this.picSairB.TabStop = false;
            this.picSairB.Click += new System.EventHandler(this.picSairB_Click);
            // 
            // picLogoB
            // 
            this.picLogoB.Image = global::Aula_2409.Properties.Resources.kisspng_sunglasses_logo_brand_shopping_happy_hour_flyer_5adefc942d6946_796572671524563092186__1_;
            this.picLogoB.Location = new System.Drawing.Point(155, -4);
            this.picLogoB.Name = "picLogoB";
            this.picLogoB.Size = new System.Drawing.Size(124, 60);
            this.picLogoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoB.TabIndex = 12;
            this.picLogoB.TabStop = false;
            this.picLogoB.Click += new System.EventHandler(this.picLogoB_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(285, 5);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(77, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(406, 211);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.picLogoB);
            this.Controls.Add(this.picSairB);
            this.Controls.Add(this.picSol);
            this.Controls.Add(this.picLua);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSairB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picLua;
        private System.Windows.Forms.PictureBox picSol;
        private System.Windows.Forms.PictureBox picSairB;
        private System.Windows.Forms.PictureBox picLogoB;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

