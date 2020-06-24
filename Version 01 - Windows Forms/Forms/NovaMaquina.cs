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
{   public partial class NovaMaquina : Form
    {
        Form1 form1;
        ListaMaquinas formLista;
        Maquina maquina;
        private bool isUpdate = false;
        public bool MachineSaved = false;

        public NovaMaquina(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;

            lbMaquina.Text = form1.CurrentMachine;
        }

        public NovaMaquina(Maquina _maquina, ListaMaquinas form)
        {
            InitializeComponent();

            this.Text = "Atualizar descrição";
            maquina = _maquina;
            lbMaquina.Text = maquina.Nome;
            txtDescricao.Text = maquina.Descricao;
            formLista = form;

            isUpdate = true;
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                form1.CurrentDescription = txtDescricao.Text;
                Firebird.SaveNewMachine(form1.CurrentMachine, txtDescricao.Text);
                MachineSaved = true;
            }
            else
            {
                maquina.Descricao = txtDescricao.Text;
                Firebird.ChangeDescription(maquina);
                formLista.FillListView();
            }

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
