namespace Bizagi.ProjectPublish
{
    partial class ProjectPublish
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
            this.btnRecuperaCache = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbOutputlog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbProjeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecuperaCache
            // 
            this.btnRecuperaCache.Location = new System.Drawing.Point(15, 231);
            this.btnRecuperaCache.Name = "btnRecuperaCache";
            this.btnRecuperaCache.Size = new System.Drawing.Size(224, 23);
            this.btnRecuperaCache.TabIndex = 25;
            this.btnRecuperaCache.Text = "Recupera Ultimas Informações";
            this.btnRecuperaCache.UseVisualStyleBackColor = true;
            this.btnRecuperaCache.Click += new System.EventHandler(this.btnRecuperaCache_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(363, 306);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(224, 28);
            this.btnLimparCampos.TabIndex = 24;
            this.btnLimparCampos.Text = "Limpar campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ex.: GIGANTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Informe o nome do projeto BIZAGI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ex.: 192.168.20.3 ou SERVIDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Informe o nome do servidor ou IP.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Fechar Aplicação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFecharAplicacao_Click);
            // 
            // txbOutputlog
            // 
            this.txbOutputlog.Location = new System.Drawing.Point(252, 12);
            this.txbOutputlog.Multiline = true;
            this.txbOutputlog.Name = "txbOutputlog";
            this.txbOutputlog.ReadOnly = true;
            this.txbOutputlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbOutputlog.Size = new System.Drawing.Size(565, 280);
            this.txbOutputlog.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Projeto";
            // 
            // txbProjeto
            // 
            this.txbProjeto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbProjeto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txbProjeto.Location = new System.Drawing.Point(12, 119);
            this.txbProjeto.Name = "txbProjeto";
            this.txbProjeto.Size = new System.Drawing.Size(227, 20);
            this.txbProjeto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Servidor";
            // 
            // txbServidor
            // 
            this.txbServidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txbServidor.Location = new System.Drawing.Point(12, 38);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(227, 20);
            this.txbServidor.TabIndex = 14;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.Gray;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.ForeColor = System.Drawing.Color.Transparent;
            this.btnExecutar.Location = new System.Drawing.Point(15, 186);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(224, 39);
            this.btnExecutar.TabIndex = 13;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ProjectPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 347);
            this.Controls.Add(this.btnRecuperaCache);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbOutputlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbServidor);
            this.Controls.Add(this.btnExecutar);
            this.Name = "ProjectPublish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectPublish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecuperaCache;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbOutputlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Button btnExecutar;
    }
}