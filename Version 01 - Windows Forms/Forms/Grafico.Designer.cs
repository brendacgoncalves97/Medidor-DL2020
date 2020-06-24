namespace Version_01___Windows_Forms
{
    partial class Grafico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafico));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbMedio = new System.Windows.Forms.CheckBox();
            this.lbLabel = new System.Windows.Forms.Label();
            this.lbMedio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMedio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLeituras = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btnValores = new System.Windows.Forms.Button();
            this.cbValores = new System.Windows.Forms.CheckBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.cbMax = new System.Windows.Forms.CheckBox();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(0, 67);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(510, 398);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cbMedio
            // 
            this.cbMedio.AutoSize = true;
            this.cbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMedio.Location = new System.Drawing.Point(12, 504);
            this.cbMedio.Name = "cbMedio";
            this.cbMedio.Size = new System.Drawing.Size(65, 21);
            this.cbMedio.TabIndex = 3;
            this.cbMedio.Text = "Média";
            this.cbMedio.UseVisualStyleBackColor = true;
            this.cbMedio.CheckedChanged += new System.EventHandler(this.cbMedio_CheckedChanged);
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(12, 15);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(38, 16);
            this.lbLabel.TabIndex = 4;
            this.lbLabel.Text = "Text";
            // 
            // lbMedio
            // 
            this.lbMedio.AutoSize = true;
            this.lbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedio.Location = new System.Drawing.Point(193, 38);
            this.lbMedio.Name = "lbMedio";
            this.lbMedio.Size = new System.Drawing.Size(18, 16);
            this.lbMedio.TabIndex = 11;
            this.lbMedio.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Médio: ";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(81, 38);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(18, 16);
            this.lbMin.TabIndex = 9;
            this.lbMin.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mínimo: ";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(305, 38);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(18, 16);
            this.lbMax.TabIndex = 13;
            this.lbMax.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Máximo";
            // 
            // btnMedio
            // 
            this.btnMedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.Location = new System.Drawing.Point(92, 506);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(18, 17);
            this.btnMedio.TabIndex = 14;
            this.btnMedio.UseVisualStyleBackColor = true;
            this.btnMedio.Click += new System.EventHandler(this.btnColor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(27, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Leituras";
            // 
            // btnLeituras
            // 
            this.btnLeituras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLeituras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeituras.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeituras.Location = new System.Drawing.Point(92, 483);
            this.btnLeituras.Name = "btnLeituras";
            this.btnLeituras.Size = new System.Drawing.Size(18, 17);
            this.btnLeituras.TabIndex = 16;
            this.btnLeituras.UseVisualStyleBackColor = true;
            this.btnLeituras.Click += new System.EventHandler(this.btnColor);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(394, 513);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(105, 33);
            this.btSair.TabIndex = 161;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btnValores
            // 
            this.btnValores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnValores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValores.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValores.Location = new System.Drawing.Point(222, 483);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(18, 17);
            this.btnValores.TabIndex = 163;
            this.btnValores.UseVisualStyleBackColor = true;
            this.btnValores.Click += new System.EventHandler(this.btnColor);
            // 
            // cbValores
            // 
            this.cbValores.AutoSize = true;
            this.cbValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbValores.Location = new System.Drawing.Point(141, 481);
            this.cbValores.Name = "cbValores";
            this.cbValores.Size = new System.Drawing.Size(75, 21);
            this.cbValores.TabIndex = 162;
            this.cbValores.Text = "Valores";
            this.cbValores.UseVisualStyleBackColor = true;
            this.cbValores.CheckedChanged += new System.EventHandler(this.cbValores_CheckedChanged);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(222, 506);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(18, 17);
            this.btnMin.TabIndex = 166;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnColor);
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMin.Location = new System.Drawing.Point(141, 504);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(71, 21);
            this.cbMin.TabIndex = 165;
            this.cbMin.Text = "Minimo";
            this.cbMin.UseVisualStyleBackColor = true;
            this.cbMin.CheckedChanged += new System.EventHandler(this.cbMin_CheckedChanged);
            // 
            // btnMax
            // 
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMax.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(342, 506);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(18, 17);
            this.btnMax.TabIndex = 168;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnColor);
            // 
            // cbMax
            // 
            this.cbMax.AutoSize = true;
            this.cbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMax.Location = new System.Drawing.Point(262, 504);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(74, 21);
            this.cbMax.TabIndex = 167;
            this.cbMax.Text = "Máximo";
            this.cbMax.UseVisualStyleBackColor = true;
            this.cbMax.CheckedChanged += new System.EventHandler(this.cbMax_CheckedChanged);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(394, 474);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(105, 33);
            this.btSalvar.TabIndex = 169;
            this.btSalvar.Text = "Salvar Config.";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 557);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.cbMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.cbValores);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btnLeituras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbMedio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.cbMedio);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grafico";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox cbMedio;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label lbMedio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLeituras;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btnValores;
        private System.Windows.Forms.CheckBox cbValores;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.CheckBox cbMax;
        private System.Windows.Forms.Button btSalvar;
    }
}