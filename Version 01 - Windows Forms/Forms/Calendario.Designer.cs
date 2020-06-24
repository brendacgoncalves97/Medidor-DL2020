namespace Version_01___Windows_Forms
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCalendarioAuto = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.cbSemana = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data: ";
            // 
            // btCalendarioAuto
            // 
            this.btCalendarioAuto.Location = new System.Drawing.Point(12, 16);
            this.btCalendarioAuto.Name = "btCalendarioAuto";
            this.btCalendarioAuto.Size = new System.Drawing.Size(92, 42);
            this.btCalendarioAuto.TabIndex = 146;
            this.btCalendarioAuto.Text = "Ajustar";
            this.btCalendarioAuto.UseVisualStyleBackColor = true;
            this.btCalendarioAuto.Click += new System.EventHandler(this.btCalendarioAuto_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(12, 65);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(91, 42);
            this.btSair.TabIndex = 147;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 148;
            this.label1.Text = "Dia: ";
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtData.Location = new System.Drawing.Point(173, 21);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(104, 29);
            this.txtData.TabIndex = 149;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtHorario
            // 
            this.txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtHorario.Location = new System.Drawing.Point(173, 60);
            this.txtHorario.Mask = "00:00:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(104, 29);
            this.txtHorario.TabIndex = 150;
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHorario.ValidatingType = typeof(System.DateTime);
            // 
            // cbSemana
            // 
            this.cbSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSemana.FormattingEnabled = true;
            this.cbSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sabado"});
            this.cbSemana.Location = new System.Drawing.Point(173, 95);
            this.cbSemana.Name = "cbSemana";
            this.cbSemana.Size = new System.Drawing.Size(104, 32);
            this.cbSemana.TabIndex = 151;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 133);
            this.Controls.Add(this.cbSemana);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCalendarioAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalendarioAuto;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txtData;
        public System.Windows.Forms.MaskedTextBox txtHorario;
        public System.Windows.Forms.ComboBox cbSemana;
    }
}