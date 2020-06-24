namespace Version_01___Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader columnHeader7;
            System.Windows.Forms.ColumnHeader columnHeader8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbConnStatus = new System.Windows.Forms.Label();
            this.btUpdatePorts = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAnterior = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbLote = new System.Windows.Forms.Label();
            this.lbCalendario = new System.Windows.Forms.Label();
            this.lbErros = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.lbExistente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMaquina = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMedio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaDeMáquinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btCommand131 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCalibracao = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDataEquip = new System.Windows.Forms.Label();
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Agulha";
            columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Contato";
            columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbConnStatus
            // 
            this.lbConnStatus.AutoSize = true;
            this.lbConnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnStatus.Location = new System.Drawing.Point(19, 89);
            this.lbConnStatus.Name = "lbConnStatus";
            this.lbConnStatus.Size = new System.Drawing.Size(114, 16);
            this.lbConnStatus.TabIndex = 83;
            this.lbConnStatus.Text = "Não conectado";
            // 
            // btUpdatePorts
            // 
            this.btUpdatePorts.Location = new System.Drawing.Point(46, 223);
            this.btUpdatePorts.Name = "btUpdatePorts";
            this.btUpdatePorts.Size = new System.Drawing.Size(105, 33);
            this.btUpdatePorts.TabIndex = 81;
            this.btUpdatePorts.Text = "Atualizar Portas";
            this.btUpdatePorts.UseVisualStyleBackColor = true;
            this.btUpdatePorts.Click += new System.EventHandler(this.btUpdatePorts_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(46, 145);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(103, 33);
            this.cbPorts.TabIndex = 82;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(46, 184);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(105, 33);
            this.btConnect.TabIndex = 80;
            this.btConnect.Text = "Conectar";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            columnHeader7,
            columnHeader8,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(201, 145);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(652, 239);
            this.listView.TabIndex = 85;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NL";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 28;
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
            this.columnHeader3.Width = 116;
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
            this.columnHeader5.Width = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Data Lote: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "NL.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 132;
            this.label4.Text = "Anterior:";
            // 
            // lbAnterior
            // 
            this.lbAnterior.AutoSize = true;
            this.lbAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnterior.Location = new System.Drawing.Point(310, 63);
            this.lbAnterior.Name = "lbAnterior";
            this.lbAnterior.Size = new System.Drawing.Size(21, 20);
            this.lbAnterior.TabIndex = 136;
            this.lbAnterior.Text = "--";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(708, 89);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(21, 20);
            this.lbNumero.TabIndex = 135;
            this.lbNumero.Text = "--";
            // 
            // lbLote
            // 
            this.lbLote.AutoSize = true;
            this.lbLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLote.Location = new System.Drawing.Point(578, 86);
            this.lbLote.Name = "lbLote";
            this.lbLote.Size = new System.Drawing.Size(21, 20);
            this.lbLote.TabIndex = 134;
            this.lbLote.Text = "--";
            // 
            // lbCalendario
            // 
            this.lbCalendario.AutoSize = true;
            this.lbCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalendario.Location = new System.Drawing.Point(293, 89);
            this.lbCalendario.Name = "lbCalendario";
            this.lbCalendario.Size = new System.Drawing.Size(21, 20);
            this.lbCalendario.TabIndex = 133;
            this.lbCalendario.Text = "--";
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(18, 114);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(62, 20);
            this.lbErros.TabIndex = 138;
            this.lbErros.Text = "Erros: ";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(46, 351);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(103, 33);
            this.btSair.TabIndex = 84;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbExistente
            // 
            this.lbExistente.AutoSize = true;
            this.lbExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExistente.Location = new System.Drawing.Point(522, 61);
            this.lbExistente.Name = "lbExistente";
            this.lbExistente.Size = new System.Drawing.Size(21, 20);
            this.lbExistente.TabIndex = 148;
            this.lbExistente.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 171;
            this.label6.Text = "Máquina: ";
            // 
            // lbMaquina
            // 
            this.lbMaquina.AutoSize = true;
            this.lbMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaquina.Location = new System.Drawing.Point(101, 63);
            this.lbMaquina.Name = "lbMaquina";
            this.lbMaquina.Size = new System.Drawing.Size(20, 18);
            this.lbMaquina.TabIndex = 172;
            this.lbMaquina.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 180;
            this.label5.Text = "Valores";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(397, 114);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(21, 20);
            this.lbMin.TabIndex = 179;
            this.lbMin.Text = "--";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(647, 114);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(21, 20);
            this.lbMax.TabIndex = 178;
            this.lbMax.Text = "--";
            // 
            // lbMedio
            // 
            this.lbMedio.AutoSize = true;
            this.lbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedio.Location = new System.Drawing.Point(522, 114);
            this.lbMedio.Name = "lbMedio";
            this.lbMedio.Size = new System.Drawing.Size(21, 20);
            this.lbMedio.TabIndex = 177;
            this.lbMedio.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 176;
            this.label8.Text = "Mínimo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 175;
            this.label9.Text = "Máximo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(459, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 174;
            this.label10.Text = "Médio:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMáquinasToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.backUpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 181;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaDeMáquinasToolStripMenuItem
            // 
            this.listaDeMáquinasToolStripMenuItem.Name = "listaDeMáquinasToolStripMenuItem";
            this.listaDeMáquinasToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.listaDeMáquinasToolStripMenuItem.Text = "Lista de Máquinas";
            this.listaDeMáquinasToolStripMenuItem.Click += new System.EventHandler(this.listaDeMáquinasToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.backUpToolStripMenuItem.Text = "Back Up";
            this.backUpToolStripMenuItem.Click += new System.EventHandler(this.backUpToolStripMenuItem_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(100, 38);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(21, 20);
            this.lbUser.TabIndex = 183;
            this.lbUser.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 182;
            this.label11.Text = "Usuário: ";
            // 
            // btCommand131
            // 
            this.btCommand131.Enabled = false;
            this.btCommand131.Location = new System.Drawing.Point(46, 262);
            this.btCommand131.Name = "btCommand131";
            this.btCommand131.Size = new System.Drawing.Size(105, 33);
            this.btCommand131.TabIndex = 185;
            this.btCommand131.Text = "Lote Anterior";
            this.btCommand131.UseVisualStyleBackColor = true;
            this.btCommand131.Click += new System.EventHandler(this.btCommand131_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(46, 301);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 44);
            this.btnReset.TabIndex = 189;
            this.btnReset.Text = "Resetar Banco de Dados";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 190;
            this.label7.Text = "Calibração:";
            // 
            // lbCalibracao
            // 
            this.lbCalibracao.AutoSize = true;
            this.lbCalibracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalibracao.Location = new System.Drawing.Point(331, 38);
            this.lbCalibracao.Name = "lbCalibracao";
            this.lbCalibracao.Size = new System.Drawing.Size(21, 20);
            this.lbCalibracao.TabIndex = 191;
            this.lbCalibracao.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(497, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 20);
            this.label12.TabIndex = 192;
            this.label12.Text = "Data do Aparelho:";
            // 
            // lblDataEquip
            // 
            this.lblDataEquip.AutoSize = true;
            this.lblDataEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEquip.Location = new System.Drawing.Point(647, 39);
            this.lblDataEquip.Name = "lblDataEquip";
            this.lblDataEquip.Size = new System.Drawing.Size(21, 20);
            this.lblDataEquip.TabIndex = 193;
            this.lblDataEquip.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 402);
            this.Controls.Add(this.lblDataEquip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbCalibracao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btCommand131);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbMedio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbMaquina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbExistente);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.lbAnterior);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbLote);
            this.Controls.Add(this.lbCalendario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbConnStatus);
            this.Controls.Add(this.btUpdatePorts);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medidor Reg DL2020";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbConnStatus;
        private System.Windows.Forms.Button btUpdatePorts;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAnterior;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbLote;
        private System.Windows.Forms.Label lbCalendario;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbExistente;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMaquina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbMedio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listaDeMáquinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btCommand131;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCalibracao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDataEquip;
    }
}

