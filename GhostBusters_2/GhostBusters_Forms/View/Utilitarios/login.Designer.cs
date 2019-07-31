using System.Windows.Forms;

namespace GhostBusters_Forms
{
    partial class Login : Form
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbApresentacao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbErro = new System.Windows.Forms.Label();
            this.BtVisSenha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(345, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 47);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.Black;
            this.lbSenha.Location = new System.Drawing.Point(196, 242);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(88, 29);
            this.lbSenha.TabIndex = 10;
            this.lbSenha.Text = "Senha:";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(290, 239);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(221, 35);
            this.tbSenha.TabIndex = 1;
            this.tbSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbSenha_KeyUp);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbUsuario.Location = new System.Drawing.Point(184, 192);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(102, 29);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuário:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(290, 189);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(221, 35);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbUsuario_KeyUp);
            // 
            // lbApresentacao
            // 
            this.lbApresentacao.AutoSize = true;
            this.lbApresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApresentacao.ForeColor = System.Drawing.Color.Black;
            this.lbApresentacao.Location = new System.Drawing.Point(189, 25);
            this.lbApresentacao.Name = "lbApresentacao";
            this.lbApresentacao.Size = new System.Drawing.Size(404, 29);
            this.lbApresentacao.TabIndex = 13;
            this.lbApresentacao.Text = "Bem vindos ao Ghostbursters_Help!!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbApresentacao);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 82);
            this.panel1.TabIndex = 14;
            // 
            // lbErro
            // 
            this.lbErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbErro.Location = new System.Drawing.Point(309, 161);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(181, 23);
            this.lbErro.TabIndex = 15;
            this.lbErro.Text = "Email ou senha incorreta!";
            // 
            // BtVisSenha
            // 
            this.BtVisSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtVisSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVisSenha.ForeColor = System.Drawing.Color.White;
            this.BtVisSenha.Location = new System.Drawing.Point(517, 239);
            this.BtVisSenha.Name = "BtVisSenha";
            this.BtVisSenha.Size = new System.Drawing.Size(98, 35);
            this.BtVisSenha.TabIndex = 39;
            this.BtVisSenha.Text = "Visualizar Senha ";
            this.BtVisSenha.UseVisualStyleBackColor = false;
            this.BtVisSenha.MouseEnter += new System.EventHandler(this.BtVisSenha_MouseEnter);
            this.BtVisSenha.MouseLeave += new System.EventHandler(this.BtVisSenha_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.BtVisSenha);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.tbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private Label lbApresentacao;
        private Panel panel1;
        private Label lbErro;
        private Button BtVisSenha;
    }
}