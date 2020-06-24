using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_01___Windows_Forms
{
    public class Configuration
    {
        public int ID { set; get; }
        public int ListMin { set; get; }
        public int ListMax { set; get; }
        public string ListMinColor { set; get; }
        public string ListMaxColor { set; get; }
        public int GraphValues { set; get; }
        public int GraphMedio { set; get; }
        public int GraphMin { set; get; }
        public int GraphMax { set; get; }
        public string GraphValuesColor { set; get; }
        public string GraphMedioColor { set; get; }
        public string GraphMinColor { set; get; }
        public string GraphMaxColor { set; get; }
        public string GraphLeiturasColor { set; get; }
        public string LastUser { set; get; }
    }
}
