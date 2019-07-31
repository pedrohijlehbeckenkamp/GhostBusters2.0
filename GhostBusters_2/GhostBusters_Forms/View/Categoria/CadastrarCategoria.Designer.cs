namespace GhostBusters_Forms.View.Categoria
{
    partial class CadastrarCategoria
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
            this.btnSaveCategoria = new System.Windows.Forms.Button();
            this.lbNomeCateg = new System.Windows.Forms.Label();
            this.tbNomeCateg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveCategoria
            // 
            this.btnSaveCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveCategoria.ForeColor = System.Drawing.Color.White;
            this.btnSaveCategoria.Location = new System.Drawing.Point(303, 34);
            this.btnSaveCategoria.Name = "btnSaveCategoria";
            this.btnSaveCategoria.Size = new System.Drawing.Size(80, 50);
            this.btnSaveCategoria.TabIndex = 29;
            this.btnSaveCategoria.Text = "Save";
            this.btnSaveCategoria.UseVisualStyleBackColor = false;
            this.btnSaveCategoria.Click += new System.EventHandler(this.BtnSaveCategoria_Click);
            // 
            // lbNomeCateg
            // 
            this.lbNomeCateg.AutoSize = true;
            this.lbNomeCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCateg.Location = new System.Drawing.Point(31, 47);
            this.lbNomeCateg.Name = "lbNomeCateg";
            this.lbNomeCateg.Size = new System.Drawing.Size(55, 20);
            this.lbNomeCateg.TabIndex = 30;
            this.lbNomeCateg.Text = "Nome:";
            // 
            // tbNomeCateg
            // 
            this.tbNomeCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCateg.Location = new System.Drawing.Point(89, 47);
            this.tbNomeCateg.Name = "tbNomeCateg";
            this.tbNomeCateg.Size = new System.Drawing.Size(200, 26);
            this.tbNomeCateg.TabIndex = 28;
            // 
            // CadastrarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(409, 119);
            this.Controls.Add(this.btnSaveCategoria);
            this.Controls.Add(this.lbNomeCateg);
            this.Controls.Add(this.tbNomeCateg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastrarCategoria";
            this.Text = "Cadastrar categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveCategoria;
        private System.Windows.Forms.Label lbNomeCateg;
        private System.Windows.Forms.TextBox tbNomeCateg;
    }
}