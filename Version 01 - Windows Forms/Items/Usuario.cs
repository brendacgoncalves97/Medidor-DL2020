using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_01___Windows_Forms
{
    public class Usuario
    {
        public int ID { set; get; }
        public int IsAdmin { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int CanAdd { set; get; }
        public int CanDelete { set; get; }
        public int CanAlter { set; get; }
    }
}
