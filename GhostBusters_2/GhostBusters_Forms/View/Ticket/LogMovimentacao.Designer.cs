namespace GhostBusters_Forms.View.Ticket
{
    partial class LogMovimentacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgLog = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Status_Ant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Status_New = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.lbObservacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log De Movimentação";
            // 
            // dgLog
            // 
            this.dgLog.AllowUserToAddRows = false;
            this.dgLog.AllowUserToDeleteRows = false;
            this.dgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Usuario,
            this.Nome_Status_Ant,
            this.Nome_Status_New,
            this.Data_log});
            this.dgLog.Location = new System.Drawing.Point(25, 89);
            this.dgLog.Name = "dgLog";
            this.dgLog.ReadOnly = true;
            this.dgLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLog.Size = new System.Drawing.Size(544, 196);
            this.dgLog.TabIndex = 0;
            this.dgLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLog_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo_Log";
            this.Codigo.HeaderText = "Codigo_Log";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario Aleterou";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Nome_Status_Ant
            // 
            this.Nome_Status_Ant.DataPropertyName = "Nome_Status_Ant";
            this.Nome_Status_Ant.HeaderText = "Status Ant";
            this.Nome_Status_Ant.Name = "Nome_Status_Ant";
            this.Nome_Status_Ant.ReadOnly = true;
            // 
            // Nome_Status_New
            // 
            this.Nome_Status_New.DataPropertyName = "Nome_Status_New";
            this.Nome_Status_New.HeaderText = "Status Novo";
            this.Nome_Status_New.Name = "Nome_Status_New";
            this.Nome_Status_New.ReadOnly = true;
            // 
            // Data_log
            // 
            this.Data_log.DataPropertyName = "Data_log";
            this.Data_log.HeaderText = "Data Log";
            this.Data_log.Name = "Data_log";
            this.Data_log.ReadOnly = true;
            // 
            // tbObservacao
            // 
            this.tbObservacao.Enabled = false;
            this.tbObservacao.Location = new System.Drawing.Point(575, 133);
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(204, 112);
            this.tbObservacao.TabIndex = 1;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservacao.Location = new System.Drawing.Point(575, 89);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(128, 25);
            this.lbObservacao.TabIndex = 3;
            this.lbObservacao.Text = "Observação";
            // 
            // LogMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(818, 303);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this.tbObservacao);
            this.Controls.Add(this.dgLog);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogMovimentacao";
            this.Text = "LogMovimentacao";
            this.Load += new System.EventHandler(this.LogMovimentacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Status_Ant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Status_New;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_log;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.Label lbObservacao;
    }
}