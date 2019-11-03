using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;

namespace RapiSolver.Service.implementation
{
    public class ServiceCategoryService : IServiceCategoryService
    {

        private IServiceCategoryRepository serviceCategoryRepository;
        public ServiceCategoryService(IServiceCategoryRepository serviceCategoryRepository)
        {
            this.serviceCategoryRepository=serviceCategoryRepository;
        }
        public bool Delete(int id)
        {
            return serviceCategoryRepository.Delete(id);
        }

        public ServiceCategory Get(int id)
        {
            return serviceCategoryRepository.Get(id);
        }

        public IEnumerable<ServiceCategory> GetAll()
        {
            return serviceCategoryRepository.GetAll();
        }

        public bool Save(ServiceCategory entity)
        {
            return serviceCategoryRepository.Save(entity);
        }

        public bool Update(ServiceCategory entity)
        {
           return serviceCategoryRepository.Update(entity);
        }
    }
}