namespace GhostBusters_Forms.View.Adm
{
    partial class Editar
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.Codigo_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTecnicos = new System.Windows.Forms.Button();
            this.btnAdms = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(193, 24);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(102, 44);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Vizualizar Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // dgVisualizar
            // 
            this.dgVisualizar.AllowUserToAddRows = false;
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
            this.Codigo_Usuario,
            this.NomeUsuario,
            this.Email,
            this.NomePerfil});
            this.dgVisualizar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVisualizar.Location = new System.Drawing.Point(54, 106);
            this.dgVisualizar.MultiSelect = false;
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.ReadOnly = true;
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(378, 202);
            this.dgVisualizar.TabIndex = 3;
            // 
            // Codigo_Usuario
            // 
            this.Codigo_Usuario.DataPropertyName = "Codigo_Usuario";
            this.Codigo_Usuario.HeaderText = "Cod Usuário";
            this.Codigo_Usuario.Name = "Codigo_Usuario";
            this.Codigo_Usuario.ReadOnly = true;
            this.Codigo_Usuario.Width = 75;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.DataPropertyName = "NomeUsuario";
            this.NomeUsuario.HeaderText = "Nome do usuario";
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NomePerfil
            // 
            this.NomePerfil.DataPropertyName = "NomePerfil";
            this.NomePerfil.HeaderText = "Perfil";
            this.NomePerfil.Name = "NomePerfil";
            this.NomePerfil.ReadOnly = true;
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTecnicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnicos.ForeColor = System.Drawing.Color.White;
            this.btnTecnicos.Location = new System.Drawing.Point(54, 24);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(102, 44);
            this.btnTecnicos.TabIndex = 0;
            this.btnTecnicos.Text = "Vizualizar Tecnicos";
            this.btnTecnicos.UseVisualStyleBackColor = false;
            this.btnTecnicos.Click += new System.EventHandler(this.BtnTecnicos_Click);
            // 
            // btnAdms
            // 
            this.btnAdms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdms.ForeColor = System.Drawing.Color.White;
            this.btnAdms.Location = new System.Drawing.Point(330, 24);
            this.btnAdms.Name = "btnAdms";
            this.btnAdms.Size = new System.Drawing.Size(102, 44);
            this.btnAdms.TabIndex = 2;
            this.btnAdms.Text = " Visualizar Admin";
            this.btnAdms.UseVisualStyleBackColor = false;
            this.btnAdms.Click += new System.EventHandler(this.BtnAdms_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(459, 209);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 44);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(459, 128);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 44);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnTecnicos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdms);
            this.Controls.Add(this.dgVisualizar);
            this.Controls.Add(this.btnUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Editar";
            this.Text = "Configuração dos usuários";
            this.Load += new System.EventHandler(this.Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.Button btnTecnicos;
        private System.Windows.Forms.Button btnAdms;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePerfil;
    }
}