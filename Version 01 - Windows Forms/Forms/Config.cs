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
    public partial class Config : Form
    {
        Form2 form2;
        public Config(Form2 _form2)
        {
            InitializeComponent();
            form2 = _form2;
            Loading();
        }

        public void Loading()
        {
            var config = Firebird.ReturnConfiguration();
            cbMin.Checked = config.ListMin == 1;
            cbMax.Checked = config.ListMax == 1;
            btnMin.BackColor = ColorTranslator.FromHtml(config.ListMinColor);
            btnMax.BackColor = ColorTranslator.FromHtml(config.ListMaxColor);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Configuration config = Firebird.ReturnConfiguration();
            if (cbMin.Checked) config.ListMin = 1;
            else config.ListMin = 0;        
            if (cbMax.Checked) config.ListMax = 1;
            else config.ListMax = 0;
            config.ListMinColor = ColorTranslator.ToHtml(btnMin.BackColor);
            config.ListMaxColor = ColorTranslator.ToHtml(btnMax.BackColor);
            Firebird.SaveConfig(config);

            form2.PaintMinMax();
            MessageBox.Show("Configurações alteradas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CheckBox(object sender, EventArgs e)
        {

        }

        private void BtnColor(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            var cdgCores = new ColorDialog();
            if (cdgCores.ShowDialog(this) == DialogResult.OK)
            {
                Color color;

                button.BackColor = cdgCores.Color;
                switch (button.Name)
                {
                    case "btnMin":
                        color = button.BackColor;
                        break;
                    case "btnMax":
                        color = button.BackColor;
                        break;
                }
            }
        }
        
    }
}
