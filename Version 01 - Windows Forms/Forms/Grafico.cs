using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text;

namespace Version_01___Windows_Forms
{
    public partial class Grafico : Form
    {
        Lote lote;
        List<Leitura> lista;
        List<int> ValorMin = new List<int>();
        List<int> ValorMax = new List<int>();

        public Grafico(Lote _lote)
        {
            InitializeComponent();            
            lote = _lote;
            lista = Firebird.ReturnLeituras(lote);
            Header();
            CreateChart();
            CheckBoxes();

            CreateToolTip();
        }

        #region Make Chart

        private void Header()
        {
            lbLabel.Text = string.Format("Máquina {0} Lote Nº {1} com {2} Leituras", lote.Maquina, lote.NumLote, lote.NumeroLeit);
            lbMin.Text = (lote.Min/10).ToString();
            lbMedio.Text = (lote.Medio/10).ToString();
            lbMax.Text = (lote.Max/10).ToString();

            var config = Firebird.ReturnConfiguration();

            btnValores.BackColor = ColorTranslator.FromHtml(config.GraphValuesColor);
            btnMedio.BackColor = ColorTranslator.FromHtml(config.GraphMedioColor);
            btnMin.BackColor = ColorTranslator.FromHtml(config.GraphMinColor);
            btnMax.BackColor = ColorTranslator.FromHtml(config.GraphMaxColor);
            btnLeituras.BackColor = ColorTranslator.FromHtml(config.GraphLeiturasColor);

        }

        private void CheckBoxes()
        {
            var config = Firebird.ReturnConfiguration();

            cbValores.Checked = config.GraphValues == 1;
            cbMedio.Checked = config.GraphMedio == 1;
            cbMin.Checked = config.GraphMin == 1;
            cbMax.Checked = config.GraphMax == 1;
        }

        private void CreateChart()
        {
            var chartArea = new ChartArea("MyChart");
            chartArea.AxisX.Title = "Num. Leitura";
            chartArea.AxisY.Title = "Leitura (%)";
            chartArea.AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chartArea.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas.Add(chartArea);

            chart1.Legends.Add(new Legend("Legenda"));
            chart1.Legends[0].TableStyle = LegendTableStyle.Auto;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;

            chart1.Series.Add("Series1");
            chart1.Series[0].Name = "Leituras";
            chart1.Series[0].Legend = "Legenda";
            chart1.Series[0].LegendText = "Valores";
            chart1.Series[0].Color = btnLeituras.BackColor;
            chart1.Series[0]["PointWidth"] = "0.95";

            chart1.ChartAreas[0].AxisX.Maximum = lista.Count + 1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            bool useMajorGrid = true;
            for (int i = 0; i < lista.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, Convert.ToDouble(lista[i].ValorLeitura) / 10);
                if (lista[i].ValorLeitura == lote.Min) ValorMin.Add(i);
                if (lista[i].ValorLeitura == lote.Max) ValorMax.Add(i);
                if (Convert.ToDouble(lista[i].ValorLeitura) / 10 > 50) useMajorGrid = false;
            }

            chart1.ChartAreas[0].AxisY.Interval = 5;
            if (useMajorGrid)
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 2.5;

        }

        #endregion

        #region CheckBoxes

        private void cbMedio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMedio.Checked)
            {
                Series series1 = new Series();
                series1.ChartType = SeriesChartType.Line;
                series1.Name = "Média";
                series1.Color = btnMedio.BackColor;
                series1.BorderWidth = 2; 
                
                for (int i = 0; i < lista.Count + 2; i++)
                {
                    series1.Points.AddXY(i, lote.Medio/10);
                }

                chart1.Series.Add(series1);
            }
            else
            {
                chart1.Series.RemoveAt(1);
            }
        }

        private void cbValores_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].IsValueShownAsLabel = cbValores.Checked;
            chart1.Series[0].Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            chart1.Series[0].LabelForeColor = btnValores.BackColor;            
        }

        private void cbMin_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var i in ValorMin)
            {
                if (cbMin.Checked)
                    chart1.Series[0].Points[i].Color = btnMin.BackColor;
                else
                    chart1.Series[0].Points[i].Color = chart1.Series[0].Color;
            }            
        }

        private void cbMax_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var i in ValorMax)
            {
                if (cbMax.Checked)
                    chart1.Series[0].Points[i].Color = btnMax.BackColor;
                else
                    chart1.Series[0].Points[i].Color = btnLeituras.BackColor;
            }
        }

        private void btnColor(object sender, EventArgs e)
        {
            chart1.ApplyPaletteColors();

            Button button = (Button)sender;
            var cdgCores = new ColorDialog();

            if (cdgCores.ShowDialog(this) == DialogResult.OK)
            {
                Color color;
                Series series;

                button.BackColor = cdgCores.Color;
                switch (button.Name)
                {
                    case "btnLeituras":
                        series = VerificarLinha("Leituras");
                        color = button.BackColor;
                        series.Color = color;
                        ChangeColor();
                        break;
                    case "btnMedio":
                        series = VerificarLinha("Média");
                        color = button.BackColor;
                        if (series != null) series.Color = color;
                        break;
                    case "btnValores":
                        series = VerificarLinha("Leituras");
                        color = button.BackColor;
                        series.LabelForeColor = color;
                        break;
                    case "btnMin":
                        color = button.BackColor;
                        ChangeColor();
                        break;
                    case "btnMax":
                        color = button.BackColor;
                        ChangeColor();
                        break;
                }
            }
        }

        private Series VerificarLinha(string nome)
        {
            return chart1.Series.FirstOrDefault(serie => serie.Name == nome);
        }

        private void ChangeColor()
        {
            foreach (var i in ValorMin)
            {
                if (cbMin.Checked)
                    chart1.Series[0].Points[i].Color = btnMin.BackColor;
                else
                    chart1.Series[0].Points[i].Color = chart1.Series[0].Color;
            }
            foreach (var i in ValorMax)
            {
                if (cbMax.Checked)
                    chart1.Series[0].Points[i].Color = btnMax.BackColor;
                else
                    chart1.Series[0].Points[i].Color = btnLeituras.BackColor;
            }
        }

        #endregion       

        #region ToolTip

        private void CreateToolTip()
        {
            chart1.Series[0].ToolTip = "Num. Leit.: #VALX\nLeitura: #VAL";
        }

        #endregion

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var config = Firebird.ReturnConfiguration();
            if (cbValores.Checked) config.GraphValues = 1;
            else config.GraphValues = 0;
            if (cbMedio.Checked) config.GraphMedio = 1;
            else config.GraphMedio = 0;
            if (cbMin.Checked) config.GraphMin = 1;
            else config.GraphMin = 0;
            if (cbMax.Checked) config.GraphMax = 1;
            else config.GraphMax = 0;
            
            config.GraphValuesColor = ColorTranslator.ToHtml(btnValores.BackColor);
            config.GraphMedioColor = ColorTranslator.ToHtml(btnMedio.BackColor);
            config.GraphMinColor = ColorTranslator.ToHtml(btnMin.BackColor);
            config.GraphMaxColor = ColorTranslator.ToHtml(btnMax.BackColor);
            config.GraphLeiturasColor = ColorTranslator.ToHtml(btnLeituras.BackColor);

            if (Firebird.SaveConfig(config))
                MessageBox.Show("Configurações salvas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro ao salvar as configurações!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
