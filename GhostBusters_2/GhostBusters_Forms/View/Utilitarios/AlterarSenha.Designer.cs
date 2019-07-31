namespace GhostBusters_Forms
{
    partial class AlterarSenha
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
            this.butSave = new System.Windows.Forms.Button();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConfSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSenhaPrinc = new System.Windows.Forms.Label();
            this.lbInsiraSenha = new System.Windows.Forms.Label();
            this.lbConfSenha = new System.Windows.Forms.Label();
            this.BtVisSenha = new System.Windows.Forms.Button();
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.Location = new System.Drawing.Point(220, 319);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(79, 44);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(255, 51);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(44, 20);
            this.lbPerfil.TabIndex = 48;
            this.lbPerfil.Text = "Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Insira a  nova senha:";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(198, 163);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(116, 26);
            this.tbSenha.TabIndex = 40;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(255, 84);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 43;
            this.lbEmail.Text = "Email";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(253, 18);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(51, 20);
            this.lbNome.TabIndex = 42;
            this.lbNome.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(-73, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 25);
            this.panel1.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Senha atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Insira a senha novamente:";
            // 
            // tbConfSenha
            // 
            this.tbConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfSenha.Location = new System.Drawing.Point(198, 239);
            this.tbConfSenha.Name = "tbConfSenha";
            this.tbConfSenha.PasswordChar = '*';
            this.tbConfSenha.Size = new System.Drawing.Size(116, 26);
            this.tbConfSenha.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Perfil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Email:";
            // 
            // lbSenhaPrinc
            // 
            this.lbSenhaPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaPrinc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenhaPrinc.Location = new System.Drawing.Point(320, 166);
            this.lbSenhaPrinc.Name = "lbSenhaPrinc";
            this.lbSenhaPrinc.Size = new System.Drawing.Size(97, 23);
            this.lbSenhaPrinc.TabIndex = 56;
            this.lbSenhaPrinc.Text = "Senha incorreta!";
            // 
            // lbInsiraSenha
            // 
            this.lbInsiraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsiraSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbInsiraSenha.Location = new System.Drawing.Point(320, 211);
            this.lbInsiraSenha.Name = "lbInsiraSenha";
            this.lbInsiraSenha.Size = new System.Drawing.Size(97, 23);
            this.lbInsiraSenha.TabIndex = 57;
            this.lbInsiraSenha.Text = "senha incorreta!";
            // 
            // lbConfSenha
            // 
            this.lbConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbConfSenha.Location = new System.Drawing.Point(320, 242);
            this.lbConfSenha.Name = "lbConfSenha";
            this.lbConfSenha.Size = new System.Drawing.Size(97, 23);
            this.lbConfSenha.TabIndex = 58;
            this.lbConfSenha.Text = "Senha incorreta!";
            // 
            // BtVisSenha
            // 
            this.BtVisSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtVisSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVisSenha.ForeColor = System.Drawing.Color.White;
            this.BtVisSenha.Location = new System.Drawing.Point(198, 271);
            this.BtVisSenha.Name = "BtVisSenha";
            this.BtVisSenha.Size = new System.Drawing.Size(116, 25);
            this.BtVisSenha.TabIndex = 59;
            this.BtVisSenha.Text = "Visualizar Senha ";
            this.BtVisSenha.UseVisualStyleBackColor = false;
            this.BtVisSenha.MouseEnter += new System.EventHandler(this.BtVisSenha_MouseEnter);
            this.BtVisSenha.MouseLeave += new System.EventHandler(this.BtVisSenha_MouseLeave);
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaSenha.Location = new System.Drawing.Point(198, 203);
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.PasswordChar = '*';
            this.tbNovaSenha.Size = new System.Drawing.Size(116, 26);
            this.tbNovaSenha.TabIndex = 60;
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(519, 386);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.BtVisSenha);
            this.Controls.Add(this.lbConfSenha);
            this.Controls.Add(this.lbInsiraSenha);
            this.Controls.Add(this.lbSenhaPrinc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbConfSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.butSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlterarSenha";
            this.Text = "Vizualizar perfil";
            this.Load += new System.EventHandler(this.EditarUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSenhaPrinc;
        private System.Windows.Forms.Label lbInsiraSenha;
        private System.Windows.Forms.Label lbConfSenha;
        private System.Windows.Forms.Button BtVisSenha;
        private System.Windows.Forms.TextBox tbNovaSenha;
    }
}