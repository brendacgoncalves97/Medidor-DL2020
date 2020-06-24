namespace Version_01___Windows_Forms.Forms
{
    partial class BackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUp));
            this.grpAutomatico = new System.Windows.Forms.GroupBox();
            this.chkAtivarBackup = new System.Windows.Forms.CheckBox();
            this.LocalizarCaminho = new System.Windows.Forms.Button();
            this.SalvarConfiguracaoBackup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CaminhoBackup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpBackupRestore = new System.Windows.Forms.GroupBox();
            this.btnRestaurarCopiaDeSeguranca = new System.Windows.Forms.Button();
            this.btnCopiaDeSeguranca = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpAutomatico.SuspendLayout();
            this.grpBackupRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAutomatico
            // 
            this.grpAutomatico.Controls.Add(this.chkAtivarBackup);
            this.grpAutomatico.Controls.Add(this.LocalizarCaminho);
            this.grpAutomatico.Controls.Add(this.SalvarConfiguracaoBackup);
            this.grpAutomatico.Controls.Add(this.label4);
            this.grpAutomatico.Controls.Add(this.label3);
            this.grpAutomatico.Controls.Add(this.CaminhoBackup);
            this.grpAutomatico.Controls.Add(this.label2);
            this.grpAutomatico.Controls.Add(this.cmbPeriodo);
            this.grpAutomatico.Controls.Add(this.label1);
            this.grpAutomatico.Location = new System.Drawing.Point(12, 137);
            this.grpAutomatico.Name = "grpAutomatico";
            this.grpAutomatico.Size = new System.Drawing.Size(328, 189);
            this.grpAutomatico.TabIndex = 12;
            this.grpAutomatico.TabStop = false;
            this.grpAutomatico.Text = "Backup Automático";
            // 
            // chkAtivarBackup
            // 
            this.chkAtivarBackup.AutoSize = true;
            this.chkAtivarBackup.Location = new System.Drawing.Point(30, 20);
            this.chkAtivarBackup.Name = "chkAtivarBackup";
            this.chkAtivarBackup.Size = new System.Drawing.Size(149, 17);
            this.chkAtivarBackup.TabIndex = 3;
            this.chkAtivarBackup.Text = "Ativar Backup Automático";
            this.chkAtivarBackup.UseVisualStyleBackColor = true;
            this.chkAtivarBackup.CheckedChanged += new System.EventHandler(this.chkAtivarBackup_CheckedChanged);
            // 
            // LocalizarCaminho
            // 
            this.LocalizarCaminho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LocalizarCaminho.Image = ((System.Drawing.Image)(resources.GetObject("LocalizarCaminho.Image")));
            this.LocalizarCaminho.Location = new System.Drawing.Point(296, 103);
            this.LocalizarCaminho.Name = "LocalizarCaminho";
            this.LocalizarCaminho.Size = new System.Drawing.Size(28, 20);
            this.LocalizarCaminho.TabIndex = 5;
            this.LocalizarCaminho.UseVisualStyleBackColor = true;
            this.LocalizarCaminho.Click += new System.EventHandler(this.LocalizarCaminho_Click);
            // 
            // SalvarConfiguracaoBackup
            // 
            this.SalvarConfiguracaoBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalvarConfiguracaoBackup.Location = new System.Drawing.Point(65, 159);
            this.SalvarConfiguracaoBackup.Name = "SalvarConfiguracaoBackup";
            this.SalvarConfiguracaoBackup.Size = new System.Drawing.Size(173, 23);
            this.SalvarConfiguracaoBackup.TabIndex = 6;
            this.SalvarConfiguracaoBackup.Text = "Salvar Configuração de Backup";
            this.SalvarConfiguracaoBackup.UseVisualStyleBackColor = true;
            this.SalvarConfiguracaoBackup.Click += new System.EventHandler(this.SalvarConfiguracaoBackup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "*O backup sempre é realizado no carregamento do DL2020";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Aconselha-se que sempre armazene o Backup em uma outra mídia.";
            // 
            // CaminhoBackup
            // 
            this.CaminhoBackup.Location = new System.Drawing.Point(27, 103);
            this.CaminhoBackup.Name = "CaminhoBackup";
            this.CaminhoBackup.Size = new System.Drawing.Size(269, 20);
            this.CaminhoBackup.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione a pasta de Destino:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Diariamente",
            "Semanalmente",
            "Mensalmente"});
            this.cmbPeriodo.Location = new System.Drawing.Point(129, 52);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriodo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o Período:";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(265, 332);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpBackupRestore
            // 
            this.grpBackupRestore.Controls.Add(this.btnRestaurarCopiaDeSeguranca);
            this.grpBackupRestore.Controls.Add(this.btnCopiaDeSeguranca);
            this.grpBackupRestore.Location = new System.Drawing.Point(12, 12);
            this.grpBackupRestore.Name = "grpBackupRestore";
            this.grpBackupRestore.Size = new System.Drawing.Size(328, 119);
            this.grpBackupRestore.TabIndex = 11;
            this.grpBackupRestore.TabStop = false;
            this.grpBackupRestore.Text = "Backup e Restore da Base de Dados";
            // 
            // btnRestaurarCopiaDeSeguranca
            // 
            this.btnRestaurarCopiaDeSeguranca.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurarCopiaDeSeguranca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestaurarCopiaDeSeguranca.Location = new System.Drawing.Point(175, 29);
            this.btnRestaurarCopiaDeSeguranca.Name = "btnRestaurarCopiaDeSeguranca";
            this.btnRestaurarCopiaDeSeguranca.Size = new System.Drawing.Size(122, 78);
            this.btnRestaurarCopiaDeSeguranca.TabIndex = 2;
            this.btnRestaurarCopiaDeSeguranca.Text = "Restaurar Cópia de Segurança";
            this.btnRestaurarCopiaDeSeguranca.UseVisualStyleBackColor = false;
            this.btnRestaurarCopiaDeSeguranca.Click += new System.EventHandler(this.btnRestaurarCopiaDeSeguranca_Click);
            // 
            // btnCopiaDeSeguranca
            // 
            this.btnCopiaDeSeguranca.BackColor = System.Drawing.Color.Transparent;
            this.btnCopiaDeSeguranca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopiaDeSeguranca.Location = new System.Drawing.Point(16, 29);
            this.btnCopiaDeSeguranca.Name = "btnCopiaDeSeguranca";
            this.btnCopiaDeSeguranca.Size = new System.Drawing.Size(122, 78);
            this.btnCopiaDeSeguranca.TabIndex = 1;
            this.btnCopiaDeSeguranca.Text = "Gerar Cópia de Segurança";
            this.btnCopiaDeSeguranca.UseVisualStyleBackColor = false;
            this.btnCopiaDeSeguranca.Click += new System.EventHandler(this.btnCopiaDeSeguranca_Click);
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 364);
            this.Controls.Add(this.grpAutomatico);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpBackupRestore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BackUp";
            this.Load += new System.EventHandler(this.BackUp_Load);
            this.grpAutomatico.ResumeLayout(false);
            this.grpAutomatico.PerformLayout();
            this.grpBackupRestore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAutomatico;
        private System.Windows.Forms.CheckBox chkAtivarBackup;
        private System.Windows.Forms.Button LocalizarCaminho;
        private System.Windows.Forms.Button SalvarConfiguracaoBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CaminhoBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpBackupRestore;
        private System.Windows.Forms.Button btnRestaurarCopiaDeSeguranca;
        private System.Windows.Forms.Button btnCopiaDeSeguranca;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}