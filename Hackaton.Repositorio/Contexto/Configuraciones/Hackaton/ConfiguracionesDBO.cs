using Hackaton.Entidades.Hackaton;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Repositorio.Contexto.Configuraciones.Hackaton
{
    public class ConfiguracionesAutos : EntityTypeConfiguration<Autos>
    {
        public ConfiguracionesAutos()
        {
            ToTable("Autos", "dbo");
            HasKey(r => r.Id);
            Property(r => r.Matricula);
            Property(r => r.Auto).HasColumnType("varchar").HasMaxLength(100);
            Property(r => r.Fecha);
            Property(r => r.Multa);
        }
    }
}
