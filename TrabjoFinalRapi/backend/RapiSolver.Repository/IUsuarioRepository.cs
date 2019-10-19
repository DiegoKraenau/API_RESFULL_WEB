using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        IEnumerable<UsuarioViewModel> GetAllUsuarios();
        UsuarioViewModel getLoginUsuario(string name,string password);
    }
}