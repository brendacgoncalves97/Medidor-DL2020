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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WriteLotes();
        }

        public Form2(List<Lote> lista, string machine)
        {
            InitializeComponent();
            WriteFilterLotes(lista);
            this.machine = machine;
            isMachine = true;
        }

        // Váriaveis usadas para o filtro
        public string machine = string.Empty;
        public bool isMachine = false;
        public DateTime dateStart = DateTime.ParseExact("01/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        public DateTime dateEnd = DateTime.Now;
        public int Date = 3;

        public List<Lote> listaLotes = new List<Lote>();
        public Lote CurrentLote = null;
        public Lote lote;

        #region Write

        public void WriteLotes()
        {
            var lista = Firebird.ReturnListLotes();
            //lista = lista.OrderBy(c => c.Maquina).ThenBy(d => d.NumLote).ToList();

            lista = lista.OrderByDescending(d => d.NumLote).ThenBy(c => c.Id).ToList();

            List<ListViewItem> toAdd = new List<ListViewItem>();
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                ListViewItem viewItem = new ListViewItem(lista[i].Maquina, 0);
                viewItem.SubItems.Add(lista[i].NumLote.ToString());
                viewItem.SubItems.Add(lista[i].NumeroLeit.ToString());
                viewItem.SubItems.Add(lista[i].Calendario);
                toAdd.Add(viewItem);
            }
            listViewLotes.Items.Clear();
            listViewLotes.Items.AddRange(toAdd.ToArray());

            listaLotes = lista;
        }

        public void WriteFilterLotes(List<Lote> lista)
        {
            //lista = lista.OrderByDescending(c => c.Maquina).ThenBy(d => d.NumLote).ToList();
            lista = lista.OrderByDescending(c => c.NumLote).ThenBy(c => c.Id).ToList();

            List<ListViewItem> toAdd = new List<ListViewItem>();

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                ListViewItem viewItem = new ListViewItem(lista[i].Maquina, 0);
                viewItem.SubItems.Add(lista[i].NumLote.ToString());
                viewItem.SubItems.Add(lista[i].NumeroLeit.ToString());
                viewItem.SubItems.Add(lista[i].Calendario);
                toAdd.Add(viewItem);
                lbMaquina.Text = lista[i].Maquina;
            }
            listViewLotes.Items.Clear();
            listViewLotes.Items.AddRange(toAdd.ToArray());
            listaLotes = lista;
        }

        public void WriteLeituras(Lote lote)
        {
            var listaLeituras = Firebird.ReturnLeituras(lote);
            if (listaLeituras.Count != lote.NumeroLeit)
            {
                MessageBox.Show("Ocorreu um erro ao puxar as leituras do lote " + lote.NumLote + "\n" + listaLeituras.Count + "*" + lote.NumeroLeit, "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaLeituras = listaLeituras.OrderBy(c => c.Lote).ToList();

            lbMaquina.Text = lote.Maquina;
            lbCalendario.Text = lote.Calendario;
            lbLote.Text = lote.NumLote.ToString();
            lbNumero.Text = lote.NumeroLeit.ToString();
            lbUser.Text = lote.Usuario;

            List<ListViewItem> toAdd = new List<ListViewItem>();
            foreach (var b in listaLeituras)
            {
                ListViewItem item = new ListViewItem("item", 0);
                item.SubItems.Add((toAdd.Count + 1).ToString());
                item.SubItems.Add(b.Calendario);
                item.SubItems.Add(b.TipoMadeira);
                item.SubItems.Add(b.Temperatura.ToString());
                if (b.Temperatura >= 100)
                {
                    // item.SubItems[6].Text = "-";
                    item.SubItems[3].Text = b.Densidade.ToString() + " Kg/m³";
                    item.SubItems[4].Text = " ";
                    item.SubItems.Add("✔");
                    item.SubItems.Add("-");
                }
                else
                {
                    item.SubItems[3].Text = b.TipoMadeira.ToString();
                    item.SubItems[4].Text = "✔";
                    item.SubItems.Add(" ");
                    item.SubItems.Add(b.Temperatura.ToString());
                }
                string leitura = b.ValorLeitura.ToString();
                leitura = leitura.Insert(leitura.Length - 1, ",").PadLeft(4, '0');
                item.SubItems.Add(leitura);
                toAdd.Add(item);
            }
            listView.Items.Clear();
            listView.Items.AddRange(toAdd.ToArray());
            WriteHeader(lote);
            PaintMinMax();
        }

        private void WriteHeader(Lote lote)
        {
            string Min = lote.Min.ToString();
            Min = Min.Insert(Min.Length - 1, ",").PadLeft(4, '0');

            string Medio = lote.Medio.ToString();
            Medio = Medio.Insert(Medio.Length - 1, ",").PadLeft(4, '0');

            string Max = lote.Max.ToString();
            Max = Max.Insert(Max.Length - 1, ",").PadLeft(4, '0');

            lbMin.Text = Min;
            lbMedio.Text = Medio;
            lbMax.Text = Max;
        }

        public void PaintMinMax()
        {
            var config = Firebird.ReturnConfiguration();

            string Min = lbMin.Text;
            string Max = lbMax.Text;

            for (int i = 0; i < listView.Items.Count; i++)
            {
                listView.Items[i].BackColor = Color.White;
                if (listView.Items[i].SubItems[5].Text == Min && config.ListMin == 1)
                    listView.Items[i].BackColor = ColorTranslator.FromHtml(config.ListMinColor);
                if (listView.Items[i].SubItems[5].Text == Max && config.ListMax == 1)
                    listView.Items[i].BackColor = ColorTranslator.FromHtml(config.ListMaxColor);
            }
        }

        #endregion

        #region Buttons

        private void listViewLotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLotes.SelectedItems.Count == 0) return;

            Lote lote = new Lote();
            lote.Maquina = listViewLotes.SelectedItems[0].SubItems[0].Text;
            lote.NumLote = Convert.ToInt32(listViewLotes.SelectedItems[0].SubItems[1].Text);
            lote.Calendario = listViewLotes.SelectedItems[0].SubItems[3].Text;

            CurrentLote = Firebird.ReturnLote(lote.Maquina, lote.NumLote, lote.Calendario);

            WriteLeituras(CurrentLote);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listViewLotes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um lote.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Firebird.UserHasPermission(1)) return;

            if (MessageBox.Show("Tem certeza que deseja excluir o lote selecionado?", "Tem Certeza?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Lote lote = new Lote();
                lote = Firebird.ReturnLote(listViewLotes.SelectedItems[0].SubItems[0].Text, Convert.ToInt32(listViewLotes.SelectedItems[0].SubItems[1].Text),
                    listViewLotes.SelectedItems[0].SubItems[3].Text);
                Firebird.DeleteAll(lote);

                for (int i = listaLotes.Count - 1; i >= 0; i--)
                    if (listaLotes[i].Maquina == lote.Maquina && listaLotes[i].NumLote == lote.NumLote && listaLotes[i].Calendario == lote.Calendario)
                        listaLotes.RemoveAt(i);
            }
            else
            {
                return;
            }
            WriteFilterLotes(listaLotes);
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            Filtro filtro = new Filtro(this);
            filtro.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btResetaFiltro_Click(object sender, EventArgs e)
        {
            WriteLotes();
            ClearAll();
        }

        #endregion

        private void ClearAll()
        {
            listView.Items.Clear();
            lbMaquina.Text = "--";
            lbCalendario.Text = "--";
            lbLote.Text = "--";
            lbNumero.Text = "--";
            lbMin.Text = "--";
            lbMedio.Text = "--";
            lbMax.Text = "--";
            lbUser.Text = "--";
        }

        private void btGrafico_Click(object sender, EventArgs e)
        {
            if (listViewLotes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um lote.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Grafico form = new Grafico(CurrentLote);
            form.ShowDialog();
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            Config form2 = new Config(this);
            form2.ShowDialog();
        }
    }
}