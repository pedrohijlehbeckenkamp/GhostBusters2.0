namespace GhostBusters_Forms.Adm
{
    partial class TelaPrincipalAdm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.linkLEdit = new System.Windows.Forms.LinkLabel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.Codigochamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Chamado_finalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.butAddTecnico = new System.Windows.Forms.Button();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.maskedCod = new System.Windows.Forms.MaskedTextBox();
            this.cbGeral = new System.Windows.Forms.ComboBox();
            this.tbConteudo = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.btnAlteraStatus = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTicket.ForeColor = System.Drawing.Color.White;
            this.btnNewTicket.Location = new System.Drawing.Point(415, 147);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(108, 44);
            this.btnNewTicket.TabIndex = 3;
            this.btnNewTicket.Text = "Abrir ticket";
            this.btnNewTicket.UseVisualStyleBackColor = false;
            this.btnNewTicket.Click += new System.EventHandler(this.BtnNewTicket_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(643, 145);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 44);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir ticket";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(725, 11);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(125, 44);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(505, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(171, 141);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(150, 44);
            this.btnCadastrarUsuario.TabIndex = 0;
            this.btnCadastrarUsuario.Text = "Cadastro Usuario";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.BtnCadastrarUsuario_Click);
            // 
            // linkLEdit
            // 
            this.linkLEdit.AutoSize = true;
            this.linkLEdit.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLEdit.LinkColor = System.Drawing.Color.Navy;
            this.linkLEdit.Location = new System.Drawing.Point(34, 141);
            this.linkLEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLEdit.Name = "linkLEdit";
            this.linkLEdit.Size = new System.Drawing.Size(65, 15);
            this.linkLEdit.TabIndex = 5;
            this.linkLEdit.TabStop = true;
            this.linkLEdit.Text = "Alterar foto";
            this.linkLEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLEdit_LinkClicked);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(178, 59);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblNomeAd
            // 
            this.lblNomeAd.AutoSize = true;
            this.lblNomeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAd.ForeColor = System.Drawing.Color.Black;
            this.lblNomeAd.Location = new System.Drawing.Point(178, 23);
            this.lblNomeAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeAd.Name = "lblNomeAd";
            this.lblNomeAd.Size = new System.Drawing.Size(56, 20);
            this.lblNomeAd.TabIndex = 42;
            this.lblNomeAd.Text = "NOME";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 44;
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
            this.Data_Chamado,
            this.Titulo,
            this.NomeTech,
            this.Data_Chamado_finalizado});
            this.dgVisualizar.EnableHeadersVisualStyles = false;
            this.dgVisualizar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgVisualizar.Location = new System.Drawing.Point(22, 218);
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.ReadOnly = true;
            this.dgVisualizar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisualizar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgVisualizar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(677, 220);
            this.dgVisualizar.TabIndex = 11;
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
            // Data_Chamado
            // 
            this.Data_Chamado.DataPropertyName = "Data_Chamado";
            this.Data_Chamado.HeaderText = "Data Chamado";
            this.Data_Chamado.MinimumWidth = 6;
            this.Data_Chamado.Name = "Data_Chamado";
            this.Data_Chamado.ReadOnly = true;
            this.Data_Chamado.Width = 125;
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
            this.linkPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPerfil.LinkColor = System.Drawing.Color.Navy;
            this.linkPerfil.Location = new System.Drawing.Point(34, 162);
            this.linkPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(90, 15);
            this.linkPerfil.TabIndex = 6;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Visualizar perfil";
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPerfil_LinkClicked);
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPerfil.Location = new System.Drawing.Point(36, 11);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(129, 128);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 26;
            this.pbPerfil.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(529, 145);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 44);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar ticket";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // butAddTecnico
            // 
            this.butAddTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butAddTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddTecnico.ForeColor = System.Drawing.Color.White;
            this.butAddTecnico.Location = new System.Drawing.Point(415, 95);
            this.butAddTecnico.Name = "butAddTecnico";
            this.butAddTecnico.Size = new System.Drawing.Size(191, 44);
            this.butAddTecnico.TabIndex = 7;
            this.butAddTecnico.Text = "Adicionar Tecnico ticket";
            this.butAddTecnico.UseVisualStyleBackColor = false;
            this.butAddTecnico.Click += new System.EventHandler(this.ButAddTecnico_Click);
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Items.AddRange(new object[] {
            "Todos",
            "Código ticket",
            "Conteúdo",
            "Data",
            "Status",
            "Usuário",
            "Técnico",
            "Categoria"});
            this.cbOrderBy.Location = new System.Drawing.Point(705, 276);
            this.cbOrderBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(142, 23);
            this.cbOrderBy.TabIndex = 13;
            this.cbOrderBy.SelectedIndexChanged += new System.EventHandler(this.CbOrderBy_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(738, 218);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(76, 44);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // maskedCod
            // 
            this.maskedCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCod.Location = new System.Drawing.Point(757, 304);
            this.maskedCod.Mask = "00000";
            this.maskedCod.Name = "maskedCod";
            this.maskedCod.Size = new System.Drawing.Size(36, 21);
            this.maskedCod.TabIndex = 14;
            this.maskedCod.ValidatingType = typeof(int);
            // 
            // cbGeral
            // 
            this.cbGeral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeral.FormattingEnabled = true;
            this.cbGeral.Location = new System.Drawing.Point(705, 304);
            this.cbGeral.Name = "cbGeral";
            this.cbGeral.Size = new System.Drawing.Size(142, 23);
            this.cbGeral.TabIndex = 16;
            this.cbGeral.SelectedIndexChanged += new System.EventHandler(this.CbStatus_SelectedIndexChanged);
            // 
            // tbConteudo
            // 
            this.tbConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConteudo.Location = new System.Drawing.Point(705, 304);
            this.tbConteudo.Multiline = true;
            this.tbConteudo.Name = "tbConteudo";
            this.tbConteudo.Size = new System.Drawing.Size(142, 84);
            this.tbConteudo.TabIndex = 17;
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "yyyy - MM -dd";
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(705, 302);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(142, 21);
            this.dtData.TabIndex = 15;
            this.dtData.Value = new System.DateTime(2019, 7, 25, 19, 11, 18, 0);
            // 
            // btnAlteraStatus
            // 
            this.btnAlteraStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlteraStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraStatus.ForeColor = System.Drawing.Color.White;
            this.btnAlteraStatus.Location = new System.Drawing.Point(612, 95);
            this.btnAlteraStatus.Name = "btnAlteraStatus";
            this.btnAlteraStatus.Size = new System.Drawing.Size(139, 44);
            this.btnAlteraStatus.TabIndex = 4;
            this.btnAlteraStatus.Text = "Alterar status";
            this.btnAlteraStatus.UseVisualStyleBackColor = false;
            this.btnAlteraStatus.Click += new System.EventHandler(this.BtnAlteraStatus_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(171, 95);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(150, 44);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Dois Clicks para ver o Log de Movimentação";
            // 
            // TelaPrincipalAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnAlteraStatus);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.tbConteudo);
            this.Controls.Add(this.cbGeral);
            this.Controls.Add(this.maskedCod);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbOrderBy);
            this.Controls.Add(this.butAddTecnico);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.linkPerfil);
            this.Controls.Add(this.dgVisualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeAd);
            this.Controls.Add(this.linkLEdit);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.btnNewTicket);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaPrincipalAdm";
            this.Text = "Perfil do adm";
            this.Load += new System.EventHandler(this.TelaPrincipalAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.LinkLabel linkLEdit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeAd;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_chamado;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button butAddTecnico;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.MaskedTextBox maskedCod;
        private System.Windows.Forms.ComboBox cbGeral;
        private System.Windows.Forms.TextBox tbConteudo;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button btnAlteraStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigochamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Chamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeTech;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Nomestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Chamado_finalizado;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label2;
    }
}