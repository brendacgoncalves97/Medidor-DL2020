using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;

namespace Version_01___Windows_Forms.Forms
{
    public partial class BackUp : Form
    {
        public BackUp()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopiaDeSeguranca_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdBackup = new SaveFileDialog();

            this.Cursor = Cursors.WaitCursor;
            FbBackup backupSvc = new FbBackup();
            string NomeArquivo = string.Empty;

            backupSvc.ConnectionString = Firebird.Conn;
            backupSvc.Verbose = true;

            try
            {
                sfdBackup.InitialDirectory = Environment.CurrentDirectory + "\\BackUp";
                sfdBackup.Filter = "Arquivo de BackUp DL 2020|*.dl";
                sfdBackup.Title = "Salvar Como";
                sfdBackup.FileName = "BackUp DL 2020 - Dia " + DateTime.Today.Day.ToString("0,0") + "_" +
                        DateTime.Today.Month.ToString("0,0");

                if (sfdBackup.ShowDialog(this) == DialogResult.OK)
                {
                    if (sfdBackup.FileName != string.Empty)
                    {
                        NomeArquivo = sfdBackup.FileName;
                        if (File.Exists(NomeArquivo)) File.Delete(NomeArquivo);
                    }
                    else
                    {
                        MessageBox.Show("Digite um nome para o backup", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    return;
                }

                this.Cursor = Cursors.WaitCursor;
                backupSvc.BackupFiles.Add(new FbBackupFile(NomeArquivo, 2048));

                backupSvc.Execute();
                MessageBox.Show("Backup do banco de Dados efetuado com Sucesso! \nArquivo Criado em: " + NomeArquivo, "Backup", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar Cópia de Segurança: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                backupSvc = null;
            }
        }

        private void btnRestaurarCopiaDeSeguranca_Click(object sender, EventArgs e)
        {
            Backup backup = Firebird.RetornaBackup();
            OpenFileDialog oldBackup = new OpenFileDialog();

            this.Cursor = Cursors.WaitCursor;

            string NomeArquivo = string.Empty;

            FbConnection.ClearAllPools();

            try
            {
                {
                    oldBackup.InitialDirectory = Environment.CurrentDirectory + "\\BackUp";
                    oldBackup.Title = "Abrir arquivo de BackUp";
                    oldBackup.Filter = "Arquivo de Backup DL 2020|*.dl";
                    if (oldBackup.ShowDialog(this) == DialogResult.OK)
                    {
                        if (oldBackup.FileName != string.Empty)
                        {
                            NomeArquivo = oldBackup.FileName;
                        }
                        else
                        {
                            MessageBox.Show("Selecione o backup para restaurar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                this.Cursor = Cursors.WaitCursor;


                string RestoreBanco = Environment.CurrentDirectory + "\\DL2020.fdb";
                //string conexao = @"User=SYSDBA;Password=masterkey;database = " + RestoreBanco + ";DataSource=localhost;Port=3050;Dialect=3;";

                string conexao = Firebird.Conn;
                FbRestore RestoreSvc = new FbRestore();
                RestoreSvc.ConnectionString = conexao;

                RestoreSvc.BackupFiles.Add(new FbBackupFile(NomeArquivo, 2048));
                RestoreSvc.Verbose = true;
                RestoreSvc.PageSize = 4096;
                RestoreSvc.Options = FbRestoreFlags.Create | FbRestoreFlags.Replace;

                RestoreSvc.Execute();

                MessageBox.Show("Backup restaurado com sucesso!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (backup != null) Firebird.SaveBackup(backup);
                Application.Restart();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar Cópia de Segurança" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void chkAtivarBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivarBackup.Checked)
            {
                label1.Enabled = true;
                label2.Enabled = true;
                CaminhoBackup.Enabled = true;
                LocalizarCaminho.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                SalvarConfiguracaoBackup.Enabled = true;
                cmbPeriodo.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                label2.Enabled = false;
                CaminhoBackup.Enabled = false;
                LocalizarCaminho.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                cmbPeriodo.Enabled = false;
            }
        }

        private void LocalizarCaminho_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                CaminhoBackup.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SalvarConfiguracaoBackup_Click(object sender, EventArgs e)
        {
            Backup backup = Firebird.RetornaBackup();
            if (backup == null && chkAtivarBackup.Checked)
            {
                backup = new Backup();
                //backup.Ativo = 1;
                backup.Periodo = cmbPeriodo.SelectedIndex;
                backup.CaminhoBackup = CaminhoBackup.Text;
                bool retorno = Firebird.SaveBackup(backup);
                if (retorno)
                {
                    MessageBox.Show("Backup Salvo com Sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else MessageBox.Show("Erro ao tentar salvar o backup. Verifique o log de erro para obter mais informações.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chkAtivarBackup.Checked)
            {
                //backup.Ativo = 1;
                backup.Periodo = cmbPeriodo.SelectedIndex;
                backup.CaminhoBackup = CaminhoBackup.Text;
                string data = DateTime.Now.ToString();
                backup.DataUltimoBackup = data.Substring(0, 10);
                bool retorno = Firebird.AlterarDataUltimoBackup(backup.DataUltimoBackup);
                if (retorno)
                {
                    MessageBox.Show("Alterado as configurações do Backup", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else MessageBox.Show("Erro ao tentar alterar o backup!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (backup != null && chkAtivarBackup.Checked == false)
            {
                if (MessageBox.Show("Você desativou o backup automático.Deseja confirmar?", "Confirmar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Firebird.DeletaBackup();
                }
            }
        }

        private void BackUp_Load(object sender, EventArgs e)
        {
            chkAtivarBackup.Visible = true;
            Backup backup = Firebird.RetornaBackup();
            if (backup == null)
            {
                chkAtivarBackup.Checked = false;
                label1.Enabled = false;
                label2.Enabled = false;
                CaminhoBackup.Enabled = false;
                LocalizarCaminho.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                SalvarConfiguracaoBackup.Enabled = false;
                cmbPeriodo.Enabled = false;
                cmbPeriodo.Text = "Diariamente";
                CaminhoBackup.Text = "";
            }
            else
            {
                chkAtivarBackup.Checked = true;
                switch (backup.Periodo)
                {
                    case 0:
                        cmbPeriodo.Text = "Diariamente";
                        break;
                    case 1:
                        cmbPeriodo.Text = "Semanalmente";
                        break;
                    case 2:
                        cmbPeriodo.Text = "Mensalmente";
                        break;
                }
                CaminhoBackup.Text = backup.CaminhoBackup;
            }
        }

    }
}
