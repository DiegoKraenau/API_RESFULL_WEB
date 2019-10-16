using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service
{
    public interface IServicioService: IService<Servicio>
    {
         IEnumerable<ServicioViewModel> GetAllServicios();

         IEnumerable<ServicioViewModel> GetServiciosByCategory(string name);
    }
}