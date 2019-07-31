namespace GhostBusters_Forms.View.Ticket
{
    partial class AddTechChamado
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
            this.cbBoxDisponiveis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeChamado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBoxDisponiveis
            // 
            this.cbBoxDisponiveis.FormattingEnabled = true;
            this.cbBoxDisponiveis.Location = new System.Drawing.Point(340, 95);
            this.cbBoxDisponiveis.Name = "cbBoxDisponiveis";
            this.cbBoxDisponiveis.Size = new System.Drawing.Size(121, 21);
            this.cbBoxDisponiveis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tecnicos:";
            // 
            // tbNomeChamado
            // 
            this.tbNomeChamado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbNomeChamado.Location = new System.Drawing.Point(131, 98);
            this.tbNomeChamado.Name = "tbNomeChamado";
            this.tbNomeChamado.Size = new System.Drawing.Size(163, 20);
            this.tbNomeChamado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chamado: ";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSave.Location = new System.Drawing.Point(494, 93);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adicionar Tech ao Chamado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GhostBusters_Forms.Properties.Resources.AddChamadoTech;
            this.pictureBox1.Location = new System.Drawing.Point(86, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AddTechChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(621, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeChamado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBoxDisponiveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTechChamado";
            this.Text = "Adicionar técnico ao chamado";
            this.Load += new System.EventHandler(this.AddTechChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxDisponiveis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeChamado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}