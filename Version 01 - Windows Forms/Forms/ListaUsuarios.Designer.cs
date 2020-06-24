namespace Version_01___Windows_Forms.Forms
{
    partial class ListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuarios));
            this.btSair = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbCanAdd = new System.Windows.Forms.CheckBox();
            this.cbCanDelete = new System.Windows.Forms.CheckBox();
            this.cbCanAlter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(12, 115);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(105, 33);
            this.btSair.TabIndex = 165;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(12, 71);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(105, 33);
            this.btSalvar.TabIndex = 171;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.Location = new System.Drawing.Point(189, 78);
            this.txtUser.MaxLength = 30;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(221, 26);
            this.txtUser.TabIndex = 168;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(189, 117);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 26);
            this.txtPassword.TabIndex = 169;
            // 
            // cbCanAdd
            // 
            this.cbCanAdd.AutoSize = true;
            this.cbCanAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCanAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbCanAdd.Location = new System.Drawing.Point(132, 176);
            this.cbCanAdd.Name = "cbCanAdd";
            this.cbCanAdd.Size = new System.Drawing.Size(72, 24);
            this.cbCanAdd.TabIndex = 168;
            this.cbCanAdd.Text = "Salvar";
            this.cbCanAdd.UseVisualStyleBackColor = true;
            // 
            // cbCanDelete
            // 
            this.cbCanDelete.AutoSize = true;
            this.cbCanDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCanDelete.Location = new System.Drawing.Point(210, 176);
            this.cbCanDelete.Name = "cbCanDelete";
            this.cbCanDelete.Size = new System.Drawing.Size(80, 24);
            this.cbCanDelete.TabIndex = 173;
            this.cbCanDelete.Text = "Deletar";
            this.cbCanDelete.UseVisualStyleBackColor = true;
            // 
            // cbCanAlter
            // 
            this.cbCanAlter.AutoSize = true;
            this.cbCanAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCanAlter.Location = new System.Drawing.Point(296, 176);
            this.cbCanAlter.Name = "cbCanAlter";
            this.cbCanAlter.Size = new System.Drawing.Size(70, 24);
            this.cbCanAlter.TabIndex = 172;
            this.cbCanAlter.Text = "Editar";
            this.cbCanAlter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário: ";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(106, 35);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(21, 20);
            this.lbUser.TabIndex = 176;
            this.lbUser.Text = "--";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(13, 71);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(105, 33);
            this.btLogin.TabIndex = 170;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(12, 115);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(105, 33);
            this.btCancelar.TabIndex = 178;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.alterarUsuárioToolStripMenuItem,
            this.listaUsuáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 179;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // alterarUsuárioToolStripMenuItem
            // 
            this.alterarUsuárioToolStripMenuItem.Name = "alterarUsuárioToolStripMenuItem";
            this.alterarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.alterarUsuárioToolStripMenuItem.Text = "Alterar Usuário";
            this.alterarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.alterarUsuárioToolStripMenuItem_Click);
            // 
            // listaUsuáriosToolStripMenuItem
            // 
            this.listaUsuáriosToolStripMenuItem.Name = "listaUsuáriosToolStripMenuItem";
            this.listaUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.listaUsuáriosToolStripMenuItem.Text = "Lista de Usuários";
            this.listaUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.listaUsuáriosToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(9, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 180;
            this.label2.Text = "Permissões: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 181;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 182;
            this.label4.Text = "Senha:";
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 210);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCanDelete);
            this.Controls.Add(this.cbCanAlter);
            this.Controls.Add(this.cbCanAdd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Usuários";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbCanAdd;
        private System.Windows.Forms.CheckBox cbCanDelete;
        private System.Windows.Forms.CheckBox cbCanAlter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarUsuárioToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem listaUsuáriosToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}