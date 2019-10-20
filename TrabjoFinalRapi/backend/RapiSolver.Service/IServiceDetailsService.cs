using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service
{
    public interface IServiceDetailsService: IService<ServiceDetails>
    {
         IEnumerable<ServiceDetailsViewModel> GetAllDetails();

         IEnumerable<ServiceDetailsViewModel> GetServicioById(int id);

         bool SaveServicio(ServiceDetailsViewModel entity);
    }
}