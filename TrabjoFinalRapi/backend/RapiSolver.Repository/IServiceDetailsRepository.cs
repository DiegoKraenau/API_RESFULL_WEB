using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository
{
    public interface IServiceDetailsRepository: IRepository<ServiceDetails>
    {
         IEnumerable<ServiceDetailsViewModel> GetAllDetails();

         IEnumerable<ServiceDetailsViewModel> GetServicioById(int id);

          bool SaveServicio(ServiceDetailsViewModel entity);
    }
}