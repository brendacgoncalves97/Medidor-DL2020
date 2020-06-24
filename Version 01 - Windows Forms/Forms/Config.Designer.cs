namespace Version_01___Windows_Forms
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.btnMax = new System.Windows.Forms.Button();
            this.cbMax = new System.Windows.Forms.CheckBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMax.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(186, 67);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(18, 17);
            this.btnMax.TabIndex = 172;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.BtnColor);
            // 
            // cbMax
            // 
            this.cbMax.AutoSize = true;
            this.cbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMax.Location = new System.Drawing.Point(72, 65);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(111, 21);
            this.cbMax.TabIndex = 171;
            this.cbMax.Text = "Valor Máximo";
            this.cbMax.UseVisualStyleBackColor = true;
            this.cbMax.Click += new System.EventHandler(this.CheckBox);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(186, 40);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(18, 17);
            this.btnMin.TabIndex = 170;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnColor);
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMin.Location = new System.Drawing.Point(72, 38);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(108, 21);
            this.cbMin.TabIndex = 169;
            this.cbMin.Text = "Valor Minimo";
            this.cbMin.UseVisualStyleBackColor = true;
            this.cbMin.Click += new System.EventHandler(this.CheckBox);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(140, 99);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(105, 33);
            this.btSair.TabIndex = 173;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(26, 99);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(105, 33);
            this.btSalvar.TabIndex = 174;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 175;
            this.label1.Text = "Destacar:";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 145);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.cbMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.cbMin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuração";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.CheckBox cbMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label1;
    }
}