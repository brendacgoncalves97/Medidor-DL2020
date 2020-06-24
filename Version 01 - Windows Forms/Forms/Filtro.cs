using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Version_01___Windows_Forms
{
    public partial class Filtro : Form
    {
        public Form2 form2;
        public List<Lote> listaFinal = new List<Lote>();

        public Filtro(Form2 form)
        {
            InitializeComponent();
            form2 = form;

            dateTimePickerFim.Value = form2.dateEnd;
            dateTimePickerInicio.Value = form2.dateStart;

            fillComboBox();
            Settings();
        }

        #region Filtros

        public void FiltrarPorData()
        {
            var listaOriginal = Firebird.ReturnListLotes();

            DateTime dtInicio = new DateTime();
            DateTime dtFim = new DateTime();

            if (rbMes.Checked)
            {
                dtInicio = DateTime.Now.AddMonths(-1);
                dtFim = DateTime.Now;
            }
            if (rbSemana.Checked)
            {
                dtInicio = DateTime.Now.AddDays(-7);
                dtFim = DateTime.Now;
            }
            if (rbTodos.Checked)
            {
                listaFinal = listaOriginal;
                form2.WriteFilterLotes(listaFinal);
                return;
            }
            if (rbPersonalizado.Checked)
            {
                dtInicio = dateTimePickerInicio.Value;
                dtFim = dateTimePickerFim.Value;
            }

            if (dtInicio > dtFim)
            {
                MessageBox.Show("Valores fornecidos para a data não são válidos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var item in listaOriginal)
            {
                DateTime dt = new DateTime(2020, 05, 05, 00, 00, 00); //DateTime.ParseExact(item.Calendario.Substring(0, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (Between(dt, dtInicio, dtFim)) listaFinal.Add(item);
            }
        }

        public void FiltrarPorMaquina()
        {
            var listTemp = new List<Lote>(listaFinal);
            string maq = cbMachine.Items[cbMachine.SelectedIndex].ToString();
            for (int i = listTemp.Count - 1; i >= 0; i--)
            {
                if (listTemp[i].Maquina != maq)
                    listaFinal.RemoveAt(i);
            }
        }

        public static bool Between(DateTime input, DateTime date1, DateTime date2)
        {
            bool toReturn = (input >= date1 && input <= date2);
            return toReturn;
        }

        #endregion

        #region Comandos

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            listaFinal.Clear();
            FiltrarPorData();
            if (checkBoxMachine.Checked)
            {
                FiltrarPorMaquina();
            }

            if (rbMes.Checked) form2.Date = 1;
            if (rbSemana.Checked) form2.Date = 2;
            if (rbTodos.Checked) form2.Date = 3;
            if (rbPersonalizado.Checked)
            {
                form2.Date = 4;
                form2.dateEnd = dateTimePickerFim.Value;
                form2.dateStart = dateTimePickerInicio.Value;
            }
            form2.isMachine = checkBoxMachine.Checked;
            if (checkBoxMachine.Checked)
                form2.machine = cbMachine.Items[cbMachine.SelectedIndex].ToString();

            form2.WriteFilterLotes(listaFinal);

            this.Close();
        }

        private void btResetar_Click(object sender, EventArgs e)
        {
            var listaOriginal = Firebird.ReturnListLotes();
            form2.WriteFilterLotes(listaOriginal);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void Settings()
        {
            switch (form2.Date)
            {
                case 1:
                    rbMes.Checked = true;
                    break;
                case 2:
                    rbSemana.Checked = true;
                    break;
                case 3:
                    rbTodos.Checked = true;
                    break;
                case 4:
                    rbPersonalizado.Checked = true;
                    break;
            }
            if (!rbPersonalizado.Checked)
                panel2.Enabled = false;
            if (form2.isMachine)
                checkBoxMachine.Checked = true;
        }

        private void CheckBoxChanged(object sender, EventArgs e)
        {
            if (checkBoxMachine.Checked)
            {
                cbMachine.Enabled = true;
                for (int i = 0; i < cbMachine.Items.Count; i++)
                    if (cbMachine.Items[i].ToString() == form2.machine)
                        cbMachine.SelectedIndex = i;
            }
            else
            {
                cbMachine.Enabled = false;
            }
        }

        private void fillComboBox()
        {
            var lista = Firebird.ReturnListMaquina();
            lista.Sort();
            for (int i = 0; i < lista.Count; i++)
            {
                cbMachine.Items.Add(lista[i]);
            }
            if (cbMachine.Items.Count > 0 && cbMachine.SelectedIndex == -1)
                cbMachine.SelectedIndex = 0;

            cbMachine.Enabled = form2.isMachine;
        }

        private void RadioButton(object sender, EventArgs e)
        {
            if (rbPersonalizado.Checked)
            {
                panel2.Enabled = true;
            }
            else
            {
                panel2.Enabled = false;
            }
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{Right}");
        }

        private void dateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{Right}");
        }
    }
}
