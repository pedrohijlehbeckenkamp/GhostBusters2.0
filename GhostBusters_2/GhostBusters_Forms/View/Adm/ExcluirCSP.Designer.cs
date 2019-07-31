namespace GhostBusters_Forms.View.Adm
{
    partial class ExcluirCSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVisualizar
            // 
            this.dgVisualizar.AllowUserToDeleteRows = false;
            this.dgVisualizar.AllowUserToResizeColumns = false;
            this.dgVisualizar.AllowUserToResizeRows = false;
            this.dgVisualizar.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgVisualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisualizar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NomeCategoria,
            this.CodigoStatus,
            this.NomeStatus,
            this.NomePerfil,
            this.CodPerfil,
            this.Perfil});
            this.dgVisualizar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVisualizar.Location = new System.Drawing.Point(51, 30);
            this.dgVisualizar.MultiSelect = false;
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.ReadOnly = true;
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(197, 202);
            this.dgVisualizar.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo_categoria";
            this.Codigo.HeaderText = "Cod Categoria";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // NomeCategoria
            // 
            this.NomeCategoria.DataPropertyName = "NomeCategoria";
            this.NomeCategoria.HeaderText = "Categoria";
            this.NomeCategoria.Name = "NomeCategoria";
            this.NomeCategoria.ReadOnly = true;
            // 
            // CodigoStatus
            // 
            this.CodigoStatus.DataPropertyName = "codigo_status";
            this.CodigoStatus.HeaderText = "Cod Status";
            this.CodigoStatus.Name = "CodigoStatus";
            this.CodigoStatus.ReadOnly = true;
            this.CodigoStatus.Width = 60;
            // 
            // NomeStatus
            // 
            this.NomeStatus.DataPropertyName = "NomeStatus";
            this.NomeStatus.HeaderText = "Status";
            this.NomeStatus.Name = "NomeStatus";
            this.NomeStatus.ReadOnly = true;
            // 
            // NomePerfil
            // 
            this.NomePerfil.DataPropertyName = "NomePerfil";
            this.NomePerfil.HeaderText = "Perfil";
            this.NomePerfil.Name = "NomePerfil";
            this.NomePerfil.ReadOnly = true;
            // 
            // CodPerfil
            // 
            this.CodPerfil.DataPropertyName = "Codigo";
            this.CodPerfil.HeaderText = "Cod Perfil";
            this.CodPerfil.Name = "CodPerfil";
            this.CodPerfil.ReadOnly = true;
            this.CodPerfil.Width = 60;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "nomePerfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(95, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 44);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // ExcluirCSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(299, 308);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgVisualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExcluirCSP";
            this.Text = "Excluir";
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.Button btnExcluir;
    }
}