namespace GhostBusters_Forms.Usuário_Comum
{
    partial class InicUsuarioComum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picBase64 = new System.Windows.Forms.PictureBox();
            this.linkLEdit = new System.Windows.Forms.LinkLabel();
            this.btnAdcTicket = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNomeUC = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.Codigochamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Chamado_finalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tbConteudo = new System.Windows.Forms.TextBox();
            this.cbGeral = new System.Windows.Forms.ComboBox();
            this.maskedCod = new System.Windows.Forms.MaskedTextBox();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.BtAlterarStatus = new System.Windows.Forms.Button();
            this.btVisChamado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBase64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // picBase64
            // 
            this.picBase64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBase64.Location = new System.Drawing.Point(64, 13);
            this.picBase64.Name = "picBase64";
            this.picBase64.Size = new System.Drawing.Size(129, 128);
            this.picBase64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBase64.TabIndex = 34;
            this.picBase64.TabStop = false;
            // 
            // linkLEdit
            // 
            this.linkLEdit.AutoSize = true;
            this.linkLEdit.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLEdit.LinkColor = System.Drawing.Color.Navy;
            this.linkLEdit.Location = new System.Drawing.Point(62, 144);
            this.linkLEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLEdit.Name = "linkLEdit";
            this.linkLEdit.Size = new System.Drawing.Size(58, 13);
            this.linkLEdit.TabIndex = 35;
            this.linkLEdit.TabStop = true;
            this.linkLEdit.Text = "Alterar foto";
            this.linkLEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLEdit_LinkClicked);
            // 
            // btnAdcTicket
            // 
            this.btnAdcTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdcTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdcTicket.ForeColor = System.Drawing.Color.White;
            this.btnAdcTicket.Location = new System.Drawing.Point(207, 102);
            this.btnAdcTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdcTicket.Name = "btnAdcTicket";
            this.btnAdcTicket.Size = new System.Drawing.Size(141, 39);
            this.btnAdcTicket.TabIndex = 36;
            this.btnAdcTicket.Text = "Adicionar Ticket";
            this.btnAdcTicket.UseVisualStyleBackColor = false;
            this.btnAdcTicket.Click += new System.EventHandler(this.BtnAdcTicket_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(352, 102);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 39);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "Editar Ticket";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblNomeUC
            // 
            this.lblNomeUC.AutoSize = true;
            this.lblNomeUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUC.Location = new System.Drawing.Point(203, 26);
            this.lblNomeUC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeUC.Name = "lblNomeUC";
            this.lblNomeUC.Size = new System.Drawing.Size(56, 20);
            this.lblNomeUC.TabIndex = 39;
            this.lblNomeUC.Text = "NOME";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(608, 7);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "Date";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(203, 57);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "EMAIL";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Data e hora do acesso:";
            // 
            // dgVisualizar
            // 
            this.dgVisualizar.AllowUserToAddRows = false;
            this.dgVisualizar.AllowUserToDeleteRows = false;
            this.dgVisualizar.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgVisualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisualizar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigochamado,
            this.NomeUsuario,
            this.NomePerfil,
            this.Titulo,
            this.NomeTech,
            this.nomeCategoria,
            this.Nomestatus,
            this.Data_Chamado,
            this.Data_Chamado_finalizado});
            this.dgVisualizar.EnableHeadersVisualStyles = false;
            this.dgVisualizar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgVisualizar.Location = new System.Drawing.Point(12, 192);
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.ReadOnly = true;
            this.dgVisualizar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisualizar.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgVisualizar.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(557, 220);
            this.dgVisualizar.TabIndex = 46;
            this.dgVisualizar.DoubleClick += new System.EventHandler(this.DgVisualizar_DoubleClick);
            // 
            // Codigochamado
            // 
            this.Codigochamado.DataPropertyName = "Codigo_chamado";
            this.Codigochamado.HeaderText = "Codigo chamado";
            this.Codigochamado.MinimumWidth = 6;
            this.Codigochamado.Name = "Codigochamado";
            this.Codigochamado.ReadOnly = true;
            this.Codigochamado.Width = 125;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.DataPropertyName = "NomeUsuario2";
            this.NomeUsuario.HeaderText = "Usuario";
            this.NomeUsuario.MinimumWidth = 6;
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.ReadOnly = true;
            this.NomeUsuario.Width = 125;
            // 
            // NomePerfil
            // 
            this.NomePerfil.DataPropertyName = "NomePerfil";
            this.NomePerfil.HeaderText = "Nome Perfil";
            this.NomePerfil.MinimumWidth = 6;
            this.NomePerfil.Name = "NomePerfil";
            this.NomePerfil.ReadOnly = true;
            this.NomePerfil.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 125;
            // 
            // NomeTech
            // 
            this.NomeTech.DataPropertyName = "NomeTech";
            this.NomeTech.HeaderText = "Tecnico";
            this.NomeTech.MinimumWidth = 6;
            this.NomeTech.Name = "NomeTech";
            this.NomeTech.ReadOnly = true;
            this.NomeTech.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NomeTech.Width = 125;
            // 
            // nomeCategoria
            // 
            this.nomeCategoria.DataPropertyName = "nomeCategoria";
            this.nomeCategoria.HeaderText = "Categoria";
            this.nomeCategoria.MinimumWidth = 6;
            this.nomeCategoria.Name = "nomeCategoria";
            this.nomeCategoria.ReadOnly = true;
            this.nomeCategoria.Width = 125;
            // 
            // Nomestatus
            // 
            this.Nomestatus.DataPropertyName = "Nomestatus";
            this.Nomestatus.HeaderText = "Status";
            this.Nomestatus.MinimumWidth = 6;
            this.Nomestatus.Name = "Nomestatus";
            this.Nomestatus.ReadOnly = true;
            this.Nomestatus.Width = 125;
            // 
            // Data_Chamado
            // 
            this.Data_Chamado.DataPropertyName = "Data_Chamado";
            this.Data_Chamado.HeaderText = "Data Chamado";
            this.Data_Chamado.MinimumWidth = 6;
            this.Data_Chamado.Name = "Data_Chamado";
            this.Data_Chamado.ReadOnly = true;
            this.Data_Chamado.Width = 125;
            // 
            // Data_Chamado_finalizado
            // 
            this.Data_Chamado_finalizado.DataPropertyName = "Data_Chamado_finalizado";
            this.Data_Chamado_finalizado.HeaderText = "Finalizado ";
            this.Data_Chamado_finalizado.MinimumWidth = 6;
            this.Data_Chamado_finalizado.Name = "Data_Chamado_finalizado";
            this.Data_Chamado_finalizado.ReadOnly = true;
            this.Data_Chamado_finalizado.Width = 125;
            // 
            // linkPerfil
            // 
            this.linkPerfil.AutoSize = true;
            this.linkPerfil.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkPerfil.LinkColor = System.Drawing.Color.Navy;
            this.linkPerfil.Location = new System.Drawing.Point(62, 165);
            this.linkPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(76, 13);
            this.linkPerfil.TabIndex = 47;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Visualizar perfil";
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPerfil_LinkClicked);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(637, 168);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(76, 44);
            this.btnOrder.TabIndex = 61;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // tbConteudo
            // 
            this.tbConteudo.Location = new System.Drawing.Point(602, 262);
            this.tbConteudo.Multiline = true;
            this.tbConteudo.Name = "tbConteudo";
            this.tbConteudo.Size = new System.Drawing.Size(142, 84);
            this.tbConteudo.TabIndex = 65;
            // 
            // cbGeral
            // 
            this.cbGeral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeral.FormattingEnabled = true;
            this.cbGeral.Location = new System.Drawing.Point(602, 262);
            this.cbGeral.Name = "cbGeral";
            this.cbGeral.Size = new System.Drawing.Size(142, 21);
            this.cbGeral.TabIndex = 64;
            // 
            // maskedCod
            // 
            this.maskedCod.Location = new System.Drawing.Point(659, 262);
            this.maskedCod.Mask = "00000";
            this.maskedCod.Name = "maskedCod";
            this.maskedCod.Size = new System.Drawing.Size(36, 20);
            this.maskedCod.TabIndex = 63;
            this.maskedCod.ValidatingType = typeof(int);
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Items.AddRange(new object[] {
            "Todos",
            "Código ticket",
            "Conteúdo",
            "Data",
            "Status"});
            this.cbOrderBy.Location = new System.Drawing.Point(602, 218);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(142, 21);
            this.cbOrderBy.TabIndex = 62;
            this.cbOrderBy.SelectedIndexChanged += new System.EventHandler(this.CbOrderBy_SelectedIndexChanged);
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "yyyy - MM -dd";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(602, 259);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(142, 20);
            this.dtData.TabIndex = 69;
            this.dtData.Value = new System.DateTime(2019, 7, 25, 19, 11, 18, 0);
            // 
            // BtAlterarStatus
            // 
            this.BtAlterarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtAlterarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAlterarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtAlterarStatus.ForeColor = System.Drawing.Color.White;
            this.BtAlterarStatus.Location = new System.Drawing.Point(471, 102);
            this.BtAlterarStatus.Margin = new System.Windows.Forms.Padding(2);
            this.BtAlterarStatus.Name = "BtAlterarStatus";
            this.BtAlterarStatus.Size = new System.Drawing.Size(141, 39);
            this.BtAlterarStatus.TabIndex = 70;
            this.BtAlterarStatus.Text = "Alterar Status";
            this.BtAlterarStatus.UseVisualStyleBackColor = false;
            this.BtAlterarStatus.Click += new System.EventHandler(this.BtAlterarStatus_Click);
            // 
            // btVisChamado
            // 
            this.btVisChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVisChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVisChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btVisChamado.ForeColor = System.Drawing.Color.White;
            this.btVisChamado.Location = new System.Drawing.Point(616, 101);
            this.btVisChamado.Margin = new System.Windows.Forms.Padding(2);
            this.btVisChamado.Name = "btVisChamado";
            this.btVisChamado.Size = new System.Drawing.Size(159, 40);
            this.btVisChamado.TabIndex = 75;
            this.btVisChamado.Text = "Visualizar Chamado";
            this.btVisChamado.UseVisualStyleBackColor = false;
            this.btVisChamado.Click += new System.EventHandler(this.BtVisChamado_Click);
            // 
            // InicUsuarioComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btVisChamado);
            this.Controls.Add(this.BtAlterarStatus);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.tbConteudo);
            this.Controls.Add(this.cbGeral);
            this.Controls.Add(this.maskedCod);
            this.Controls.Add(this.cbOrderBy);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.linkPerfil);
            this.Controls.Add(this.dgVisualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNomeUC);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdcTicket);
            this.Controls.Add(this.linkLEdit);
            this.Controls.Add(this.picBase64);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InicUsuarioComum";
            this.Text = "Perfil do usuário";
            this.Load += new System.EventHandler(this.TelaUsuarioComum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBase64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBase64;
        private System.Windows.Forms.LinkLabel linkLEdit;
        private System.Windows.Forms.Button btnAdcTicket;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblNomeUC;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigochamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Chamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Chamado_finalizado;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbConteudo;
        private System.Windows.Forms.ComboBox cbGeral;
        private System.Windows.Forms.MaskedTextBox maskedCod;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button BtAlterarStatus;
        private System.Windows.Forms.Button btVisChamado;
    }
}