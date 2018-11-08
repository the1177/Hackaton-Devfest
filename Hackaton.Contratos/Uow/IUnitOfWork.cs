using Hackaton.Contratos.Negocio;
using Hackaton.Contratos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Contratos.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IAutosRepositorio autosRepositorio { get;  }
        IPlacasRepositorio placasRepositorio { get; }
        void Guardar();
    }
}
