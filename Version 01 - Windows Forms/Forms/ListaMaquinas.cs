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
    public partial class ListaMaquinas : Form
    {
        private Usuario CurrentUser = Firebird.ReturnLastUser();
        public ListaMaquinas()
        {
            InitializeComponent();
            FillListView();
        }

        public void FillListView()
        {
            var lista = Firebird.ReturnMaquinas();
            lista = lista.OrderByDescending(c => c.Nome).ToList();

            List<ListViewItem> toAdd = new List<ListViewItem>();
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                ListViewItem viewItem = new ListViewItem(lista[i].Nome, 0);
                viewItem.SubItems.Add(lista[i].Descricao);
                viewItem.SubItems.Add(lista[i].Quantidade.ToString());
                toAdd.Add(viewItem);
            }
            listViewMaquinas.Items.Clear();
            listViewMaquinas.Items.AddRange(toAdd.ToArray());
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (listViewMaquinas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma máquina para acessar os seus lotes",
               "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string machine = listViewMaquinas.SelectedItems[0].SubItems[0].Text;
            var Lista = Firebird.ReturnLotesFromMachine(machine);

            Form2 form = new Form2(Lista, machine);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (listViewMaquinas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma máquina para atualizar a sua descrição!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Firebird.UserHasPermission(2)) return;

            string machine = listViewMaquinas.SelectedItems[0].SubItems[0].Text;
            var maquina = Firebird.ReturnMaquina(machine);

            NovaMaquina form = new NovaMaquina(maquina, this);
            form.ShowDialog();
            Application.Restart();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (listViewMaquinas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma máquina para exclui-la!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Firebird.UserHasPermission(1)) return;

            string machine = listViewMaquinas.SelectedItems[0].SubItems[0].Text;
            string s = string.Format("Tem certeza que deseja deletar os lotes e leituras associados com à máquina '{0}'?", machine);
            DialogResult result = MessageBox.Show(s, "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Firebird.DeleteMaq(machine);
                FillListView();
            }
        }

    }
}
