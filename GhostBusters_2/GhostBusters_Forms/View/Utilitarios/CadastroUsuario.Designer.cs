namespace GhostBusters_Forms
{
    partial class CadastroUsuario
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
            this.label3 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConfirmeSenha = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfirmaEmail = new System.Windows.Forms.TextBox();
            this.lbConfirmaEmail = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureImagem = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.CbListarPerfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearImagem = new System.Windows.Forms.Button();
            this.BtVisSenha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEmailErro = new System.Windows.Forms.Label();
            this.lbErroConfEmail = new System.Windows.Forms.Label();
            this.lbNomeErro = new System.Windows.Forms.Label();
            this.lbErroConfSenha = new System.Windows.Forms.Label();
            this.lbErroSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cadastro de usuario";
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.Location = new System.Drawing.Point(316, 375);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(108, 44);
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Confirme sua Senha:";
            // 
            // tbConfirmeSenha
            // 
            this.tbConfirmeSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmeSenha.Location = new System.Drawing.Point(176, 300);
            this.tbConfirmeSenha.Name = "tbConfirmeSenha";
            this.tbConfirmeSenha.PasswordChar = '*';
            this.tbConfirmeSenha.Size = new System.Drawing.Size(219, 26);
            this.tbConfirmeSenha.TabIndex = 4;
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(176, 268);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(219, 26);
            this.tbSenha.TabIndex = 3;
            // 
            // tbConfirmaEmail
            // 
            this.tbConfirmaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmaEmail.Location = new System.Drawing.Point(176, 236);
            this.tbConfirmaEmail.Name = "tbConfirmaEmail";
            this.tbConfirmaEmail.Size = new System.Drawing.Size(219, 26);
            this.tbConfirmaEmail.TabIndex = 2;
            // 
            // lbConfirmaEmail
            // 
            this.lbConfirmaEmail.AutoSize = true;
            this.lbConfirmaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmaEmail.Location = new System.Drawing.Point(22, 239);
            this.lbConfirmaEmail.Name = "lbConfirmaEmail";
            this.lbConfirmaEmail.Size = new System.Drawing.Size(148, 20);
            this.lbConfirmaEmail.TabIndex = 26;
            this.lbConfirmaEmail.Text = "Confirme seu email:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(118, 207);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 25;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(176, 204);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 26);
            this.tbEmail.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(115, 148);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 23;
            this.lbNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(177, 145);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(219, 26);
            this.tbNome.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Escolha uma imagem";
            // 
            // pictureImagem
            // 
            this.pictureImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureImagem.Location = new System.Drawing.Point(549, 155);
            this.pictureImagem.Name = "pictureImagem";
            this.pictureImagem.Size = new System.Drawing.Size(161, 129);
            this.pictureImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImagem.TabIndex = 33;
            this.pictureImagem.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbrirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirImagem.ForeColor = System.Drawing.Color.White;
            this.btnAbrirImagem.Location = new System.Drawing.Point(540, 294);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(87, 26);
            this.btnAbrirImagem.TabIndex = 6;
            this.btnAbrirImagem.Text = "Abrir imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = false;
            this.btnAbrirImagem.Click += new System.EventHandler(this.BtnAbrirImagem_Click);
            // 
            // CbListarPerfil
            // 
            this.CbListarPerfil.BackColor = System.Drawing.Color.White;
            this.CbListarPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbListarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbListarPerfil.FormattingEnabled = true;
            this.CbListarPerfil.Location = new System.Drawing.Point(177, 177);
            this.CbListarPerfil.Name = "CbListarPerfil";
            this.CbListarPerfil.Size = new System.Drawing.Size(218, 21);
            this.CbListarPerfil.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Perfil:";
            // 
            // ClearImagem
            // 
            this.ClearImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearImagem.ForeColor = System.Drawing.Color.White;
            this.ClearImagem.Location = new System.Drawing.Point(633, 294);
            this.ClearImagem.Name = "ClearImagem";
            this.ClearImagem.Size = new System.Drawing.Size(87, 26);
            this.ClearImagem.TabIndex = 37;
            this.ClearImagem.Text = "Clear imagem";
            this.ClearImagem.UseVisualStyleBackColor = false;
            this.ClearImagem.Click += new System.EventHandler(this.ClearImagem_Click);
            // 
            // BtVisSenha
            // 
            this.BtVisSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtVisSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVisSenha.ForeColor = System.Drawing.Color.White;
            this.BtVisSenha.Location = new System.Drawing.Point(401, 300);
            this.BtVisSenha.Name = "BtVisSenha";
            this.BtVisSenha.Size = new System.Drawing.Size(98, 26);
            this.BtVisSenha.TabIndex = 38;
            this.BtVisSenha.Text = "Visualizar Senha ";
            this.BtVisSenha.UseVisualStyleBackColor = false;
            this.BtVisSenha.MouseEnter += new System.EventHandler(this.BtVisSenha_MouseEnter);
            this.BtVisSenha.MouseLeave += new System.EventHandler(this.BtVisSenha_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 82);
            this.panel1.TabIndex = 39;
            // 
            // lbEmailErro
            // 
            this.lbEmailErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbEmailErro.Location = new System.Drawing.Point(398, 207);
            this.lbEmailErro.Name = "lbEmailErro";
            this.lbEmailErro.Size = new System.Drawing.Size(145, 23);
            this.lbEmailErro.TabIndex = 40;
            this.lbEmailErro.Text = "Email ou senha incorreta!";
            // 
            // lbErroConfEmail
            // 
            this.lbErroConfEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErroConfEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbErroConfEmail.Location = new System.Drawing.Point(398, 239);
            this.lbErroConfEmail.Name = "lbErroConfEmail";
            this.lbErroConfEmail.Size = new System.Drawing.Size(145, 23);
            this.lbErroConfEmail.TabIndex = 41;
            this.lbErroConfEmail.Text = "Email ou senha incorreta!";
            // 
            // lbNomeErro
            // 
            this.lbNomeErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNomeErro.Location = new System.Drawing.Point(398, 148);
            this.lbNomeErro.Name = "lbNomeErro";
            this.lbNomeErro.Size = new System.Drawing.Size(145, 23);
            this.lbNomeErro.TabIndex = 42;
            this.lbNomeErro.Text = "Email ou senha incorreta!";
            // 
            // lbErroConfSenha
            // 
            this.lbErroConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErroConfSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbErroConfSenha.Location = new System.Drawing.Point(221, 329);
            this.lbErroConfSenha.Name = "lbErroConfSenha";
            this.lbErroConfSenha.Size = new System.Drawing.Size(132, 16);
            this.lbErroConfSenha.TabIndex = 43;
            this.lbErroConfSenha.Text = "Senha incorreta!";
            // 
            // lbErroSenha
            // 
            this.lbErroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErroSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbErroSenha.Location = new System.Drawing.Point(401, 271);
            this.lbErroSenha.Name = "lbErroSenha";
            this.lbErroSenha.Size = new System.Drawing.Size(132, 16);
            this.lbErroSenha.TabIndex = 44;
            this.lbErroSenha.Text = "Senha incorreta!";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.lbErroSenha);
            this.Controls.Add(this.lbErroConfSenha);
            this.Controls.Add(this.lbNomeErro);
            this.Controls.Add(this.lbErroConfEmail);
            this.Controls.Add(this.lbEmailErro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtVisSenha);
            this.Controls.Add(this.ClearImagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbListarPerfil);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictureImagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbConfirmeSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbConfirmaEmail);
            this.Controls.Add(this.lbConfirmaEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroUsuario";
            this.Text = "Cadastro de usuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConfirmeSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfirmaEmail;
        private System.Windows.Forms.Label lbConfirmaEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureImagem;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.ComboBox CbListarPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearImagem;
        private System.Windows.Forms.Button BtVisSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEmailErro;
        private System.Windows.Forms.Label lbErroConfEmail;
        private System.Windows.Forms.Label lbNomeErro;
        private System.Windows.Forms.Label lbErroConfSenha;
        private System.Windows.Forms.Label lbErroSenha;
    }
}