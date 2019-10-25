using System.Collections.Generic;
using System.Linq;
using RapiSolver.Entity;
using RapiSolver.Repository.context;

namespace RapiSolver.Repository.implementation
{
    public class ServiceCategoryRepository : IServiceCategoryRepository
    {

        private ApplicationDbContext context;

        public ServiceCategoryRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ServiceCategory Get(int id)
        {
             var result = new ServiceCategory();
            try
            {
                result = context.categories.Single(x => x.ServiceCategoryId == id);
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<ServiceCategory> GetAll()
        {
            var result = new List<ServiceCategory>();
            try
            {
                result = context.categories.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(ServiceCategory entity)
        {
              try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(ServiceCategory entity)
        {
            try{
                var category = context.categories.Single(x=>x.ServiceCategoryId == entity.ServiceCategoryId);
                category.ServiceCategoryId = entity.ServiceCategoryId;
                category.CategoryName = entity.CategoryName;
                category.CategoryDescription = entity.CategoryDescription;

                context.Update(category);
                context.SaveChanges();

            }catch(System.Exception){
                return false;
            }
            return true;
        }
    }
}