using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_01___Windows_Forms
{
    public partial class Calendario : Form
    {
        public Calendario(Form1 _form)
        {
            InitializeComponent();
            form1 = _form;
        }

        Form1 form1;

        private void btCommand128_Click(object sender, EventArgs e)
        {
            var send = new List<byte>() { 128 };
            form1.WriteCommand(send);
        }

        public void btCommand129_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            values.AddRange(txtHorario.Text.Split(':'));
            values.Reverse();

            string dia = (cbSemana.SelectedIndex + 1).ToString();
            if (dia == "0") return;
            values.Add(dia);

            values.AddRange(txtData.Text.Split('/'));
            if (values[6].Length < 4) return;
            values[6] = values[6].Substring(2);

            form1.Commands81.Clear();

            form1.Commands81.Add(129);
            try
            {
                foreach (string s in values)
                    form1.Commands81.Add(Convert.ToByte(s, 16));
            }
            catch
            { return; }
            
            form1.WriteCommand(form1.Commands81);
        }

        private void btCalendarioAuto_Click(object sender, EventArgs e)
        {
            string Horario = DateTime.Now.ToLongTimeString();
            string Data = DateTime.Now.ToShortDateString();
            string Dia = DateTime.Now.DayOfWeek.ToString();
            int DiaIndex = 0;

            switch (Dia)
            {
                case "Sunday":
                    DiaIndex = 0;
                    break;
                case "Monday":
                    DiaIndex = 1;
                    break;
                case "Tuesday":
                    DiaIndex = 2;
                    break;
                case "Wednesday":
                    DiaIndex = 3;
                    break;
                case "Thursday":
                    DiaIndex = 4;
                    break;
                case "Friday":
                    DiaIndex = 5;
                    break;
                case "Saturday":
                    DiaIndex = 6;
                    break;
            }

            txtHorario.Text = Horario;
            txtData.Text = Data;
            cbSemana.SelectedIndex = DiaIndex;

            btCommand129_Click(null, null);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            //if (form1.isWaitingAnswer) return;
            this.Close();
        }

        public void sucessCommand129(bool isSucess)
        {
            if (isSucess)
                MessageBox.Show("Data e Hora alterados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ocoreu algum erro ao alterar a Data e Hora!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
