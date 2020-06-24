using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_01___Windows_Forms
{
    public class Lote
    {
        public int Id { set; get; }
        public string Maquina { set; get; }
        public string Usuario { set; get; }
        public int NumLote { set; get; }
        public int NumeroLeit { set; get; }
        public string Calendario { set; get; }
        public double Min { set; get; }
        public double Medio { set; get; }
        public double Max { set; get; }
        public int Endereco { set; get; }
    }
}
