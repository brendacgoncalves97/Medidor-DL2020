namespace Version_01___Windows_Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listViewLotes = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbLote = new System.Windows.Forms.Label();
            this.lbCalendario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btDelete = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btResetaFiltro = new System.Windows.Forms.Button();
            this.btGrafico = new System.Windows.Forms.Button();
            this.btConfig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMedio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMaquina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewLotes
            // 
            this.listViewLotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewLotes.FullRowSelect = true;
            this.listViewLotes.HideSelection = false;
            this.listViewLotes.Location = new System.Drawing.Point(152, 49);
            this.listViewLotes.Name = "listViewLotes";
            this.listViewLotes.Size = new System.Drawing.Size(224, 377);
            this.listViewLotes.TabIndex = 144;
            this.listViewLotes.UseCompatibleStateImageBehavior = false;
            this.listViewLotes.View = System.Windows.Forms.View.Details;
            this.listViewLotes.SelectedIndexChanged += new System.EventHandler(this.listViewLotes_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Maq.";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lote";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "NL";
            this.columnHeader7.Width = 35;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Data";
            this.columnHeader8.Width = 146;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(892, 47);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(21, 20);
            this.lbNumero.TabIndex = 156;
            this.lbNumero.Text = "--";
            // 
            // lbLote
            // 
            this.lbLote.AutoSize = true;
            this.lbLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLote.Location = new System.Drawing.Point(774, 47);
            this.lbLote.Name = "lbLote";
            this.lbLote.Size = new System.Drawing.Size(21, 20);
            this.lbLote.TabIndex = 155;
            this.lbLote.Text = "--";
            // 
            // lbCalendario
            // 
            this.lbCalendario.AutoSize = true;
            this.lbCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalendario.Location = new System.Drawing.Point(515, 46);
            this.lbCalendario.Name = "lbCalendario";
            this.lbCalendario.Size = new System.Drawing.Size(21, 20);
            this.lbCalendario.TabIndex = 154;
            this.lbCalendario.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(850, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 152;
            this.label3.Text = "NL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "Lote:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 150;
            this.label1.Text = "Data: ";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(464, 103);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(638, 323);
            this.listView.TabIndex = 149;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "NL";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo Madeira";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 107;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Agulha";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Contato";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Temperatura (ºC)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Leitura (%)";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 133;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(21, 166);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(105, 33);
            this.btDelete.TabIndex = 157;
            this.btDelete.Text = "Deleta Lote";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(21, 49);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(105, 33);
            this.btFiltrar.TabIndex = 158;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(21, 244);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(105, 33);
            this.btSair.TabIndex = 160;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btResetaFiltro
            // 
            this.btResetaFiltro.Location = new System.Drawing.Point(21, 88);
            this.btResetaFiltro.Name = "btResetaFiltro";
            this.btResetaFiltro.Size = new System.Drawing.Size(105, 33);
            this.btResetaFiltro.TabIndex = 161;
            this.btResetaFiltro.Text = "Resetar Filtro";
            this.btResetaFiltro.UseVisualStyleBackColor = true;
            this.btResetaFiltro.Click += new System.EventHandler(this.btResetaFiltro_Click);
            // 
            // btGrafico
            // 
            this.btGrafico.Location = new System.Drawing.Point(21, 127);
            this.btGrafico.Name = "btGrafico";
            this.btGrafico.Size = new System.Drawing.Size(105, 33);
            this.btGrafico.TabIndex = 169;
            this.btGrafico.Text = "Gráfico";
            this.btGrafico.UseVisualStyleBackColor = true;
            this.btGrafico.Click += new System.EventHandler(this.btGrafico_Click);
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(21, 205);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(105, 33);
            this.btConfig.TabIndex = 170;
            this.btConfig.Text = "Configurações";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 187;
            this.label5.Text = "Valores";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(642, 72);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(21, 20);
            this.lbMin.TabIndex = 186;
            this.lbMin.Text = "--";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(925, 72);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(21, 20);
            this.lbMax.TabIndex = 185;
            this.lbMax.Text = "--";
            // 
            // lbMedio
            // 
            this.lbMedio.AutoSize = true;
            this.lbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedio.Location = new System.Drawing.Point(774, 72);
            this.lbMedio.Name = "lbMedio";
            this.lbMedio.Size = new System.Drawing.Size(21, 20);
            this.lbMedio.TabIndex = 184;
            this.lbMedio.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 183;
            this.label8.Text = "Mínimo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(850, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 182;
            this.label9.Text = "Máximo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(718, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 181;
            this.label10.Text = "Médio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 188;
            this.label4.Text = "Lotes da Máquina:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(533, 26);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(21, 20);
            this.lbUser.TabIndex = 190;
            this.lbUser.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 189;
            this.label11.Text = "Usuário:";
            // 
            // lbMaquina
            // 
            this.lbMaquina.AutoSize = true;
            this.lbMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbMaquina.Location = new System.Drawing.Point(299, 23);
            this.lbMaquina.Name = "lbMaquina";
            this.lbMaquina.Size = new System.Drawing.Size(21, 20);
            this.lbMaquina.TabIndex = 191;
            this.lbMaquina.Text = "--";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 446);
            this.Controls.Add(this.lbMaquina);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbMedio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.btGrafico);
            this.Controls.Add(this.btResetaFiltro);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbLote);
            this.Controls.Add(this.lbCalendario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.listViewLotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Lotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLotes;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbLote;
        private System.Windows.Forms.Label lbCalendario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btResetaFiltro;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btGrafico;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbMedio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lbMaquina;
    }
}