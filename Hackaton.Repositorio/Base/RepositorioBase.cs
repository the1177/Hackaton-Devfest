using Hackaton.Contratos.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Repositorio.Base
{
    public class RepositorioBase<T> : IContexto, IRepositorioBase<T> where T : class
    {
        internal DbContext Contexto { get; set; }
        protected DbSet<T> DbSet { get; set; }
        public void EstablecerContexto(DbContext contexto)
        {
            if (contexto == null)
            {
                throw new ArgumentNullException("context");
            }
            this.Contexto = contexto;
            this.DbSet = this.Contexto.Set<T>();
        }

        public bool Actualizar(T entidadExistente, T entidadNueva)
        {
            this.Contexto.Entry(entidadExistente).CurrentValues.SetValues(entidadNueva);
            return true;
        }

        public bool Agregar(T entity)
        {
            this.DbSet.Add(entity);
            return true;
        }

        public void Eliminar(T entity)
        {
            this.DbSet.Remove(entity);
        }

        public List<T> ObtenerDatosPorConsulta(string sqlQuery, params object[] parametros)
        {
            var resultado = this.DbSet.SqlQuery(sqlQuery, parametros).ToList();
            return resultado;
        }

        public T Obtener(int id)
        {
            return this.DbSet.Find(id);
        }
    }
}
