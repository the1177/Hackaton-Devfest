using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Repositorio.Base
{
    public class ContextoBase : DbContext
    {
        public ContextoBase(string nombredelaconexcion) : base(nombredelaconexcion)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(ContextoBase).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
