using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.DAL
{
    public class Forma
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public DateTime fechaCreado { get; set; }
        public DateTime fechaModificado { get; set; }
    }
}
