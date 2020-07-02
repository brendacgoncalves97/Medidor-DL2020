using System;
using System.Collections.Generic;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace Version_01___Windows_Forms
{
    public class Firebird
    {
        public static string Conn
        {
            get
            {
                try
                {
                    //Arquivo não existe no caminho especificado.
                    if (File.Exists(Environment.CurrentDirectory + "\\DL2020.fdb"))
                    {
#if DEBUG
                        //REMOTO , para desenvolvimento, permite mais de uma conexão. Para utilizar com Flame Robin.
                        return "ServerType=0;Database=" + Environment.CurrentDirectory + "\\DL2020.fdb; User=SYSDBA;Password=masterkey;Dialect=3";
#endif

                        //EMBARCADO | para o Instalador.
                        // return "Database=" + Environment.CurrentDirectory + "\\DL2020.fdb; User=SYSDBA;Password=masterkey;Dialect=3";
                    }
                    return null;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool OnlyConnect()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        return true;
                    }
                    catch
                    {
                        // System.Exception: 'arithmetic exception, numeric overflow, or string truncation string right truncation'
                    }
                }
            }
            return false;
        }

        #region Lotes

        public static bool SaveNewLote(Lote lote)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                try
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        // Qual tabela
                        cmd.CommandText = "INSERT INTO LOTES (";

                        // Colunas
                        cmd.CommandText += "NUMLOTE, ";
                        cmd.CommandText += "MAQUINA, ";
                        cmd.CommandText += "USUARIO, ";
                        cmd.CommandText += "NUMEROLEIT, ";
                        cmd.CommandText += "CALENDARIO, ";
                        cmd.CommandText += "ENDERECO, ";
                        cmd.CommandText += "MINIMO, ";
                        cmd.CommandText += "MEDIO, ";
                        cmd.CommandText += "MAXIMO) ";

                        // Valores
                        cmd.CommandText += "VALUES (";

                        cmd.CommandText += "@NUMLOTE, ";
                        cmd.CommandText += "@MAQUINA, ";
                        cmd.CommandText += "@USUARIO, ";
                        cmd.CommandText += "@NUMEROLEIT, ";
                        cmd.CommandText += "@CALENDARIO, ";
                        cmd.CommandText += "@ENDERECO, ";
                        cmd.CommandText += "@MINIMO, ";
                        cmd.CommandText += "@MEDIO, ";
                        cmd.CommandText += "@MAXIMO) ";
                        cmd.CommandText += "; ";

                        cmd.Parameters.AddWithValue("@NUMLOTE", lote.NumLote);
                        cmd.Parameters.AddWithValue("@MAQUINA", lote.Maquina);
                        cmd.Parameters.AddWithValue("@USUARIO", lote.Usuario);
                        cmd.Parameters.AddWithValue("@NUMEROLEIT", lote.NumeroLeit);
                        cmd.Parameters.AddWithValue("@CALENDARIO", lote.Calendario);
                        cmd.Parameters.AddWithValue("@ENDERECO", lote.Endereco);
                        cmd.Parameters.AddWithValue("@MINIMO", lote.Min);
                        cmd.Parameters.AddWithValue("@MEDIO", lote.Medio);
                        cmd.Parameters.AddWithValue("@MAXIMO", lote.Max);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        return true;
                    }
                }

                catch (Exception error)
                {
                    throw new Exception(error.StackTrace + "-" + error.Message);
                }
            }
        }

        public static Lote ReturnLote(string maquina, int numLote, string calendario)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        Lote lote = new Lote();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        string s = string.Format("SELECT * FROM LOTES WHERE MAQUINA = '{0}' AND NUMLOTE = '{1}' AND CALENDARIO = '{2}'",
                            maquina, numLote, calendario);
                        cmd.CommandText = s;
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lote.Id = (int)dr["ID"];
                            lote.Maquina = dr["MAQUINA"].ToString().TrimEnd();
                            lote.Usuario = dr["USUARIO"].ToString().TrimEnd();
                            lote.NumLote = (int)dr["NUMLOTE"];
                            lote.NumeroLeit = (int)dr["NUMEROLEIT"];
                            lote.Calendario = dr["CALENDARIO"].ToString().TrimEnd();
                            lote.Endereco = (int)dr["ENDERECO"];
                            lote.Min = (int)dr["MINIMO"];
                            lote.Medio = (int)dr["MEDIO"];
                            lote.Max = (int)dr["MAXIMO"];
                        }
                        dr.Close();
                        return lote;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static List<Lote> ReturnListLotes()
        {
            // List<biblioteca váriaveis>
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        List<Lote> listaLotes = new List<Lote>();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM LOTES";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Lote lote = new Lote();
                            lote.Id = (int)dr["ID"];
                            lote.Maquina = dr["MAQUINA"].ToString().TrimEnd();
                            lote.Usuario = dr["USUARIO"].ToString().TrimEnd();
                            lote.NumLote = (int)dr["NUMLOTE"];
                            lote.NumeroLeit = (int)dr["NUMEROLEIT"];
                            lote.Calendario = dr["CALENDARIO"].ToString().TrimEnd();
                            lote.Endereco = (int)dr["ENDERECO"];
                            lote.Min = (int)dr["MINIMO"];
                            lote.Medio = (int)dr["MEDIO"];
                            lote.Max = (int)dr["MAXIMO"];
                            listaLotes.Add(lote);
                        }
                        dr.Close();
                        return listaLotes;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static bool LoteExists(Lote lote)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        string s = string.Format("SELECT * FROM LOTES WHERE MAQUINA = '{0}' AND NUMLOTE = '{1}' AND CALENDARIO = '{2}'",
                            lote.Maquina, lote.NumLote, lote.Calendario);
                        cmd.CommandText = s;
                        FbDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            return true;
                        }
                        else return false;
                    }
                    catch (FbException fbError)
                    {
                        throw new Exception(fbError.Message);
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.Message);
                    }
                }
            }
        }

        public static List<int> ReturnLotes(Lote lote)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        List<int> lista = new List<int>();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM LOTES WHERE MAQUINA = " + lote.Maquina;
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lista.Add((int)dr["NUMLOTE"]);
                        }
                        dr.Close();
                        return lista;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static List<Lote> ReturnLotesFromMachine(string machine)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        List<Lote> listaLotes = new List<Lote>();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM LOTES WHERE MAQUINA = '" + machine + "'";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Lote lote = new Lote();
                            lote.Id = (int)dr["ID"];
                            lote.Maquina = dr["MAQUINA"].ToString().TrimEnd();
                            lote.Usuario = dr["USUARIO"].ToString().TrimEnd();
                            lote.NumLote = (int)dr["NUMLOTE"];
                            lote.NumeroLeit = (int)dr["NUMEROLEIT"];
                            lote.Calendario = dr["CALENDARIO"].ToString().TrimEnd();
                            lote.Endereco = (int)dr["ENDERECO"];
                            lote.Min = (int)dr["MINIMO"];
                            lote.Medio = (int)dr["MEDIO"];
                            lote.Max = (int)dr["MAXIMO"];
                            listaLotes.Add(lote);
                        }
                        dr.Close();
                        return listaLotes;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        #endregion

        #region Leituras

        public static void SaveLeituras(List<Leitura> list)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                try
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        fbConn.Open();

                        foreach (var item in list)
                        {
                            cmd.Connection = fbConn;

                            // Qual tabela
                            cmd.CommandText = "INSERT INTO LEITURAS (";

                            // Colunas
                            cmd.CommandText += "MAQUINA, ";
                            cmd.CommandText += "LOTE, ";
                            cmd.CommandText += "LOTECAL, ";
                            cmd.CommandText += "CALENDARIO, ";
                            cmd.CommandText += "TIPOMADEIRA, ";
                            cmd.CommandText += "TEMPERATURA, ";
                            cmd.CommandText += "DENSIDADE, ";
                            cmd.CommandText += "VALORLEITURA) ";

                            // Valores
                            cmd.CommandText += "VALUES (";

                            cmd.CommandText += "@MAQUINA, ";
                            cmd.CommandText += "@LOTE, ";
                            cmd.CommandText += "@LOTECAL, ";
                            cmd.CommandText += "@CALENDARIO, ";
                            cmd.CommandText += "@TIPOMADEIRA, ";
                            cmd.CommandText += "@TEMPERATURA, ";
                            cmd.CommandText += "@DENSIDADE, ";
                            cmd.CommandText += "@VALORLEITURA) ";
                            cmd.CommandText += "; ";

                            cmd.Parameters.AddWithValue("@MAQUINA", item.Maquina);
                            cmd.Parameters.AddWithValue("@LOTE", item.Lote);
                            cmd.Parameters.AddWithValue("@LOTECAL", item.LoteCal);
                            cmd.Parameters.AddWithValue("@CALENDARIO", item.Calendario);
                            cmd.Parameters.AddWithValue("@TIPOMADEIRA", item.TipoMadeira);
                            cmd.Parameters.AddWithValue("@TEMPERATURA", item.Temperatura);
                            cmd.Parameters.AddWithValue("@DENSIDADE", item.Densidade);
                            cmd.Parameters.AddWithValue("@VALORLEITURA", item.ValorLeitura);

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                    }
                }

                catch (Exception error)
                {
                    throw new Exception(error.StackTrace + "-" + error.Message);
                }
            }
        }

        public static List<Leitura> ReturnLeituras(Lote lote)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        List<Leitura> lista = new List<Leitura>();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM LEITURAS WHERE MAQUINA = '" + lote.Maquina + "' AND LOTE = '" + lote.NumLote + "' AND LOTECAL = '" + lote.Calendario + "'";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Leitura leitura = new Leitura();
                            leitura.Id = (int)dr["ID"];
                            leitura.Lote = (int)dr["LOTE"];
                            leitura.Maquina = dr["MAQUINA"].ToString().TrimEnd();
                            leitura.LoteCal = dr["LOTECAL"].ToString().TrimEnd();
                            leitura.Calendario = dr["CALENDARIO"].ToString().TrimEnd();
                            leitura.TipoMadeira = dr["TIPOMADEIRA"].ToString().TrimEnd();
                            leitura.Temperatura = (int)dr["TEMPERATURA"];
                            leitura.Densidade = (int)dr["DENSIDADE"];
                            leitura.ValorLeitura = (int)dr["VALORLEITURA"];
                            lista.Add(leitura);
                        }
                        dr.Close();
                        return lista;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        #endregion

        #region Config

        public static bool SaveConfig(Configuration config)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                try
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        config.ID = 1;
                        // Qual tabela
                        cmd.CommandText = "UPDATE OR INSERT INTO CONFIGURACOES (";

                        cmd.CommandText += "ID, ";
                        cmd.CommandText += "LISTAMIN, ";
                        cmd.CommandText += "LISTAMAX, ";
                        cmd.CommandText += "LISTAMINCOLOR, ";
                        cmd.CommandText += "LISTAMAXCOLOR, ";
                        cmd.CommandText += "GRAPHVALUES, ";
                        cmd.CommandText += "GRAPHMEDIO, ";
                        cmd.CommandText += "GRAPHMIN, ";
                        cmd.CommandText += "GRAPHMAX, ";
                        cmd.CommandText += "GRAPHVALUESCOLOR, ";
                        cmd.CommandText += "GRAPHMEDIOCOLOR, ";
                        cmd.CommandText += "GRAPHMINCOLOR, ";
                        cmd.CommandText += "GRAPHMAXCOLOR, ";
                        cmd.CommandText += "GRAPHLEITURASCOLOR, ";
                        cmd.CommandText += "LASTUSER) ";

                        cmd.CommandText += "VALUES (";
                        cmd.CommandText += "@ID, ";
                        cmd.CommandText += "@LISTAMIN, ";
                        cmd.CommandText += "@LISTAMAX, ";
                        cmd.CommandText += "@LISTAMINCOLOR, ";
                        cmd.CommandText += "@LISTAMAXCOLOR, ";
                        cmd.CommandText += "@GRAPHVALUES, ";
                        cmd.CommandText += "@GRAPHMEDIO, ";
                        cmd.CommandText += "@GRAPHMIN, ";
                        cmd.CommandText += "@GRAPHMAX, ";
                        cmd.CommandText += "@GRAPHVALUESCOLOR, ";
                        cmd.CommandText += "@GRAPHMEDIOCOLOR, ";
                        cmd.CommandText += "@GRAPHMINCOLOR, ";
                        cmd.CommandText += "@GRAPHMAXCOLOR, ";
                        cmd.CommandText += "@GRAPHLEITURASCOLOR, ";
                        cmd.CommandText += "@LASTUSER) ";

                        cmd.CommandText += "MATCHING (ID)";
                        cmd.CommandText += "; ";

                        cmd.Parameters.AddWithValue("@ID", config.ID);
                        cmd.Parameters.AddWithValue("@LISTAMIN", config.ListMin);
                        cmd.Parameters.AddWithValue("@LISTAMAX", config.ListMax);
                        cmd.Parameters.AddWithValue("@LISTAMINCOLOR", config.ListMinColor);
                        cmd.Parameters.AddWithValue("@LISTAMAXCOLOR", config.ListMaxColor);
                        cmd.Parameters.AddWithValue("@GRAPHVALUES", config.GraphValues);
                        cmd.Parameters.AddWithValue("@GRAPHMEDIO", config.GraphMedio);
                        cmd.Parameters.AddWithValue("@GRAPHMIN", config.GraphMin);
                        cmd.Parameters.AddWithValue("@GRAPHMAX", config.GraphMax);
                        cmd.Parameters.AddWithValue("@GRAPHVALUESCOLOR", config.GraphValuesColor);
                        cmd.Parameters.AddWithValue("@GRAPHMEDIOCOLOR", config.GraphMedioColor);
                        cmd.Parameters.AddWithValue("@GRAPHMINCOLOR", config.GraphMinColor);
                        cmd.Parameters.AddWithValue("@GRAPHMAXCOLOR", config.GraphMaxColor);
                        cmd.Parameters.AddWithValue("@GRAPHLEITURASCOLOR", config.GraphLeiturasColor);
                        cmd.Parameters.AddWithValue("@LASTUSER", config.LastUser);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        return true;
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return false;
                }
            }
        }

        public static Configuration ReturnConfiguration()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        Configuration config = new Configuration();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM CONFIGURACOES WHERE ID = '" + 1 + "'";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            config.ID = (int)dr["ID"];
                            config.ListMin = (int)dr["LISTAMIN"];
                            config.ListMax = (int)dr["LISTAMAX"];
                            config.ListMinColor = dr["LISTAMINCOLOR"].ToString().TrimEnd();
                            config.ListMaxColor = dr["LISTAMAXCOLOR"].ToString().TrimEnd();
                            config.GraphValues = (int)dr["GRAPHVALUES"];
                            config.GraphMedio = (int)dr["GRAPHMEDIO"];
                            config.GraphMin = (int)dr["GRAPHMIN"];
                            config.GraphMax = (int)dr["GRAPHMAX"];
                            config.GraphValuesColor = dr["GRAPHVALUESCOLOR"].ToString().TrimEnd();
                            config.GraphMedioColor = dr["GRAPHMEDIOCOLOR"].ToString().TrimEnd();
                            config.GraphMinColor = dr["GRAPHMINCOLOR"].ToString().TrimEnd();
                            config.GraphMaxColor = dr["GRAPHMAXCOLOR"].ToString().TrimEnd();
                            config.GraphLeiturasColor = dr["GRAPHLEITURASCOLOR"].ToString().TrimEnd();
                            config.LastUser = dr["LASTUSER"].ToString().TrimEnd();
                        }
                        dr.Close();
                        return config;
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
        }

        #endregion

        #region Lista Maquinas

        public static void SaveNewMachine(string machine, string description)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                try
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        // Qual tabela
                        cmd.CommandText = "INSERT INTO LISTAMAQUINAS (";

                        // Colunas                       
                        cmd.CommandText += "MAQUINA, ";
                        cmd.CommandText += "DESCRICAO)";

                        // Valores
                        cmd.CommandText += "VALUES (";

                        cmd.CommandText += "@MAQUINA, ";
                        cmd.CommandText += "@DESCRICAO)";
                        cmd.CommandText += "; ";

                        cmd.Parameters.AddWithValue("@MAQUINA", machine);
                        cmd.Parameters.AddWithValue("@DESCRICAO", description);
   
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }
                }

                catch (Exception error)
                {
                    throw new Exception(error.StackTrace + "-" + error.Message);
                }
            }
        }

        public static List<Maquina> ReturnMaquinas()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        List<Maquina> lista = new List<Maquina>();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM LISTAMAQUINAS";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Maquina item = new Maquina();
                            item.ID = (int)dr["ID"];
                            item.Nome = dr["MAQUINA"].ToString().TrimEnd();
                            item.Descricao = dr["DESCRICAO"].ToString().TrimEnd();
                            item.Quantidade = ReturnLotesFromMachine(item.Nome).Count;
                            lista.Add(item);
                        }
                        dr.Close();
                        return lista;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static List<string> ReturnListMaquina()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        List<string> lista = new List<string>();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM LISTAMAQUINAS";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lista.Add(dr["MAQUINA"].ToString().TrimEnd());
                        }
                        dr.Close();
                        return lista;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static string ReturnCurrentDescription(string maquina)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        string descricao = string.Empty;
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM LISTAMAQUINAS WHERE MAQUINA = '" + maquina + "'";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            descricao = dr["DESCRICAO"].ToString().TrimEnd();
                        }
                        dr.Close();
                        return descricao;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static string ReturnCalibracao(string calib)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        string dataCalib = string.Empty;
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = $"SELECT * FROM LISTAMAQUINAS WHERE DATACALIBRACAO = '{calib}'";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            calib = dr["DATACALIBRACAO"].ToString().TrimEnd();
                        }
                        dr.Close();
                        return calib;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static Maquina ReturnMaquina(string nome)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        Maquina maquina = new Maquina();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM LISTAMAQUINAS WHERE MAQUINA = '" + nome + "'";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            maquina.ID = (int)dr["ID"];
                            maquina.Nome = dr["MAQUINA"].ToString().TrimEnd();
                            maquina.Descricao = dr["DESCRICAO"].ToString().TrimEnd();
                        }
                        dr.Close();
                        return maquina;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static void ChangeDescription(Maquina maquina)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        string s = string.Format("UPDATE LISTAMAQUINAS SET DESCRICAO = '{0}' WHERE MAQUINA = '{1}'", maquina.Descricao, maquina.Nome);
                        cmd.CommandText = s;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        public static void ChangeDataCalibracao(Maquina maquina)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        string s = string.Format("UPDATE LISTAMAQUINAS SET DATACALIBRACAO = '{0}' WHERE MAQUINA = '{1}'", maquina.Calibracao, maquina.Nome);
                        cmd.CommandText = s;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        #endregion

        #region Deleta

        public static void DeleteAll(Lote lote)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        string s = string.Format("DELETE FROM LOTES WHERE MAQUINA = '{0}' AND NUMLOTE = '{1}' AND CALENDARIO = '{2}'",
                            lote.Maquina, lote.NumLote, lote.Calendario);
                        cmd.CommandText = s;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "DELETE FROM LEITURAS WHERE MAQUINA = '" + lote.Maquina + "' AND LOTE = '" + lote.NumLote + "' AND LOTECAL = '" + lote.Calendario + "'";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }
        public static void ResetLote()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "DELETE FROM LOTES";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        public static void DeleteMaq(string maquina)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        string s = string.Format("DELETE FROM LOTES WHERE MAQUINA = '{0}'",
                            maquina);
                        cmd.CommandText = s;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "DELETE FROM LEITURAS WHERE MAQUINA = '" + maquina + "'";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "DELETE FROM LISTAMAQUINAS WHERE MAQUINA = '" + maquina + "'";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        public static void ResetMaquina()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "DELETE FROM LISTAMAQUINAS";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        #endregion

        #region Usuarios

        public static void SaveNewUser(Usuario user)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                try
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        // Qual tabela
                        cmd.CommandText = "INSERT INTO USUARIOS (";

                        // Colunas
                        cmd.CommandText += "ISADMIN, ";
                        cmd.CommandText += "USERNAME, ";
                        cmd.CommandText += "USERPASSWORD, ";
                        cmd.CommandText += "CANADD, ";
                        cmd.CommandText += "CANDELETE, ";
                        cmd.CommandText += "CANALTER) ";

                        // Valores
                        cmd.CommandText += "VALUES (";

                        cmd.CommandText += "@ISADMIN, ";
                        cmd.CommandText += "@USERNAME, ";
                        cmd.CommandText += "@USERPASSWORD, ";
                        cmd.CommandText += "@CANADD, ";
                        cmd.CommandText += "@CANDELETE, ";
                        cmd.CommandText += "@CANALTER) ";
                        cmd.CommandText += "; ";

                        cmd.Parameters.AddWithValue("@ISADMIN", user.IsAdmin);
                        cmd.Parameters.AddWithValue("@USERNAME", user.UserName);
                        cmd.Parameters.AddWithValue("@USERPASSWORD", user.Password);
                        cmd.Parameters.AddWithValue("@CANADD", user.CanAdd);
                        cmd.Parameters.AddWithValue("@CANDELETE", user.CanDelete);
                        cmd.Parameters.AddWithValue("@CANALTER", user.CanAlter);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }

                catch (Exception error)
                {
                    throw new Exception(error.StackTrace + "-" + error.Message);
                }
            }
        }

        public static Usuario ReturnUser(string userName, string userPassword)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        Usuario usuario = new Usuario();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        string s = string.Format("SELECT * FROM USUARIOS WHERE USERNAME = '{0}' AND USERPASSWORD = '{1}'",
                            userName, userPassword);
                        cmd.CommandText = s;
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            usuario.ID = (int)dr["ID"];
                            usuario.IsAdmin = (int)dr["ISADMIN"];
                            usuario.UserName = dr["USERNAME"].ToString().TrimEnd();
                            usuario.Password = dr["USERPASSWORD"].ToString().TrimEnd();
                            usuario.CanAdd = (int)dr["CANADD"];
                            usuario.CanDelete = (int)dr["CANDELETE"];
                            usuario.CanAlter = (int)dr["CANALTER"];
                        }
                        dr.Close();
                        return usuario;
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
        }

        public static Usuario ReturnAdmin()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        Usuario usuario = new Usuario();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM USUARIOS WHERE ISADMIN = '1'";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            usuario.ID = (int)dr["ID"];
                            usuario.IsAdmin = (int)dr["ISADMIN"];
                            usuario.UserName = dr["USERNAME"].ToString().TrimEnd();
                            usuario.Password = dr["USERPASSWORD"].ToString().TrimEnd();
                            usuario.CanAdd = (int)dr["CANADD"];
                            usuario.CanDelete = (int)dr["CANDELETE"];
                            usuario.CanAlter = (int)dr["CANALTER"];
                        }
                        dr.Close();
                        return usuario;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static List<Usuario> ReturnListUsers()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        List<Usuario> lista = new List<Usuario>();
                        cmd.CommandText = "SELECT * FROM USUARIOS";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario();

                            usuario.ID = (int)dr["ID"];
                            usuario.IsAdmin = (int)dr["ISADMIN"];
                            usuario.UserName = dr["USERNAME"].ToString().TrimEnd();
                            usuario.Password = dr["USERPASSWORD"].ToString().TrimEnd();
                            usuario.CanAdd = (int)dr["CANADD"];
                            usuario.CanDelete = (int)dr["CANDELETE"];
                            usuario.CanAlter = (int)dr["CANALTER"];

                            lista.Add(usuario);
                        }
                        dr.Close();
                        return lista;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static List<string> ReturnListUsersName()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        List<string> lista = new List<string>();
                        cmd.CommandText = "SELECT * FROM USUARIOS";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lista.Add(dr["USERNAME"].ToString().TrimEnd());
                        }
                        dr.Close();
                        return lista;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static void UpdateUser(Usuario previousUser, Usuario currentUser)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        string s = string.Format("UPDATE USUARIOS SET USERNAME = '{0}', USERPASSWORD = '{1}', CANADD = '{2}'," +
                            "CANDELETE = '{3}', CANALTER = '{4}' WHERE USERNAME = '{5}' AND USERPASSWORD = '{6}'",
                            currentUser.UserName, currentUser.Password, currentUser.CanAdd, currentUser.CanDelete,
                            currentUser.CanAlter, previousUser.UserName, previousUser.Password);
                        cmd.CommandText = s;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static void DeleteUser(Usuario user)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        string s = string.Format("DELETE FROM USUARIOS WHERE USERNAME = '{0}'",
                            user.UserName);
                        cmd.CommandText = s;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static void ResetUsuario()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "DELETE FROM USUARIOS";
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static Usuario ReturnLastUser()
        {
            var lastUser = ReturnConfiguration();
            if (lastUser.LastUser == string.Empty)
            {
                return null;
            }
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        Usuario usuario = new Usuario();
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        cmd.CommandText = "SELECT * FROM USUARIOS WHERE USERNAME = '" + lastUser.LastUser + "'";
                        FbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            usuario.ID = (int)dr["ID"];
                            usuario.IsAdmin = (int)dr["ISADMIN"];
                            usuario.UserName = dr["USERNAME"].ToString().TrimEnd();
                            usuario.Password = dr["USERPASSWORD"].ToString().TrimEnd();
                            usuario.CanAdd = (int)dr["CANADD"];
                            usuario.CanDelete = (int)dr["CANDELETE"];
                            usuario.CanAlter = (int)dr["CANALTER"];
                        }
                        dr.Close();
                        return usuario;
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static void SaveLastUser(Usuario user)
        {
            var config = ReturnConfiguration();
            if (config.ID != 1)
            {
                config.ListMinColor = "#FFFF80";
                config.ListMaxColor = "#80FFFF";
                config.GraphValuesColor = "Black";
                config.GraphMedioColor = "Blue";
                config.GraphMinColor = "#FFFF80";
                config.GraphMaxColor = "#80FFFF";
                config.GraphLeiturasColor = "Red";
                SaveConfig(config);
            }
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;

                        string s = string.Format("UPDATE CONFIGURACOES SET LASTUSER = '{0}' WHERE ID = '{1}'",
                            user.UserName, config.ID);
                        cmd.CommandText = s;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    catch (Exception error)
                    {
                        throw new Exception(error.StackTrace + "-" + error.Message);
                    }
                }
            }
        }

        public static bool UserHasPermission(int request)
        {
            var user = ReturnLastUser();
            // 0 = Salvar, 1 = Deletar, 2 = Alterar
            bool toReturn = false;

            switch (request)
            {
                case 0:
                    if (user.CanAdd == 1) toReturn = true;
                    else MessageBox.Show("Você não possui permissão para salvar dados no banco de dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    if (user.CanDelete == 1) toReturn = true;
                    else MessageBox.Show("Você não possui permissão para deletar dados do banco de dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:

                    if (user.CanAlter == 1) toReturn = true;
                    else MessageBox.Show("Você não possui permissão para modificar dados do banco de dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            return toReturn;
        }

        #endregion

        #region BackUp

        public static bool SaveBackup(Backup backup)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                try
                {
                    using (FbCommand cmd = new FbCommand())
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        backup.ID = 1;
                        // Qual tabela
                        cmd.CommandText = "UPDATE OR INSERT INTO BACKUP (";

                        cmd.CommandText += "ID, ";
                        //cmd.CommandText += "ATIVO, ";
                        cmd.CommandText += "PERIODO, ";
                        cmd.CommandText += "PASTADESTINO, ";
                        cmd.CommandText += "DATAULTIMOBACKUP) ";

                        cmd.CommandText += "VALUES (";
                        cmd.CommandText += "@ID, ";
                        //   cmd.CommandText += "@ATIVO, ";
                        cmd.CommandText += "@PERIODO, ";
                        cmd.CommandText += "@PASTADESTINO, ";
                        cmd.CommandText += "@DATAULTIMOBACKUP) ";

                        cmd.CommandText += "MATCHING (ID)";
                        cmd.CommandText += "; ";

                        cmd.Parameters.AddWithValue("@ID", backup.ID);
                        //cmd.Parameters.AddWithValue("@ATIVO", backup.Ativo);
                        cmd.Parameters.AddWithValue("@PERIODO", backup.Periodo);
                        cmd.Parameters.AddWithValue("@PASTADESTINO", backup.CaminhoBackup);
                        cmd.Parameters.AddWithValue("@DATAULTIMOBACKUP", backup.DataUltimoBackup);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        return true;
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show("Erro ao salvar as informações de Backup\n" + error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static Backup RetornaBackup()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        cmd.CommandText = "SELECT * FROM BACKUP";
                        FbDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Backup backup = new Backup();
                            backup.ID = (int)dr["ID"];
                            // backup.Ativo = (int)dr["ATIVO"];
                            backup.Periodo = (int)dr["PERIODO"];
                            backup.CaminhoBackup = dr["PASTADESTINO"].ToString();
                            backup.DataUltimoBackup = dr["DATAULTIMOBACKUP"].ToString();
                            return backup;
                        }
                        dr.Close();
                        return null;
                    }
                    catch (FbException fbError)
                    {
                        MessageBox.Show($"Erro: {fbError.Message}");
                        return null;
                    }
                }
            }
        }

        public static void DeletaBackup()
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        cmd.CommandText = "DELETE FROM BACKUP";
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao deletar as configurações de back up!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        public static bool AlterarDataUltimoBackup(string data)
        {
            using (FbConnection fbConn = new FbConnection(Conn))
            {
                using (FbCommand cmd = new FbCommand())
                {
                    try
                    {
                        fbConn.Open();
                        cmd.Connection = fbConn;
                        cmd.CommandText = "UPDATE BACKUP SET DATAULTIMOBACKUP=@DATAULTIMOBACKUP WHERE ID = '"+ 1 + "'";
                        cmd.Parameters.AddWithValue("@DATAULTIMOBACKUP", data);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }

        #endregion

    }
}
