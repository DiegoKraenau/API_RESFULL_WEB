using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;
using RapiSolver.Repository.context;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository.implementation
{
    public class ServicioRepository : IServicioRepository
    {

        private ApplicationDbContext context;

        public ServicioRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Servicio Get(int id)
        {
             var result = new Servicio();
            try
            {
                result = context.servicios.Single(x => x.ServicioId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Servicio> GetAll()
        {
           throw new System.NotImplementedException();
        }

        public IEnumerable<ServicioViewModel> GetAllServicios()
        {
            var servicios = context.servicios
                .Include (o => o.ServiceCategory)
                .OrderByDescending (o => o.ServiceCategoryId)
                .Take (10)
                .ToList ();

            return servicios.Select (o => new ServicioViewModel {
                    ServicioId = o.ServicioId,
                    Name = o.Name,
                    Description = o.Description,
                    Cost = o.Cost,
                    ServiceCategoryId=o.ServiceCategoryId,
                    CategoryName=o.ServiceCategory.CategoryName

             });
        }

        public IEnumerable<ServicioViewModel> GetServiciosByCategory(string name)
        {
            var servicios = context.servicios
                .Include (o => o.ServiceCategory)
                .OrderByDescending (o => o.ServiceCategoryId)
                .Take (10)
                .Where(o=>o.ServiceCategory.CategoryName==name)
                .ToList ();

            return servicios.Select (o => new ServicioViewModel {
                    ServicioId = o.ServicioId,
                    Name = o.Name,
                    Description = o.Description,
                    Cost = o.Cost,
                    ServiceCategoryId=o.ServiceCategoryId,
                    CategoryName=o.ServiceCategory.CategoryName

             });
        }

        public bool Save(Servicio entity)
        {
            try
            {
                entity.ServiceCategory=context.categories.Find(entity.ServiceCategoryId);
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Servicio entity)
        {
            throw new System.NotImplementedException();
        }
    }
}