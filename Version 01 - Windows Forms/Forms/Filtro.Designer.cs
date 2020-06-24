namespace Version_01___Windows_Forms
{
    partial class Filtro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filtro));
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btResetar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxMachine = new System.Windows.Forms.CheckBox();
            this.cbMachine = new System.Windows.Forms.ComboBox();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbSemana = new System.Windows.Forms.RadioButton();
            this.rbPersonalizado = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(21, 161);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(82, 34);
            this.btFiltrar.TabIndex = 1;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // btResetar
            // 
            this.btResetar.Location = new System.Drawing.Point(159, 161);
            this.btResetar.Name = "btResetar";
            this.btResetar.Size = new System.Drawing.Size(82, 34);
            this.btResetar.TabIndex = 142;
            this.btResetar.Text = "Resetar";
            this.btResetar.UseVisualStyleBackColor = true;
            this.btResetar.Click += new System.EventHandler(this.btResetar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(284, 161);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(82, 34);
            this.btSair.TabIndex = 143;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(9, 3);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(163, 26);
            this.dateTimePickerInicio.TabIndex = 148;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePickerInicio_ValueChanged);
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFim.Location = new System.Drawing.Point(191, 3);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(163, 26);
            this.dateTimePickerFim.TabIndex = 149;
            this.dateTimePickerFim.ValueChanged += new System.EventHandler(this.dateTimePickerFim_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePickerInicio);
            this.panel2.Controls.Add(this.dateTimePickerFim);
            this.panel2.Location = new System.Drawing.Point(12, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 36);
            this.panel2.TabIndex = 151;
            // 
            // checkBoxMachine
            // 
            this.checkBoxMachine.AutoSize = true;
            this.checkBoxMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxMachine.Location = new System.Drawing.Point(12, 29);
            this.checkBoxMachine.Name = "checkBoxMachine";
            this.checkBoxMachine.Size = new System.Drawing.Size(161, 24);
            this.checkBoxMachine.TabIndex = 152;
            this.checkBoxMachine.Text = "Apenas a máquina";
            this.checkBoxMachine.UseVisualStyleBackColor = true;
            this.checkBoxMachine.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // cbMachine
            // 
            this.cbMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbMachine.FormattingEnabled = true;
            this.cbMachine.Location = new System.Drawing.Point(239, 29);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(91, 28);
            this.cbMachine.TabIndex = 153;
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMes.Location = new System.Drawing.Point(21, 59);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(106, 24);
            this.rbMes.TabIndex = 154;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "Último Mês";
            this.rbMes.UseVisualStyleBackColor = true;
            this.rbMes.CheckedChanged += new System.EventHandler(this.RadioButton);
            // 
            // rbSemana
            // 
            this.rbSemana.AutoSize = true;
            this.rbSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSemana.Location = new System.Drawing.Point(239, 63);
            this.rbSemana.Name = "rbSemana";
            this.rbSemana.Size = new System.Drawing.Size(136, 24);
            this.rbSemana.TabIndex = 155;
            this.rbSemana.TabStop = true;
            this.rbSemana.Text = "Última Semana";
            this.rbSemana.UseVisualStyleBackColor = true;
            this.rbSemana.CheckedChanged += new System.EventHandler(this.RadioButton);
            // 
            // rbPersonalizado
            // 
            this.rbPersonalizado.AutoSize = true;
            this.rbPersonalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbPersonalizado.Location = new System.Drawing.Point(239, 89);
            this.rbPersonalizado.Name = "rbPersonalizado";
            this.rbPersonalizado.Size = new System.Drawing.Size(127, 24);
            this.rbPersonalizado.TabIndex = 156;
            this.rbPersonalizado.TabStop = true;
            this.rbPersonalizado.Text = "Personalizado";
            this.rbPersonalizado.UseVisualStyleBackColor = true;
            this.rbPersonalizado.CheckedChanged += new System.EventHandler(this.RadioButton);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbTodos.Location = new System.Drawing.Point(21, 89);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 24);
            this.rbTodos.TabIndex = 157;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.RadioButton);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 206);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.rbPersonalizado);
            this.Controls.Add(this.rbSemana);
            this.Controls.Add(this.rbMes);
            this.Controls.Add(this.cbMachine);
            this.Controls.Add(this.checkBoxMachine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btResetar);
            this.Controls.Add(this.btFiltrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtro";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button btResetar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxMachine;
        private System.Windows.Forms.ComboBox cbMachine;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbSemana;
        private System.Windows.Forms.RadioButton rbPersonalizado;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}