using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository
{
    public interface IServicioRepository: IRepository<Servicio>
    {
         IEnumerable<ServicioViewModel> GetAllServicios();

         IEnumerable<ServicioViewModel> GetServiciosByCategory(string name);

         IEnumerable<ServicioViewModel> GetServiciosByIdSupplier(int id);

          IEnumerable<ServicioViewModel> GetServiciosByUserId(int id);

          bool UpdateServicio(ServicioViewModel servicioViewModel);
    }
}