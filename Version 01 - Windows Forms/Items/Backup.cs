using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_01___Windows_Forms
{
    public class Backup
    {
        public int ID { set; get; }
        public int Ativo { set; get; }
        public int Periodo { set; get; }
        public string CaminhoBackup { set; get; }
        public string DataUltimoBackup { set; get; }
    }
}
