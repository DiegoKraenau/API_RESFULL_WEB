using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service
{
    public interface IUsuarioService : IService<Usuario>
    {
         IEnumerable<UsuarioViewModel> GetAllUsuarios();
    }
}