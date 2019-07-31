namespace GhostBusters_Forms.View.Adm
{
    partial class AlterarStatus
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.lbObservacoes = new System.Windows.Forms.Label();
            this.lbAlterarStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(60, 114);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status:";
            // 
            // CbStatus
            // 
            this.CbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Location = new System.Drawing.Point(122, 111);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(192, 21);
            this.CbStatus.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Location = new System.Drawing.Point(168, 270);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // tbObservacao
            // 
            this.tbObservacao.Location = new System.Drawing.Point(122, 163);
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(192, 87);
            this.tbObservacao.TabIndex = 3;
            // 
            // lbObservacoes
            // 
            this.lbObservacoes.AutoSize = true;
            this.lbObservacoes.Location = new System.Drawing.Point(27, 166);
            this.lbObservacoes.Name = "lbObservacoes";
            this.lbObservacoes.Size = new System.Drawing.Size(73, 13);
            this.lbObservacoes.TabIndex = 4;
            this.lbObservacoes.Text = "Observacoes:";
            // 
            // lbAlterarStatus
            // 
            this.lbAlterarStatus.AutoSize = true;
            this.lbAlterarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlterarStatus.Location = new System.Drawing.Point(89, 32);
            this.lbAlterarStatus.Name = "lbAlterarStatus";
            this.lbAlterarStatus.Size = new System.Drawing.Size(212, 37);
            this.lbAlterarStatus.TabIndex = 5;
            this.lbAlterarStatus.Text = "Alterar Status";
            // 
            // AlterarStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(375, 308);
            this.Controls.Add(this.lbAlterarStatus);
            this.Controls.Add(this.lbObservacoes);
            this.Controls.Add(this.tbObservacao);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.lbStatus);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AlterarStatus";
            this.Text = "Alterar status";
            this.Load += new System.EventHandler(this.AlterarStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox CbStatus;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.Label lbObservacoes;
        private System.Windows.Forms.Label lbAlterarStatus;
    }
}