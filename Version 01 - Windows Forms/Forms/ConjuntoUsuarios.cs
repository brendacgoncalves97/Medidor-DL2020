using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Version_01___Windows_Forms.Forms
{
    public partial class ConjuntoUsuarios : Form
    {
        public ConjuntoUsuarios(Usuario atual)
        {
            InitializeComponent();
            FillDataGrid();

            CurrentUser = atual;
        }

        List<Usuario> listUsers = new List<Usuario>();
        Usuario CurrentUser = new Usuario();
        Usuario Admin = Firebird.ReturnAdmin();

        private void FillDataGrid()
        {
            listUsers = Firebird.ReturnListUsers();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;            

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Usuário", typeof(string));
            dataTable.Columns.Add("Salvar", typeof(bool));
            dataTable.Columns.Add("Delet.", typeof(bool));
            dataTable.Columns.Add("Alterar", typeof(bool));

            for (int i = 0; i <listUsers.Count; i++)
            {
                string s = listUsers[i].UserName;
                if (listUsers[i].IsAdmin == 1) s += " (admin)";
                dataTable.Rows.Add(s, listUsers[i].CanAdd, listUsers[i].CanDelete, listUsers[i].CanAlter);
            }

            dataGridView1.DataSource = dataTable;

            for (int i = 0; i < 4; i++)
            {
                DataGridViewColumn column = dataGridView1.Columns[i];
                column.Width = 50;

                if (i == 0) column.Width = 200;
            }

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                e.Cancel = true;
            }
            else if (CurrentUser?.IsAdmin != 1)
            {
                MessageBox.Show("Apenas o administrador pode fazer alterações nos usuários.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (CurrentUser?.IsAdmin != 1)
            {
                MessageBox.Show("Apenas o administrador pode fazer alterações nos usuários.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[i];

                if ((bool)selectedRow.Cells[1].Value == true) listUsers[i].CanAdd = 1;
                else listUsers[i].CanAdd = 0;
                if ((bool)selectedRow.Cells[2].Value == true) listUsers[i].CanDelete = 1;
                else listUsers[i].CanDelete = 0;
                if ((bool)selectedRow.Cells[3].Value == true) listUsers[i].CanAlter = 1;
                else listUsers[i].CanAlter = 0;

                Firebird.UpdateUser(listUsers[i], listUsers[i]);               
            }

            MessageBox.Show("Alterações salvas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            string userDel = dataGridView1.SelectedCells[0].Value.ToString();

            if (CurrentUser?.IsAdmin != 1)
            {
                MessageBox.Show("Apenas o administrador pode deletar um usuário.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (userDel == Admin.UserName)
            {
                MessageBox.Show("Não é possível deletar a conta do administrador!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (userDel == "True" || userDel == "False")
            {
                MessageBox.Show("Por favor, selecione o nome do usuário a ser deletado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string s = string.Format("Tem certeza que deseja deletar o usuário '{0}'?", userDel);
            DialogResult result = MessageBox.Show(s, "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;

            Usuario toDelete = new Usuario();
            foreach (var item in listUsers)
            {
                if (item.UserName == userDel)
                    toDelete = item;
            }

            Firebird.DeleteUser(toDelete);
            FillDataGrid();

            MessageBox.Show("O usuário foi deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
    }
}
