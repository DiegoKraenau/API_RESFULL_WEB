using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;

namespace RapiSolver.Service.implementation
{
    public class RolService : IRolService
    {
        private IRolRepository rolRepository;
        public RolService(IRolRepository rolRepository)
        {
            this.rolRepository=rolRepository;
        }

        public bool Delete(int id)
        {
            return rolRepository.Delete(id);
        }

        public Rol Get(int id)
        {
            return rolRepository.Get(id);
        }

        public IEnumerable<Rol> GetAll()
        {
            return rolRepository.GetAll();
        }

        public bool Save(Rol entity)
        {
            return rolRepository.Save(entity);
        }

        public bool Update(Rol entity)
        {
            return rolRepository.Update(entity);
        }
    }
}