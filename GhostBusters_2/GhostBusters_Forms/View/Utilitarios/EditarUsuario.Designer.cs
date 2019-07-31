namespace GhostBusters_Forms.View
{
    partial class EditarUsuario
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.lbNomeInvalido = new System.Windows.Forms.Label();
            this.lbEmailInvalido = new System.Windows.Forms.Label();
            this.lbEmailExistente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(71, 107);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 40;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(130, 104);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 26);
            this.tbEmail.TabIndex = 38;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(71, 50);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 39;
            this.lbNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(130, 47);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(219, 26);
            this.tbNome.TabIndex = 37;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.Location = new System.Drawing.Point(160, 156);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(108, 44);
            this.butSave.TabIndex = 45;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // lbNomeInvalido
            // 
            this.lbNomeInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeInvalido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNomeInvalido.Location = new System.Drawing.Point(175, 28);
            this.lbNomeInvalido.Name = "lbNomeInvalido";
            this.lbNomeInvalido.Size = new System.Drawing.Size(132, 16);
            this.lbNomeInvalido.TabIndex = 46;
            this.lbNomeInvalido.Text = "Nome Invalido";
            // 
            // lbEmailInvalido
            // 
            this.lbEmailInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailInvalido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbEmailInvalido.Location = new System.Drawing.Point(166, 85);
            this.lbEmailInvalido.Name = "lbEmailInvalido";
            this.lbEmailInvalido.Size = new System.Drawing.Size(132, 16);
            this.lbEmailInvalido.TabIndex = 47;
            this.lbEmailInvalido.Text = "Email Invalido";
            // 
            // lbEmailExistente
            // 
            this.lbEmailExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailExistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbEmailExistente.Location = new System.Drawing.Point(166, 133);
            this.lbEmailExistente.Name = "lbEmailExistente";
            this.lbEmailExistente.Size = new System.Drawing.Size(132, 16);
            this.lbEmailExistente.TabIndex = 48;
            this.lbEmailExistente.Text = "Email Invalido";
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(423, 212);
            this.Controls.Add(this.lbEmailExistente);
            this.Controls.Add(this.lbEmailInvalido);
            this.Controls.Add(this.lbNomeInvalido);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarUsuario";
            this.Text = "Editar usuário";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Label lbNomeInvalido;
        private System.Windows.Forms.Label lbEmailInvalido;
        private System.Windows.Forms.Label lbEmailExistente;
    }
}