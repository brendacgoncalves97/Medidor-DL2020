using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using FirebirdSql.Data.Services;
using Version_01___Windows_Forms.Forms;

namespace Version_01___Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckUser();
            CheckBackUp();

            new Thread(() =>
            {
                Thread.Sleep(10);
                Invoke((Action)delegate { UpdateComboBox(); });
            }).Start();
        }

        #region Backup
        private void CheckBackUp()
        {
            try
            {
                Backup backup = Firebird.RetornaBackup();
                if (backup != null)
                {
                    if (Directory.Exists(backup.CaminhoBackup))
                    {
                        switch (backup.Periodo)
                        {
                            case 0:
                                if (backup.DataUltimoBackup == "")
                                {
                                    FbBackup backupSvc = new FbBackup();
                                    string NomeArquivo = backup.CaminhoBackup + "/BackUp DL 2020 - Dia " +
                                                            DateTime.Today.Day.ToString("0,0") + "_" +
                                                            DateTime.Today.Month.ToString("0,0") + ".dl";
                                    if (File.Exists(NomeArquivo)) File.Delete(NomeArquivo);
                                    backupSvc.ConnectionString = Firebird.Conn;
                                    backupSvc.Verbose = true;
                                    backupSvc.BackupFiles.Add(new FbBackupFile(NomeArquivo, -1));
                                    backupSvc.Execute();
                                    string date = DateTime.Today.ToString();
                                    backup.DataUltimoBackup = date;
                                    Firebird.AlterarDataUltimoBackup(date);
                                    Firebird.SaveBackup(backup);
                                }
                                else
                                {
                                    DateTime data = Convert.ToDateTime(backup.DataUltimoBackup);
                                    data = data.AddDays(+1);
                                    if (DateTime.Today == data || DateTime.Today > data)
                                    {
                                        FbBackup backupSvc = new FbBackup();
                                        string NomeArquivo = backup.CaminhoBackup + "/BackUp DL 2020 - Dia " +
                                                                DateTime.Today.Day.ToString("0,0") + "_" +
                                                                DateTime.Today.Month.ToString("0,0") + ".dl";
                                        if (File.Exists(NomeArquivo)) File.Delete(NomeArquivo);
                                        backupSvc.ConnectionString = Firebird.Conn;
                                        backupSvc.Verbose = true;
                                        backupSvc.BackupFiles.Add(new FbBackupFile(NomeArquivo, -1));
                                        backupSvc.Execute();
                                        string date = DateTime.Today.ToString();
                                        backup.DataUltimoBackup = date;
                                        Firebird.AlterarDataUltimoBackup(date);
                                        Firebird.SaveBackup(backup);
                                    }
                                }
                                break;
                            case 1:
                                if (backup.DataUltimoBackup == "")
                                {
                                    FbBackup backupSvc = new FbBackup();
                                    string NomeArquivo = backup.CaminhoBackup + "/BackUp DL 2020 - Dia " +
                                                            DateTime.Today.Day.ToString("0,0") + "_" +
                                                            DateTime.Today.Month.ToString("0,0") + ".dl";
                                    if (File.Exists(NomeArquivo)) File.Delete(NomeArquivo);
                                    backupSvc.ConnectionString = Firebird.Conn;
                                    backupSvc.Verbose = true;
                                    backupSvc.BackupFiles.Add(new FbBackupFile(NomeArquivo, -1));
                                    backupSvc.Execute();
                                    string date = DateTime.Today.ToString();
                                    backup.DataUltimoBackup = date;
                                    Firebird.AlterarDataUltimoBackup(date);
                                    Firebird.SaveBackup(backup);
                                }
                                else
                                {
                                    DateTime data = Convert.ToDateTime(backup.DataUltimoBackup);
                                    data = data.AddDays(+7);
                                    if (DateTime.Today == data || DateTime.Today > data)
                                    {
                                        FbBackup backupSvc = new FbBackup();
                                        string NomeArquivo = backup.CaminhoBackup + "/BackUp DL 2020 - Dia " +
                                                                DateTime.Today.Day.ToString("0,0") + "_" +
                                                                DateTime.Today.Month.ToString("0,0") + ".dl";
                                        if (File.Exists(NomeArquivo)) File.Delete(NomeArquivo);
                                        backupSvc.ConnectionString = Firebird.Conn;
                                        backupSvc.Verbose = true;
                                        backupSvc.BackupFiles.Add(new FbBackupFile(NomeArquivo, -1));
                                        backupSvc.Execute();
                                        string date = DateTime.Today.ToString();
                                        backup.DataUltimoBackup = date;
                                        Firebird.AlterarDataUltimoBackup(date);
                                        Firebird.SaveBackup(backup);
                                    }
                                }
                                break;
                            case 2:
                                if (backup.DataUltimoBackup == "")
                                {
                                    FbBackup backupSvc = new FbBackup();
                                    string NomeArquivo = backup.CaminhoBackup + "/BackUp DL 2020 - Dia " +
                                                            DateTime.Today.Day.ToString("0,0") + "_" +
                                                            DateTime.Today.Month.ToString("0,0") + ".dl";
                                    if (File.Exists(NomeArquivo)) File.Delete(NomeArquivo);
                                    backupSvc.ConnectionString = Firebird.Conn;
                                    backupSvc.Verbose = true;
                                    backupSvc.BackupFiles.Add(new FbBackupFile(NomeArquivo, -1));
                                    backupSvc.Execute();
                                    string date = DateTime.Today.ToString();
                                    backup.DataUltimoBackup = date;
                                    Firebird.AlterarDataUltimoBackup(date);
                                    Firebird.SaveBackup(backup);
                                }
                                else
                                {
                                    DateTime data = Convert.ToDateTime(backup.DataUltimoBackup);
                                    data = data.AddDays(+30);
                                    if (DateTime.Today == data || DateTime.Today > data)
                                    {
                                        FbBackup backupSvc = new FbBackup();
                                        string NomeArquivo = backup.CaminhoBackup + "/BackUp DL 2020 - Dia " +
                                                                DateTime.Today.Day.ToString("0,0") + "_" +
                                                                DateTime.Today.Month.ToString("0,0") + ".dl";
                                        if (File.Exists(NomeArquivo)) File.Delete(NomeArquivo);
                                        backupSvc.ConnectionString = Firebird.Conn;
                                        backupSvc.Verbose = true;
                                        backupSvc.BackupFiles.Add(new FbBackupFile(NomeArquivo, -1));
                                        backupSvc.Execute();
                                        string date = DateTime.Today.ToString();
                                        backup.DataUltimoBackup = date;
                                        Firebird.AlterarDataUltimoBackup(date);
                                        Firebird.SaveBackup(backup);
                                    }
                                }
                                break;
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(
                            "O caminho para o backup automático não está disponivel, deseja continuar?",
                            "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch
            {
            }
        }
        #endregion

        #region Variables

        private bool isConnected = false;
        private bool isCommunicating = false;
        public bool isWaitingAnswer = false;
        private bool isReceivedAnswer = false;
        private bool isUltimoLote = false;
        private bool isFirst = true;

        private int numErrors = 0;
        private int LoteAnterior;

        public string CurrentMachine = string.Empty;
        public string CurrentDescription = string.Empty;
        public string CurrentCalib = string.Empty;

        public SerialPort serial;
        public Lote lote = new Lote();
        public Usuario CurrentUser = new Usuario();
        public List<Leitura> listaLeituras = new List<Leitura>();
        public Lote CurrentLote;

        public List<byte> Received = new List<byte>();
        public List<byte> Commands = new List<byte>();
        public List<byte> Commands81 = new List<byte>();
        public List<byte> lastCommand = new List<byte>();

        Stopwatch stopwatch = new Stopwatch();
        Stopwatch Reconn = new Stopwatch();

        #endregion

        #region Suport

        private void CheckUser()
        {
            var admin = Firebird.ReturnAdmin();
            if (admin.UserName == null)
            {
                MessageBox.Show("É necessário criar uma conta para o administrador", "Aviso!", MessageBoxButtons.OK);
                ListaUsuarios form = new ListaUsuarios(true);
                form.ShowDialog();
                CheckUser();
                return;
            }

            CurrentUser = Firebird.ReturnLastUser();
            lbUser.Text = CurrentUser.UserName;
            if (CurrentUser.IsAdmin == 1)
            {
                lbUser.Text += " (admin)";
                btnReset.Enabled = true;
            }
        }

        private void UpdateControls()
        {
            Invoke((Action)delegate
            {
                if (isConnected && !isCommunicating)
                {
                    btConnect.Text = "Desconectar";
                    //lbConnStatus.Text = "Conectando...";
                    lbConnStatus.Text = "Esperando conexão";

                    btUpdatePorts.Enabled = false;
                    cbPorts.Enabled = false;
                    //btCommand130.Enabled = false;
                    btCommand131.Enabled = false;
                    btnReset.Enabled = false;
                    // listaDeLotesToolStripMenuItem.Visible = false;
                }
                else if (isConnected && isCommunicating)
                {
                    Thread.Sleep(1500);
                    lbConnStatus.Text = "Conectado";
                    //btCommand130.Enabled = true;
                    btCommand131.Enabled = true;
                    // listaDeLotesToolStripMenuItem.Visible = true;
                    if (CurrentUser.IsAdmin != 1)
                    {
                        btnReset.Enabled = false;
                    }
                    else
                    {
                        btnReset.Enabled = true;
                    }

                    //Reconn.Restart();
                    //Thread t = new Thread(Reconnection);
                    //t.Start();
                }
                else if (!isConnected && !isCommunicating)
                {
                    btConnect.Text = "Conectar";
                    lbConnStatus.Text = "Não conectado";
                    lbErros.Text = "Erros: ";
                    lbMaquina.Text = "--";

                    numErrors = 0;
                    LoteAnterior = 0;

                    Received.Clear();

                    cbPorts.Enabled = true;
                    btUpdatePorts.Enabled = true;
                    isFirst = true;
                    isUltimoLote = false;
                    //btCommand130.Enabled = false;
                    btCommand131.Enabled = false;
                    btnReset.Enabled = false;
                    // listaDeLotesToolStripMenuItem.Visible = false;
                }
            });
        }

        private void Error(int code)
        {
            numErrors++;

            if (numErrors <= 3)
            {
                Received.Clear();
                isWaitingAnswer = false;
                Invoke((Action)delegate { lbErros.Text = "Erros: " + numErrors.ToString(); });
                WriteCommand(new List<byte>(lastCommand));
            }
            else
            {
                Received.Clear();
                numErrors = 0;
                // 0 = numero de bytes recebido incorreto, no momento nunca é utilizado 
                if (code == 0) MessageBox.Show("Numero de bytes recebido está incorreto", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 1 = numero do checksum
                if (code == 1) MessageBox.Show("Erro de CheckSum", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 2 = não recebeu nenhuma resposta
                if (code == 2) MessageBox.Show("O programa não recebeu nenhuma resposta da máquina", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckTimeout()
        {
            stopwatch.Restart();
            if (isWaitingAnswer) return;

            Thread t = new Thread(ThreadTimeout);
            t.Start();
        }

        private void ThreadTimeout()
        {
            isWaitingAnswer = true;

            while (stopwatch.ElapsedMilliseconds < 5000)
            {
                if (isReceivedAnswer)
                {
                    isWaitingAnswer = false;
                    return;
                }
                else if (stopwatch.ElapsedMilliseconds > 1500 && Received.Count == 0)
                {
                    isWaitingAnswer = false;
                    Error(2);
                    return;
                }
            }

            isWaitingAnswer = false;
            Error(0);
        }

        public bool CheckSum(int command)
        {
            var checksum = 0;

            if (command == 80)
                for (var i = 1; i < Received.Count - 1; i++)
                    checksum ^= Received[i];

            else if (command == 82)
                for (var i = 3; i < Received.Count - 1; i++)
                    checksum ^= Received[i];

            if (checksum != Received[Received.Count - 1])
            {
                isReceivedAnswer = true;

                Stopwatch wait = new Stopwatch();
                wait.Start();
                while (wait.ElapsedMilliseconds < 1000)
                { Application.DoEvents(); }

                Error(1);
                return false;
            }
            return true;
        }

        //private void Reconnection()
        //{
        //    while (isCommunicating)
        //    {
        //        if (Reconn.ElapsedMilliseconds > 120000)
        //        {
        //            isCommunicating = false;
        //            UpdateControls();
        //            MessageBox.Show("Conexão perdida!\nVerifique se o aparelho está conectado ao computador ou ligado e tente novamente!", "Conexão",
        //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            //Application.Restart();
        //        }
        //    }
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (btConnect.Text == "Desconectar") btConnect_Click(null, null);
            if (serial == null)
            {
                Application.Exit();
            }
            else
            {
                Command89();
                Process.GetCurrentProcess().Kill();
            }
        }

        #endregion

        #region Connection

        private void UpdateComboBox(bool notConn = false)
        {
            cbPorts.Items.Clear();
            cbPorts.Text = "";

            var available = SerialPort.GetPortNames();
            if (available.Count() > 0)
            {
                foreach (string s in available)
                    cbPorts.Items.Add(s);
                cbPorts.SelectedIndex = 0;
            }
            if (cbPorts.Items.Count == 1)
            {
                if (!notConn)
                    btConnect_Click(null, null);
            }
        }

        private void btUpdatePorts_Click(object sender, EventArgs e)
        {
            UpdateComboBox(true);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serial.Close();
                isConnected = false;
                isCommunicating = false;
                UpdateControls();
                return;
            }
            else
            {
                try
                {
                    serial = new SerialPort(cbPorts.Items[cbPorts.SelectedIndex].ToString(),
                        19200, Parity.None, 8);
                    serial.DtrEnable = true;
                    serial.RtsEnable = false;
                    serial.ReadBufferSize = 50000;
                    serial.WriteBufferSize = 50000;
                    serial.Open();

                    isConnected = true;
                    UpdateControls();

                    Thread t = new Thread(Reading);
                    t.Start();
                }
                catch
                {
                    MessageBox.Show("Erro ao tentar abrir a porta selecionada", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Communication

        private void Reading()
        {
            while (isConnected)
            {
                try
                {
                    while (serial.IsOpen && serial.BytesToRead > 0)
                    {
                        var read = serial.BytesToRead;
                        var buff = new byte[read];
                        serial.Read(buff, 0, read);
                        Received.AddRange(buff.ToList());

                        DecipherAnswer();
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro na comunicação com o aparelho.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btConnect_Click(null, null);
                    Invoke((Action)delegate { UpdateComboBox(true); });
                }
            }
        }

        private void DecipherAnswer()
        {
            if (Received[0] == 170)
            {
                byte[] send = new byte[1] { 170 };
                serial.Write(send, 0, 1);

                isCommunicating = true;
                Received.Clear();

                UpdateControls();

                // Requisita a identificação da máquina, o thread ajuda a reduzir os falsos erros
                new Thread(() => { btCommand134(); }).Start();
                new Thread(() => { Thread.Sleep(500); Command130(); Thread.Sleep(500); Command128(); }).Start();
                // new Thread(() => { Thread.Sleep(700); Command130(); }).Start();
                return;
            }

            else if (Received[0] == 255)
            {
                MessageBox.Show("Conexão perdida!\nVerifique se o aparelho está conectado ao computador ou ligado e tente novamente!", "Conexão",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isCommunicating = false;
                UpdateControls();

                if (isCommunicating == false)
                {
                    CommandAA();

                    if (Received[0] == 170)
                    {
                        Thread.Sleep(1500);
                        isCommunicating = true;
                    }
                }
            }


            this.Invoke((Action)delegate
            {
                if (Received[0] == 128) Command80();
                else if (Received[0] == 129) Command81();
                else if (Received[0] == 130 || Received[0] == 131) Command82();
                else if (Received[0] == 132) Command84();
                else if (Received[0] == 134) Command86();
            });
        }

        private void Command80()
        {
            if (Received.Count != 8)
                return;

            if (!CheckSum(80))
                return;

            List<string> Write = new List<string>();
            Write = BitConverter.ToString(Received.ToArray()).Split('-').ToList();
            switch (Write[6])
            {
                case "01":
                    Write[6] = "Dom.";
                    break;
                case "02":
                    Write[6] = "Seg.";
                    break;
                case "03":
                    Write[6] = "Ter.";
                    break;
                case "04":
                    Write[6] = "Qua.";
                    break;
                case "05":
                    Write[6] = "Qui.";
                    break;
                case "06":
                    Write[6] = "Sex.";
                    break;
                case "07":
                    Write[6] = "Sab.";
                    break;
                default:
                    break;
            }

            //  string data = string.Format("{0}/{1}/20{2}", Write[3], Write[4], Write[5]);
            //  string hora = string.Format("{0}:{1}", Write[2], Write[1]);

            string dataHora = string.Format("{0}/{1}/20{2} {3}:{4}", Write[3], Write[4], Write[5], Write[2], Write[1]);

            if (dataHora != DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
            {
                if (MessageBox.Show("O horário do equipamento difere do horário do computador!\nDeseja corrigi-lo?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Command81();
                }
                else
                {
                    lblDataEquip.Text = dataHora;
                }
            }
            else
            {
                lblDataEquip.Text = dataHora;
            }


            //  int semana = Convert.ToInt32(Received[6]) - 1;

            //formCalendario.cbSemana.SelectedIndex = semana;
            //formCalendario.txtData.Text = data;
            //formCalendario.txtHorario.Text = hora;

            EndCommand();
        }

        private void Command129()
        {
            List<string> values = new List<string>();


            Commands81.Clear();

            Commands81.Add(129);
            try
            {
                foreach (string s in values)
                    Commands81.Add(Convert.ToByte(s, 16));
            }
            catch
            { return; }

            WriteCommand(Commands81);
        }

        private void Command82()
        {
            if (Received.Count < 3) return;
            int numReceived = Received[1] * 255 + Received[2] + 4;

            // Recebe a resposta em +- 4 pacotes diferentes
            if (Received.Count != numReceived)
                return;

            if (!CheckSum(82))
                return;

            int _LoteAnterior = Convert.ToInt32(Received[3] * 255 + Received[4]);
            if (LoteAnterior == _LoteAnterior && Received[0] == 131) isUltimoLote = true;
            else
            {
                isUltimoLote = false;
                LoteAnterior = _LoteAnterior;
            }
            if (Received[0] == 130) isFirst = false;

            int NumRegistro = Convert.ToInt32(Received[5] * 255 + Received[6]);
            int NumLote = Convert.ToInt32(Received[7]);
            string Calendario = GetDate(new List<byte>() { Received[8], Received[9], Received[10], Received[11] });

            Lote novoLote = new Lote();
            novoLote.Maquina = CurrentMachine;
            novoLote.NumLote = NumLote;
            novoLote.NumeroLeit = NumRegistro;
            novoLote.Calendario = Calendario;
            if (Received[0] == 130) novoLote.Endereco = 65536;
            else novoLote.Endereco = Convert.ToInt32(lastCommand[1] * 255 + lastCommand[2]);
            lote = novoLote;

            lbCalendario.Text = Calendario;
            lbLote.Text = NumLote.ToString();
            lbNumero.Text = NumRegistro.ToString();
            if (isUltimoLote) lbAnterior.Text = "--";
            else lbAnterior.Text = LoteAnterior.ToString();

            Received.RemoveRange(0, 15);

            List<Leitura> list = new List<Leitura>();
            listView.Items.Clear();
            for (int i = 0; i < NumRegistro; i++)
            {
                try
                {

                    List<byte> data = new List<byte>();
                    data.Add(Received[i * 8 + 0]);
                    data.Add(Received[i * 8 + 1]);
                    data.Add(Received[i * 8 + 2]);
                    data.Add(Received[i * 8 + 3]);


                    string writeData = GetDate(data);
                    string escala = Received[i * 8 + 4].ToString();
                    string temperatura = Received[i * 8 + 5].ToString();
                    string leitura = (Received[i * 8 + 6] * 255 + Received[i * 8 + 7]).ToString();

                    Leitura itemLeitura = new Leitura();
                    itemLeitura.Maquina = CurrentMachine;
                    itemLeitura.Lote = NumLote;
                    itemLeitura.LoteCal = Calendario;
                    itemLeitura.Calendario = writeData.Remove(Calendario.Length - 3);
                    itemLeitura.TipoMadeira = GetTipo(Convert.ToInt32(escala));
                    itemLeitura.Temperatura = Convert.ToInt32(temperatura) * 5 + 10;
                    itemLeitura.Densidade = (Convert.ToInt32(escala) * 5 + 20) * 10;
                    itemLeitura.ValorLeitura = Convert.ToInt32(leitura);
                    list.Add(itemLeitura);
                }
                catch { }

            }
            listaLeituras = list;

            if (Firebird.LoteExists(lote))
            {
                lbExistente.Text = "Lote já Salvo";
            }
            else
            {
                lbExistente.Text = "Novo Lote";
            }

            WriteLeituras();
            SalvarLote();
            EndCommand();
        }

        private void Command84()
        {
            List<string> Write = new List<string>();
            Write = BitConverter.ToString(Received.ToArray()).Split('-').ToList();
            string data = string.Format("{0}/{1}/20{2}", Write[1], Write[2], Write[3]);

            CurrentCalib = data;

            lbCalibracao.Text = CurrentCalib;

        }
        private void Command81()
        {
            // retirado por enquanto, para ser feito mais tarde
            //if (Received.Count != 2) return;
            //var checksum = 0;
            //for (var i = 1; i < Commands81.Count; i++)
            //{
            //checksum ^= Commands81[i];
            //string Horario = DateTime.Now.ToShortTimeString();
            //string Data = DateTime.Now.ToShortDateString();
            //string Dia = DateTime.Now.DayOfWeek.ToString();
            //int DiaIndex = 0;

            //switch (Dia)
            //{
            //    case "Dom.":
            //        DiaIndex = 0;
            //        break;
            //    case "Seg.":
            //        DiaIndex = 1;
            //        break;
            //    case "Ter.":
            //        DiaIndex = 2;
            //        break;
            //    case "Qua.":
            //        DiaIndex = 3;
            //        break;
            //    case "Qui.":
            //        DiaIndex = 4;
            //        break;
            //    case "Sex.":
            //        DiaIndex = 5;
            //        break;
            //    case "Sab.":
            //        DiaIndex = 6;
            //        break;
            //}
            //lblDataEquip.Text = Data + " " + Horario;
            //}
            //    checksum ^= Commands81[i];

            //if (Received[1] == checksum)
            //    formCalendario.sucessCommand129(true);
            //else
            //    formCalendario.sucessCommand129(false);
            //EndCommand();
        }

        private void Command86()
        {
            if (Received.Count != 4)
                return;
            List<string> lista = Firebird.ReturnListMaquina();
            List<string> temp = new List<string>();
            for (int i = 1; i < 4; i++)
            {
                temp.Add(Received[i].ToString().PadLeft(2, '0'));
            }
            CurrentMachine = string.Format("{0}{1}-{2}", temp[0], temp[1], temp[2]);
            CurrentDescription = Firebird.ReturnCurrentDescription(CurrentMachine);
            lbMaquina.Text = CurrentDescription + $" ({CurrentMachine})";
            EndCommand();

            bool Exists = false;
            foreach (var item in lista)
            {
                if (item == CurrentMachine)
                {
                    Exists = true;
                    break;
                }
            }

            if (!Exists)
            {
                DialogResult result = MessageBox.Show("Nova máquina conectada, deseja salvá-la?", "Aviso", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NovaMaquina form = new NovaMaquina(this);
                    form.ShowDialog();
                }
            }
            else
            {
                CurrentDescription = Firebird.ReturnCurrentDescription(CurrentMachine);
            }
        }

        public void Command89()
        {
            var send = new List<byte>() { 137 };
            WriteCommand(send);
        }
        public void CommandAA()
        {
            var sendAgain = new List<byte>() { 170 };
            WriteCommand(sendAgain);
        }

        private string GetDate(List<byte> list)
        {
            try
            {
                var binData = string.Empty;
                foreach (var item in list)
                {
                    binData += Convert.ToString(item, 2).PadLeft(8, '0');
                }

                var ano = (Convert.ToInt32(binData.Substring(0, 7), 2) - 20) + 2000;
                var mes = Convert.ToInt32(binData.Substring(7, 4), 2);
                var dia = Convert.ToInt32(binData.Substring(11, 5), 2);

                var hora = Convert.ToInt32(binData.Substring(16, 5), 2);
                var minutos = Convert.ToInt32(binData.Substring(21, 6), 2);
                var segundos = Convert.ToInt32(binData.Substring(27, 5), 2) / 2;

                string DataInicio = (new DateTime(ano, mes, dia, hora, minutos, segundos)).ToString().TrimEnd();

                return DataInicio;

            }
            catch
            {
                MessageBox.Show($"Data da leitura está inválida!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return lbCalendario.Text = "Data inválida";
            }
        }

        private string GetTipo(int i)
        {
            string s = string.Empty;
            switch ((i + 1).ToString())
            {
                case "1":
                    s = "Dura";
                    break;
                case "2":
                    s = "Média";
                    break;
                case "3":
                    s = "Mole";
                    break;
                case "4":
                    s = "Grupo I";
                    break;
                case "5":
                    s = "Grupo II";
                    break;
                case "6":
                    s = "Grupo III";
                    break;
                case "7":
                    s = "Grupo IV";
                    break;
                case "8":
                    s = "Jatobá e Sucupira";
                    break;
                case "9":
                    s = "Pinus Eliotti";
                    break;
                case "10":
                    s = "Pau-Marfim";
                    break;
                case "11":
                    s = "Cumaru e Tauari";
                    break;
                case "12":
                    s = "Freijó";
                    break;
                case "13":
                    s = "Cedro";
                    break;
                case "14":
                    s = "Guatambu";
                    break;
                case "15":
                    s = "Goiabão";
                    break;
                case "16":
                    s = "Ipê";
                    break;
                case "17":
                    s = "Angelim";
                    break;
                case "18":
                    s = "Pinus Patula";
                    break;
                case "19":
                    s = "Imbuia";
                    break;
                case "20":
                    s = "Eucalyptus Urophylla";
                    break;
                case "21":
                    s = "Eucalyptus Grandis";
                    break;
                case "22":
                    s = "Mogno";
                    break;
            }

            return s;
        }

        public void EndCommand()
        {
            isReceivedAnswer = true;
            Reconn.Restart();
            numErrors = 0;
            lbErros.Text = "Erros: ";
            Received.Clear();
        }

        public void WriteLeituras()
        {
            if (listaLeituras.Count != lote.NumeroLeit)
            {
                MessageBox.Show("Ocorreu um erro ao puxar as leituras do lote " + lote.NumLote + "\n" + listaLeituras.Count + "*" + lote.NumeroLeit, "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lote.NumeroLeit > 0)
            {
                listaLeituras = listaLeituras.OrderBy(c => c.Id).ToList();

                lbCalendario.Text = lote.Calendario;
                lbLote.Text = lote.NumLote.ToString();
                lbNumero.Text = lote.NumeroLeit.ToString();

                int min = 1000;
                int medio = 0;
                int max = 0;

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

                    if (b.ValorLeitura < min) min = b.ValorLeitura;
                    if (b.ValorLeitura > max) max = b.ValorLeitura;
                    medio += b.ValorLeitura;
                }
                listView.Items.Clear();
                listView.Items.AddRange(toAdd.ToArray());

                lote.Min = min;
                lote.Medio = medio / listaLeituras.Count;
                lote.Max = max;
                WriteValues(min, medio / listaLeituras.Count, max);
            }
            else
            {
                MessageBox.Show("O lote não contém leituras ou está com alguma informação incorreta!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

        }

        private void WriteValues(int min, int medio, int max)
        {
            string Min = min.ToString();
            Min = Min.Insert(Min.Length - 1, ",").PadLeft(4, '0');

            string Medio = medio.ToString();
            Medio = Medio.Insert(Medio.Length - 1, ",").PadLeft(4, '0');

            string Max = max.ToString();
            Max = Max.Insert(Max.Length - 1, ",").PadLeft(4, '0');

            Invoke((Action)delegate
            {
                lbMin.Text = Min;
                lbMedio.Text = Medio;
                lbMax.Text = Max;
            });
        }

        #endregion

        #region Buttons

        // Retirado pois puxa o lote atual automaticamente
        //private void btCommand130_Click(object sender, EventArgs e)
        //{
        //    //if (serial == null || !serial.IsOpen)
        //    //{
        //    //    MessageBox.Show("Por favor, conecte com a máquina!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    return;
        //    //}
        //    var send = new List<byte>() { 130 };

        //    WriteCommand(send);


        //}

        private void btCommand131_Click(object sender, EventArgs e)
        {
            // Retirado pois o botão só fica disponivel se já estiver conectado ao equipamento, o que torna esse 'if' desnecessário
            //if (serial == null || !serial.IsOpen)
            //{
            //    MessageBox.Show("Por favor, conecte com a máquina!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (isUltimoLote)
            {
                MessageBox.Show("Não há mais nenhum lote disponível.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isFirst)
            {
                MessageBox.Show("Por favor, faça a leitura do lote atual.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = LoteAnterior;
            byte first = Convert.ToByte(i / 255);
            byte second = Convert.ToByte(i % 255);

            byte[] send = new byte[3] { 131, first, second };

            WriteCommand(send.ToList());
        }

        private void btCommand134()
        {
            var send = new List<byte>() { 134 };

            WriteCommand(send);
        }


        private void Command128()
        {
            var send = new List<byte>() { 128 };
            WriteCommand(send);
        }

        private void Command130()
        {
            var send = new List<byte>() { 130 };
            WriteCommand(send);
        }

        private void Command132()
        {
            var send = new List<byte>() { 132 };
            WriteCommand(send);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (isWaitingAnswer) return;

            if (serial == null || !serial.IsOpen)
            {
                Application.Exit();
            }
            else
            {
                Command89();
                Process.GetCurrentProcess().Kill();
            }
        }

        public void WriteCommand(List<byte> list)
        {
            try
            {
                if (isWaitingAnswer) return;

                lastCommand.Clear();
                lastCommand.AddRange(list);

                serial.Write(list.ToArray(), 0, list.Count);
                isReceivedAnswer = false;
                CheckTimeout();
            }
            catch
            {
                // foi colocado try/catch para não dar nenhuma exception 
                // caso não tenha nenhuma porta conectada e/ou o usuário 
                // desconectou antes de fechar o programa
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (CurrentUser.IsAdmin != 1)
            {
                btnReset.Enabled = false;
                return;
            }
            else
            {
                btnReset.Enabled = true;

                if (MessageBox.Show("Tem certeza que deseja Resetar o Banco de Dados?\nAo resetar o banco perderá todos os dados já salvos nele.\nSó clique em 'Sim' se tiver " +
                   "certeza dessa ação!", "Tem Certeza?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Feito 3 funções para não dar erro em nenhuma exclusão
                    Firebird.ResetLote();
                    Firebird.ResetMaquina();
                    Firebird.ResetUsuario();
                    MessageBox.Show("Resetado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    //Application.Restart();
                }
                else
                {
                    return;
                }

            }
        }

        #endregion

        #region Database

        // Retirado pois agora salva de modo automático
        //private void btSalvarLote_Click(object sender, EventArgs e)
        //{
        //    if (lote == null || listaLeituras.Count == 0) return;
        //    if (!Firebird.UserHasPermission(0)) return;

        //    var lista = Firebird.ReturnListMaquina();
        //    bool Exists = false;
        //    foreach (var item in lista)
        //    {
        //        if (item == CurrentMachine)
        //        {
        //            Exists = true;
        //            break;
        //        }
        //    }

        //    if (!Exists)
        //    {
        //        DialogResult result = MessageBox.Show("Máquina não registrada, deseja salvá-la?", "Aviso", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            NovaMaquina form = new NovaMaquina(this);
        //            form.ShowDialog();

        //            if (!form.MachineSaved) return;
        //        }
        //        else return;
        //    }

        //    lote.Usuario = CurrentUser.UserName;
        //    Firebird.SaveNewLote(lote);
        //    Firebird.SaveLeituras(listaLeituras);

        //    MessageBox.Show("Lote salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    lbExistente.Text = "Lote Salvo!";

        //    btSalvarLote.Enabled = false;
        //}
        public void SalvarLote()
        {
            if (lote == null || listaLeituras.Count == 0) return;
            if (!Firebird.UserHasPermission(0)) return;

            if (!Firebird.LoteExists(lote))
            {
                var lista = Firebird.ReturnListMaquina();
                bool Exists = false;
                foreach (var item in lista)
                {
                    if (item == CurrentMachine)
                    {
                        Exists = true;
                        break;
                    }
                }

                if (!Exists)
                {
                    DialogResult result = MessageBox.Show("Máquina não registrada, deseja salvá-la?", "Aviso", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        NovaMaquina form = new NovaMaquina(this);
                        form.ShowDialog();

                        if (!form.MachineSaved) return;
                    }
                    else return;
                }

                lote.Usuario = CurrentUser.UserName;
                Firebird.SaveNewLote(lote);
                Firebird.SaveLeituras(listaLeituras);

                MessageBox.Show("Lote salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbExistente.Text = "Lote Salvo!";

            }
            else if (Firebird.LoteExists(lote))
            {

                if (Firebird.ReturnLeituras(lote).LastOrDefault() != Firebird.ReturnLeituras(lote).FirstOrDefault())
                {
                    Firebird.DeleteAll(lote);
                    lote.Usuario = CurrentUser.UserName;
                    Firebird.SaveNewLote(lote);
                    Firebird.SaveLeituras(listaLeituras);
                    //MessageBox.Show("Lote atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }

        }

        #endregion

        #region MenuStrip

        //private void listaDeLotesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form2 form2 = new Form2();
        //    form2.ShowDialog();
        //}

        private void listaDeMáquinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMaquinas form = new ListaMaquinas();
            form.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaUsuarios form = new ListaUsuarios();
            form.ShowDialog();

            CheckUser();
        }


        // Ocorre também de modo automático
        //private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (serial == null || !serial.IsOpen)
        //    {
        //        MessageBox.Show("É necessário conectar com a máquina", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    formCalendario = new Calendario(this);
        //    formCalendario.ShowDialog();
        //}

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUp form = new BackUp();
            form.ShowDialog();
        }

        #endregion

    }
}