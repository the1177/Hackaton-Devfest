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

    public class ConfiguracionesPlacas : EntityTypeConfiguration<Placas>
    {
        public ConfiguracionesPlacas()
        {
            ToTable("Placas", "dbo");
            HasKey(p => p.Id);
            Property(p => p.PlacasAuto);
            Property(p => p.Monto);
            Property(p => p.Adeudos);
            Property(p => p.Estatus).HasColumnType("varchar").HasMaxLength(100);
            
        }
    }

    
}
