namespace Bizagi.ProjectPublish
{
    partial class NewProjectPublish
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.dataGridViewConfiguracao = new System.Windows.Forms.DataGridView();
            this.Servidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirPadrao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvarAmbiente = new System.Windows.Forms.Button();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.txbProjeto = new System.Windows.Forms.TextBox();
            this.contextMenuStripDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMessage = new System.Windows.Forms.NotifyIcon(this.components);
            this.rbPublicacaoTotal = new System.Windows.Forms.RadioButton();
            this.rbLimpezaTotal = new System.Windows.Forms.RadioButton();
            this.rbLimpezaCache = new System.Windows.Forms.RadioButton();
            this.gbTipoPublicacao = new System.Windows.Forms.GroupBox();
            this.txbExplicacaoTipo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPagePublicacao = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbOutputlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbListaServidorProjeto = new System.Windows.Forms.ComboBox();
            this.tbPageConfiguracao = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiretorioPadrao = new System.Windows.Forms.Label();
            this.txbDirPadrao = new System.Windows.Forms.TextBox();
            this.btnFecharApp = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfiguracao)).BeginInit();
            this.contextMenuStripDataGrid.SuspendLayout();
            this.gbTipoPublicacao.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPagePublicacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbPageConfiguracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(962, 101);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(195, 40);
            this.btnLimparCampos.TabIndex = 27;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.Location = new System.Drawing.Point(13, 13);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(54, 13);
            this.lblServidor.TabIndex = 24;
            this.lblServidor.Text = "Servidor";
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Location = new System.Drawing.Point(423, 13);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(47, 13);
            this.lblProjeto.TabIndex = 25;
            this.lblProjeto.Text = "Projeto";
            // 
            // dataGridViewConfiguracao
            // 
            this.dataGridViewConfiguracao.AllowUserToAddRows = false;
            this.dataGridViewConfiguracao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfiguracao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Servidor,
            this.Projeto,
            this.DirPadrao});
            this.dataGridViewConfiguracao.Location = new System.Drawing.Point(13, 147);
            this.dataGridViewConfiguracao.Name = "dataGridViewConfiguracao";
            this.dataGridViewConfiguracao.ReadOnly = true;
            this.dataGridViewConfiguracao.Size = new System.Drawing.Size(1150, 365);
            this.dataGridViewConfiguracao.TabIndex = 21;
            this.dataGridViewConfiguracao.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewConfiguracao_CellMouseUp);
            // 
            // Servidor
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Servidor.DefaultCellStyle = dataGridViewCellStyle5;
            this.Servidor.FillWeight = 189.6907F;
            this.Servidor.HeaderText = "Servidor";
            this.Servidor.MinimumWidth = 300;
            this.Servidor.Name = "Servidor";
            this.Servidor.ReadOnly = true;
            this.Servidor.Width = 300;
            // 
            // Projeto
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Projeto.DefaultCellStyle = dataGridViewCellStyle6;
            this.Projeto.FillWeight = 10.30928F;
            this.Projeto.HeaderText = "Projeto";
            this.Projeto.MinimumWidth = 250;
            this.Projeto.Name = "Projeto";
            this.Projeto.ReadOnly = true;
            this.Projeto.Width = 250;
            // 
            // DirPadrao
            // 
            this.DirPadrao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirPadrao.HeaderText = "Diretório Padrão";
            this.DirPadrao.MinimumWidth = 250;
            this.DirPadrao.Name = "DirPadrao";
            this.DirPadrao.ReadOnly = true;
            // 
            // btnSalvarAmbiente
            // 
            this.btnSalvarAmbiente.Location = new System.Drawing.Point(761, 101);
            this.btnSalvarAmbiente.Name = "btnSalvarAmbiente";
            this.btnSalvarAmbiente.Size = new System.Drawing.Size(195, 40);
            this.btnSalvarAmbiente.TabIndex = 26;
            this.btnSalvarAmbiente.Text = "Salvar Ambiente";
            this.btnSalvarAmbiente.UseVisualStyleBackColor = true;
            this.btnSalvarAmbiente.Click += new System.EventHandler(this.btnSalvarAmbiente_Click);
            // 
            // txbServidor
            // 
            this.txbServidor.Location = new System.Drawing.Point(13, 29);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(398, 20);
            this.txbServidor.TabIndex = 22;
            // 
            // txbProjeto
            // 
            this.txbProjeto.Location = new System.Drawing.Point(423, 29);
            this.txbProjeto.Name = "txbProjeto";
            this.txbProjeto.Size = new System.Drawing.Size(276, 20);
            this.txbProjeto.TabIndex = 23;
            this.txbProjeto.Leave += new System.EventHandler(this.txbProjeto_Leave);
            // 
            // contextMenuStripDataGrid
            // 
            this.contextMenuStripDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.contextMenuStripDataGrid.Name = "contextMenuStripDataGrid";
            this.contextMenuStripDataGrid.Size = new System.Drawing.Size(109, 48);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // notifyIconMessage
            // 
            this.notifyIconMessage.Text = "notifyIconMessage";
            this.notifyIconMessage.Visible = true;
            // 
            // rbPublicacaoTotal
            // 
            this.rbPublicacaoTotal.AutoSize = true;
            this.rbPublicacaoTotal.Enabled = false;
            this.rbPublicacaoTotal.Location = new System.Drawing.Point(16, 69);
            this.rbPublicacaoTotal.Name = "rbPublicacaoTotal";
            this.rbPublicacaoTotal.Size = new System.Drawing.Size(216, 17);
            this.rbPublicacaoTotal.TabIndex = 1;
            this.rbPublicacaoTotal.Text = "Limpeza de Cache, Pastas + Publicação";
            this.rbPublicacaoTotal.UseVisualStyleBackColor = true;
            this.rbPublicacaoTotal.CheckedChanged += new System.EventHandler(this.rbTipoPublicacao_CheckedChanged);
            // 
            // rbLimpezaTotal
            // 
            this.rbLimpezaTotal.AutoSize = true;
            this.rbLimpezaTotal.Location = new System.Drawing.Point(16, 46);
            this.rbLimpezaTotal.Name = "rbLimpezaTotal";
            this.rbLimpezaTotal.Size = new System.Drawing.Size(157, 17);
            this.rbLimpezaTotal.TabIndex = 2;
            this.rbLimpezaTotal.Text = "Limpeza de Cache e Pastas";
            this.rbLimpezaTotal.UseVisualStyleBackColor = true;
            this.rbLimpezaTotal.CheckedChanged += new System.EventHandler(this.rbTipoPublicacao_CheckedChanged);
            // 
            // rbLimpezaCache
            // 
            this.rbLimpezaCache.AutoSize = true;
            this.rbLimpezaCache.Checked = true;
            this.rbLimpezaCache.Location = new System.Drawing.Point(16, 23);
            this.rbLimpezaCache.Name = "rbLimpezaCache";
            this.rbLimpezaCache.Size = new System.Drawing.Size(113, 17);
            this.rbLimpezaCache.TabIndex = 3;
            this.rbLimpezaCache.TabStop = true;
            this.rbLimpezaCache.Text = "Limpeza de Cache";
            this.rbLimpezaCache.UseVisualStyleBackColor = true;
            this.rbLimpezaCache.CheckedChanged += new System.EventHandler(this.rbTipoPublicacao_CheckedChanged);
            // 
            // gbTipoPublicacao
            // 
            this.gbTipoPublicacao.Controls.Add(this.txbExplicacaoTipo);
            this.gbTipoPublicacao.Controls.Add(this.rbLimpezaCache);
            this.gbTipoPublicacao.Controls.Add(this.rbPublicacaoTotal);
            this.gbTipoPublicacao.Controls.Add(this.rbLimpezaTotal);
            this.gbTipoPublicacao.Location = new System.Drawing.Point(7, 9);
            this.gbTipoPublicacao.Name = "gbTipoPublicacao";
            this.gbTipoPublicacao.Size = new System.Drawing.Size(1158, 100);
            this.gbTipoPublicacao.TabIndex = 4;
            this.gbTipoPublicacao.TabStop = false;
            this.gbTipoPublicacao.Text = "Tipo";
            // 
            // txbExplicacaoTipo
            // 
            this.txbExplicacaoTipo.BackColor = System.Drawing.SystemColors.Window;
            this.txbExplicacaoTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbExplicacaoTipo.Location = new System.Drawing.Point(254, 18);
            this.txbExplicacaoTipo.Multiline = true;
            this.txbExplicacaoTipo.Name = "txbExplicacaoTipo";
            this.txbExplicacaoTipo.ReadOnly = true;
            this.txbExplicacaoTipo.Size = new System.Drawing.Size(876, 68);
            this.txbExplicacaoTipo.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPagePublicacao);
            this.tabControl1.Controls.Add(this.tbPageConfiguracao);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 559);
            this.tabControl1.TabIndex = 5;
            // 
            // tbPagePublicacao
            // 
            this.tbPagePublicacao.Controls.Add(this.groupBox1);
            this.tbPagePublicacao.Controls.Add(this.gbTipoPublicacao);
            this.tbPagePublicacao.Location = new System.Drawing.Point(4, 22);
            this.tbPagePublicacao.Name = "tbPagePublicacao";
            this.tbPagePublicacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagePublicacao.Size = new System.Drawing.Size(1176, 533);
            this.tbPagePublicacao.TabIndex = 0;
            this.tbPagePublicacao.Text = "Publicação";
            this.tbPagePublicacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbOutputlog);
            this.groupBox1.Controls.Add(this.btnExecutar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbListaServidorProjeto);
            this.groupBox1.Location = new System.Drawing.Point(7, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 404);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txbOutputlog
            // 
            this.txbOutputlog.Location = new System.Drawing.Point(555, 21);
            this.txbOutputlog.Multiline = true;
            this.txbOutputlog.Name = "txbOutputlog";
            this.txbOutputlog.ReadOnly = true;
            this.txbOutputlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbOutputlog.Size = new System.Drawing.Size(590, 366);
            this.txbOutputlog.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Servidor e Projeto";
            // 
            // cbListaServidorProjeto
            // 
            this.cbListaServidorProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaServidorProjeto.FormattingEnabled = true;
            this.cbListaServidorProjeto.Location = new System.Drawing.Point(27, 43);
            this.cbListaServidorProjeto.Name = "cbListaServidorProjeto";
            this.cbListaServidorProjeto.Size = new System.Drawing.Size(496, 21);
            this.cbListaServidorProjeto.TabIndex = 5;
            // 
            // tbPageConfiguracao
            // 
            this.tbPageConfiguracao.Controls.Add(this.label2);
            this.tbPageConfiguracao.Controls.Add(this.label7);
            this.tbPageConfiguracao.Controls.Add(this.label5);
            this.tbPageConfiguracao.Controls.Add(this.label6);
            this.tbPageConfiguracao.Controls.Add(this.label4);
            this.tbPageConfiguracao.Controls.Add(this.label3);
            this.tbPageConfiguracao.Controls.Add(this.lblDiretorioPadrao);
            this.tbPageConfiguracao.Controls.Add(this.txbDirPadrao);
            this.tbPageConfiguracao.Controls.Add(this.btnLimparCampos);
            this.tbPageConfiguracao.Controls.Add(this.txbServidor);
            this.tbPageConfiguracao.Controls.Add(this.lblServidor);
            this.tbPageConfiguracao.Controls.Add(this.lblProjeto);
            this.tbPageConfiguracao.Controls.Add(this.txbProjeto);
            this.tbPageConfiguracao.Controls.Add(this.dataGridViewConfiguracao);
            this.tbPageConfiguracao.Controls.Add(this.btnSalvarAmbiente);
            this.tbPageConfiguracao.Location = new System.Drawing.Point(4, 22);
            this.tbPageConfiguracao.Name = "tbPageConfiguracao";
            this.tbPageConfiguracao.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConfiguracao.Size = new System.Drawing.Size(1176, 533);
            this.tbPageConfiguracao.TabIndex = 1;
            this.tbPageConfiguracao.Text = "Configuração de Ambientes";
            this.tbPageConfiguracao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(708, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ex.: C:\\Bizagi\\Enteprise\\Projects\\Giganto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(708, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Informe o diretório padrão do projeto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(420, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ex.: GIGANTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Informe o nome do projeto BIZAGI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ex.: 192.168.20.3 ou SERVIDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Informe o nome do servidor ou IP.";
            // 
            // lblDiretorioPadrao
            // 
            this.lblDiretorioPadrao.AutoSize = true;
            this.lblDiretorioPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretorioPadrao.Location = new System.Drawing.Point(711, 13);
            this.lblDiretorioPadrao.Name = "lblDiretorioPadrao";
            this.lblDiretorioPadrao.Size = new System.Drawing.Size(99, 13);
            this.lblDiretorioPadrao.TabIndex = 29;
            this.lblDiretorioPadrao.Text = "Diretório Padrão";
            // 
            // txbDirPadrao
            // 
            this.txbDirPadrao.Location = new System.Drawing.Point(711, 29);
            this.txbDirPadrao.Name = "txbDirPadrao";
            this.txbDirPadrao.Size = new System.Drawing.Size(446, 20);
            this.txbDirPadrao.TabIndex = 28;
            // 
            // btnFecharApp
            // 
            this.btnFecharApp.Location = new System.Drawing.Point(968, 577);
            this.btnFecharApp.Name = "btnFecharApp";
            this.btnFecharApp.Size = new System.Drawing.Size(224, 28);
            this.btnFecharApp.TabIndex = 21;
            this.btnFecharApp.Text = "Fechar Aplicação";
            this.btnFecharApp.UseVisualStyleBackColor = true;
            this.btnFecharApp.Click += new System.EventHandler(this.btnFecharApp_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.Gray;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.ForeColor = System.Drawing.Color.Transparent;
            this.btnExecutar.Location = new System.Drawing.Point(299, 348);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(224, 39);
            this.btnExecutar.TabIndex = 20;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // NewProjectPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 613);
            this.Controls.Add(this.btnFecharApp);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProjectPublish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicação de Projetos BIZAGI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfiguracao)).EndInit();
            this.contextMenuStripDataGrid.ResumeLayout(false);
            this.gbTipoPublicacao.ResumeLayout(false);
            this.gbTipoPublicacao.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbPagePublicacao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbPageConfiguracao.ResumeLayout(false);
            this.tbPageConfiguracao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.DataGridView dataGridViewConfiguracao;
        private System.Windows.Forms.Button btnSalvarAmbiente;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.TextBox txbProjeto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGrid;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconMessage;
        private System.Windows.Forms.RadioButton rbLimpezaCache;
        private System.Windows.Forms.RadioButton rbLimpezaTotal;
        private System.Windows.Forms.RadioButton rbPublicacaoTotal;
        private System.Windows.Forms.GroupBox gbTipoPublicacao;
        private System.Windows.Forms.TextBox txbExplicacaoTipo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPagePublicacao;
        private System.Windows.Forms.TabPage tbPageConfiguracao;
        private System.Windows.Forms.Label lblDiretorioPadrao;
        private System.Windows.Forms.TextBox txbDirPadrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirPadrao;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbListaServidorProjeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOutputlog;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnFecharApp;
    }
}