namespace GhostBusters_Forms.View.Status
{
    partial class CadastrarStatus
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
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNomeS = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CbListarPerfil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Black;
            this.lbNome.Location = new System.Drawing.Point(53, 37);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(70, 25);
            this.lbNome.TabIndex = 27;
            this.lbNome.Text = "Nome:";
            // 
            // tbNomeS
            // 
            this.tbNomeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeS.Location = new System.Drawing.Point(124, 37);
            this.tbNomeS.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomeS.Name = "tbNomeS";
            this.tbNomeS.Size = new System.Drawing.Size(291, 30);
            this.tbNomeS.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(449, 37);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 62);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Perfil:";
            // 
            // CbListarPerfil
            // 
            this.CbListarPerfil.BackColor = System.Drawing.Color.White;
            this.CbListarPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbListarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbListarPerfil.FormattingEnabled = true;
            this.CbListarPerfil.Location = new System.Drawing.Point(126, 90);
            this.CbListarPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.CbListarPerfil.Name = "CbListarPerfil";
            this.CbListarPerfil.Size = new System.Drawing.Size(289, 24);
            this.CbListarPerfil.TabIndex = 37;
            // 
            // CadastrarStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(594, 154);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbListarPerfil);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNomeS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarStatus";
            this.Text = "Cadastrar status";
            this.Load += new System.EventHandler(this.CadastrarStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNomeS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbListarPerfil;
    }
}