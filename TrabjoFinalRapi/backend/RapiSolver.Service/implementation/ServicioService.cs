using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service.implementation
{
    public class ServicioService : IServicioService
    {
        private IServicioRepository servicioRepository;
        public ServicioService(IServicioRepository servicioRepository)
        {
            this.servicioRepository=servicioRepository;
        }

        public bool Delete(int id)
        {
            return servicioRepository.Delete(id);
        }

        public Servicio Get(int id)
        {
            return servicioRepository.Get(id);
        }

        public IEnumerable<Servicio> GetAll()
        {
            return servicioRepository.GetAll();
        }

        public IEnumerable<ServicioViewModel> GetAllServicios()
        {
            return servicioRepository.GetAllServicios();
        }

        public IEnumerable<ServicioViewModel> GetServiciosByCategory(string name)
        {
            return servicioRepository.GetServiciosByCategory(name);
        }

        public IEnumerable<ServicioViewModel> GetServiciosByIdSupplier(int id)
        {
            return servicioRepository.GetServiciosByIdSupplier(id);
        }

        public IEnumerable<ServicioViewModel> GetServiciosByUserId(int id)
        {
            return servicioRepository.GetServiciosByUserId(id);
        }

        public bool Save(Servicio entity)
        {
            return servicioRepository.Save(entity);
        }

        public bool Update(Servicio entity)
        {
            return servicioRepository.Update(entity);
        }

        public bool UpdateServicio(ServicioViewModel servicioViewModel)
        {
            return servicioRepository.UpdateServicio(servicioViewModel);
        }
    }
}