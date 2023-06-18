using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.Entities
{
    public class Libro
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ISBN { get; set; }
        public bool Estado { get; set; }
    }
}
