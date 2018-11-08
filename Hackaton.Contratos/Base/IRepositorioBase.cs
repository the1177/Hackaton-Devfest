using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Contratos.Base
{
    public interface IRepositorioBase<T> where T : class
    {
        T Obtener(int T);
        bool Agregar(T entity);
        void Eliminar(T entity);
        bool Actualizar(T entidadExistente, T entidadNueva);
        List<T> ObtenerDatosPorConsulta(string sqlQuery, params object[] parametros);
    }
}
