using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_01___Windows_Forms.Forms
{
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios(bool createAdmin = false)
        {
            InitializeComponent();
            isCreateAdmin = createAdmin;
            Settings();
            ConnectLastUser();
        }

        private void Settings()
        {
            CurrentUser = null;

            if (isCreateAdmin)
            {
                btLogin.Visible = false;
                btSair.Visible = false;
            }
            else
            {
                btSalvar.Visible = false;
                btCancelar.Visible = false;
            }

            cbCanAdd.Enabled = false;
            cbCanAlter.Enabled = false;
            cbCanDelete.Enabled = false;
            
        }

        private void ConnectLastUser()
        {
            if (isCreateAdmin) return;
            var LastUser = Firebird.ReturnLastUser();
            
            txtUser.Text = LastUser.UserName;
            txtPassword.Text = LastUser.Password;
            btLogin_Click(null, null);
        }

        #region Variables

        private Usuario CurrentUser = new Usuario();
        
        private bool isAltering = false;
        private bool isCreateAdmin;

        #endregion

        #region Button

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (btLogin.Text == "Login")
            {
                var user = Firebird.ReturnUser(txtUser.Text, txtPassword.Text);
                if (user.UserName == null)
                {
                    var lista = Firebird.ReturnListUsers();
                    bool UserExists = false;
                    foreach (var item in lista)
                    {
                        if (item.UserName == txtUser.Text)
                        {
                            UserExists = true;
                            break;
                        }
                    }
                    string s = string.Empty;
                    if (!UserExists) s = "Usuário não encontrado";
                    else s = "Senha incorreta";
                    MessageBox.Show(s, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CurrentUser = user;

                cbCanAdd.Checked = user.CanAdd == 1;
                cbCanAlter.Checked = user.CanAlter == 1;
                cbCanDelete.Checked = user.CanDelete == 1;

                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                btLogin.Text = "Desconectar";
                lbUser.Text = user.UserName;

                if (CurrentUser.IsAdmin == 1)
                    label1.Text = "Admin: ";
                else
                    label1.Text = "Usuário: ";

                Firebird.SaveLastUser(CurrentUser);
                return;
            }
            if (btLogin.Text == "Desconectar")
            {
                CurrentUser = null;

                txtUser.Enabled = true;
                txtPassword.Enabled = true;

                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;

                btLogin.Text = "Login";
                lbUser.Text = "--";
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var listaExistente = Firebird.ReturnListUsersName();
            foreach (var item in listaExistente)
            {
                if (item == txtUser.Text && !isAltering)
                {
                    MessageBox.Show("Usuario já existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Usuario usuario = new Usuario();
            usuario.UserName = txtUser.Text;
            usuario.Password = txtPassword.Text;
            usuario.IsAdmin = 0;
            if (cbCanAdd.Checked) usuario.CanAdd = 1;
            else usuario.CanAdd = 0;
            if (cbCanAlter.Checked) usuario.CanAlter = 1;
            else usuario.CanAlter = 0;
            if (cbCanDelete.Checked) usuario.CanDelete = 1;
            else usuario.CanDelete = 0;

            if (isCreateAdmin)
            {
                usuario.IsAdmin = 1;
                usuario.CanAdd = 1;
                usuario.CanAlter = 1;
                usuario.CanDelete = 1;
                Firebird.SaveNewUser(usuario);
                Firebird.SaveLastUser(usuario);
                this.Close();
                return;
            }
            if (!isAltering)
            {
                Firebird.SaveNewUser(usuario);
                MessageBox.Show("Usuário criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                usuario.IsAdmin = CurrentUser.IsAdmin;
                Firebird.UpdateUser(CurrentUser, usuario);
                CurrentUser = usuario;
                lbUser.Text = txtUser.Text;
                MessageBox.Show("Nome e senha do usuário modificado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            txtUser.Text = CurrentUser.UserName;
            txtPassword.Text = CurrentUser.Password;
            txtUser.Enabled = false;
            txtPassword.Enabled = false;

            btLogin.Visible = true;
            btSair.Visible = true;
            btSalvar.Visible = false;
            btCancelar.Visible = false;

            cbCanAdd.Enabled = false;
            cbCanAlter.Enabled = false;
            cbCanDelete.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                txtUser.Text = CurrentUser.UserName;
                txtPassword.Text = CurrentUser.Password;
                txtUser.Enabled = false;
                txtPassword.Enabled = false;

                cbCanAdd.Checked = CurrentUser.CanAdd == 1;
                cbCanAlter.Checked = CurrentUser.CanAlter == 1;
                cbCanDelete.Checked = CurrentUser.CanDelete == 1;
            }

            if (isCreateAdmin)
            {
                this.Close();
                return;
            }

            btLogin.Visible = true;
            btSair.Visible = true;
            btSalvar.Visible = false;
            btCancelar.Visible = false;

            cbCanAdd.Enabled = false;
            cbCanAlter.Enabled = false;
            cbCanDelete.Enabled = false;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region MenuStrip

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null || CurrentUser.IsAdmin != 1)
            {
                MessageBox.Show("Apenas o administrador pode criar um novo usuário", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtUser.Enabled = true;
            txtUser.Text = "";
            txtPassword.Enabled = true;
            txtPassword.Text = "";

            isAltering = false;

            btLogin.Visible = false;
            btSair.Visible = false;
            btSalvar.Visible = true;
            btCancelar.Visible = true;

            cbCanAdd.Enabled = true;
            cbCanAlter.Enabled = true;
            cbCanDelete.Enabled = true;
            cbCanAdd.Checked = false;
            cbCanAlter.Checked = false;
            cbCanDelete.Checked = false;
        }

        private void alterarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("Nenhum usuário selecionado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtUser.Enabled = true;
            txtPassword.Enabled = true;

            cbCanAdd.Checked = CurrentUser.CanAdd == 1;
            cbCanAlter.Checked = CurrentUser.CanAlter == 1;
            cbCanDelete.Checked = CurrentUser.CanDelete == 1;

            isAltering = true;

            btLogin.Visible = false;
            btSair.Visible = false;
            btSalvar.Visible = true;
            btCancelar.Visible = true;
        }

        private void listaUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConjuntoUsuarios form = new ConjuntoUsuarios(CurrentUser);
            form.ShowDialog();
        }

        #endregion

    }
}
