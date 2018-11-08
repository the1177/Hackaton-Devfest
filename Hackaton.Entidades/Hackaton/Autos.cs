using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Entidades.Hackaton
{
    public class Autos
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Auto { get; set; }
        public DateTime Fecha { get; set; }
        public int Multa { get; set; }
    }
}
