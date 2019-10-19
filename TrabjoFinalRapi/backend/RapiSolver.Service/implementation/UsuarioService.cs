using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service.implementation
{
    public class UsuarioService : IUsuarioService
    {

        private IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository=usuarioRepository;
        }

        public bool Delete(int id)
        {
            return usuarioRepository.Delete(id);
        }

        public Usuario Get(int id)
        {
            return usuarioRepository.Get(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return usuarioRepository.GetAll();
        }

         public IEnumerable<UsuarioViewModel> GetAllUsuarios () {
            return usuarioRepository.GetAllUsuarios();
        }

        public UsuarioViewModel getLoginUsuario(string name, string password)
        {
            return usuarioRepository.getLoginUsuario(name,password);
        }

        public bool Save(Usuario entity)
        {
            return usuarioRepository.Save(entity);
        }

        public bool Update(Usuario entity)
        {
            return usuarioRepository.Update(entity);
        }

       
    }
}