namespace GhostBusters_Forms.View.Adm
{
    partial class ConfigAdm
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
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
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
            this.dgVisualizar.Location = new System.Drawing.Point(33, 78);
            this.dgVisualizar.MultiSelect = false;
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.ReadOnly = true;
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(285, 202);
            this.dgVisualizar.TabIndex = 3;
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
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Location = new System.Drawing.Point(20, 12);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(102, 44);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.Text = "Visualizar categoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(351, 154);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 44);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(351, 78);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 44);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(351, 236);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 44);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(128, 12);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(102, 44);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "Visualizar status";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.BtnStatus_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Location = new System.Drawing.Point(236, 12);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(102, 44);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "Visualizar perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
            // 
            // ConfigAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(483, 308);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.dgVisualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigAdm";
            this.Text = "Configurações ";
            this.Load += new System.EventHandler(this.ConfigAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
    }
}