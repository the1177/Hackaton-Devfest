using Hackaton.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Repositorio.Contexto
{
    public class ConexionDB : ContextoBase
    {
        public ConexionDB() : base("Conexion")
        {
        }
    }
}
