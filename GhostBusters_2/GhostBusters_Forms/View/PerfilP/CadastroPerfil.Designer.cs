namespace GhostBusters_Forms.View.PerfilP
{
    partial class CadastroPerfil
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
            this.btnSavePer = new System.Windows.Forms.Button();
            this.lbNomeCateg = new System.Windows.Forms.Label();
            this.tbNomePe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSavePer
            // 
            this.btnSavePer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSavePer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSavePer.ForeColor = System.Drawing.Color.White;
            this.btnSavePer.Location = new System.Drawing.Point(313, 28);
            this.btnSavePer.Name = "btnSavePer";
            this.btnSavePer.Size = new System.Drawing.Size(80, 50);
            this.btnSavePer.TabIndex = 32;
            this.btnSavePer.Text = "Save";
            this.btnSavePer.UseVisualStyleBackColor = false;
            this.btnSavePer.Click += new System.EventHandler(this.BtnSavePer_Click);
            // 
            // lbNomeCateg
            // 
            this.lbNomeCateg.AutoSize = true;
            this.lbNomeCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCateg.Location = new System.Drawing.Point(40, 41);
            this.lbNomeCateg.Name = "lbNomeCateg";
            this.lbNomeCateg.Size = new System.Drawing.Size(55, 20);
            this.lbNomeCateg.TabIndex = 33;
            this.lbNomeCateg.Text = "Nome:";
            // 
            // tbNomePe
            // 
            this.tbNomePe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomePe.Location = new System.Drawing.Point(99, 41);
            this.tbNomePe.Name = "tbNomePe";
            this.tbNomePe.Size = new System.Drawing.Size(200, 26);
            this.tbNomePe.TabIndex = 31;
            // 
            // CadastroPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(409, 119);
            this.Controls.Add(this.btnSavePer);
            this.Controls.Add(this.lbNomeCateg);
            this.Controls.Add(this.tbNomePe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroPerfil";
            this.Text = "Cadastrar perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSavePer;
        private System.Windows.Forms.Label lbNomeCateg;
        private System.Windows.Forms.TextBox tbNomePe;
    }
}