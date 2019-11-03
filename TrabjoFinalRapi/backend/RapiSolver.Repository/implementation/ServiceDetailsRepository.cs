using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;
using RapiSolver.Repository.context;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository.implementation
{
    public class ServiceDetailsRepository : IServiceDetailsRepository
    {

        private ApplicationDbContext context;

        public ServiceDetailsRepository (ApplicationDbContext context) {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ServiceDetails Get(int id)
        {
            var result = new ServiceDetails();
            try
            {
                result = context.serviceDetails.Find(id);
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<ServiceDetails> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ServiceDetailsViewModel> GetAllDetails()
        {
            var details = context.serviceDetails
                .Include (o => o.Supplier)
                .Include(o=>o.Supplier.Location)
                .Include(o=>o.Supplier.Usuario)
                .Include(o=>o.Servicio)
                .Include(o=>o.Servicio.ServiceCategory)
                .OrderByDescending (o => o.ServiceDetailsId)
                .Take (10)
                .ToList ();

            return details.Select (o => new ServiceDetailsViewModel {
                    ServiceDetailsId = o.ServiceDetailsId,
                    SupplierId = o.SupplierId,
                    ServicioId = o.ServicioId,
                    Name = o.Supplier.Name,
                    LastName=o.Supplier.LastName,
                    Email=o.Supplier.Email,
                    Phone=o.Supplier.Phone,
                    Age=o.Supplier.Age,
                    Genger=o.Supplier.Genger,
                    UsuarioId=o.Supplier.Usuario.UsuarioId,
                    LocationId=o.Supplier.Location.LocationId,
                    UserName=o.Supplier.Usuario.UserName,
                    Country=o.Supplier.Location.Country,
                    ServiceName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Name,
                    Description=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Description,
                    Cost=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Cost,
                    ServiceCategoryId=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategoryId,
                    CategoryName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategory.CategoryName
             });
        }

        public IEnumerable<ServiceDetailsViewModel> GetServicioById(int id)
        {

            var details = context.serviceDetails
                .Include (o => o.Supplier)
                .Include(o=>o.Supplier.Location)
                .Include(o=>o.Supplier.Usuario)
                .Include(o=>o.Servicio)
                .Include(o=>o.Servicio.ServiceCategory)
                .OrderByDescending (o => o.ServiceDetailsId)
                .Take (10)
                .Where(o=>o.ServicioId==id)
                .ToList ();

            return details.Select (o => new ServiceDetailsViewModel {
                    ServiceDetailsId = o.ServiceDetailsId,
                    SupplierId = o.SupplierId,
                    ServicioId = o.ServicioId,
                    Name = o.Supplier.Name,
                    LastName=o.Supplier.LastName,
                    Email=o.Supplier.Email,
                    Phone=o.Supplier.Phone,
                    Age=o.Supplier.Age,
                    Genger=o.Supplier.Genger,
                    UsuarioId=o.Supplier.Usuario.UsuarioId,
                    LocationId=o.Supplier.Location.LocationId,
                    UserName=o.Supplier.Usuario.UserName,
                    Country=o.Supplier.Location.Country,
                    ServiceName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Name,
                    Description=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Description,
                    Cost=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Cost,
                    ServiceCategoryId=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategoryId,
                    CategoryName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategory.CategoryName
             });
        }

        public IEnumerable<ServiceDetailsViewModel> GetServiciosByLowCost()
        {
              var details = context.serviceDetails
                .Include (o => o.Supplier)
                .Include(o=>o.Supplier.Location)
                .Include(o=>o.Supplier.Usuario)
                .Include(o=>o.Servicio)
                .Include(o=>o.Servicio.ServiceCategory)
                .OrderBy (o => o.Servicio.Cost)
                .ToList ();

            return details.Select (o => new ServiceDetailsViewModel {
                    ServiceDetailsId = o.ServiceDetailsId,
                    SupplierId = o.SupplierId,
                    ServicioId = o.ServicioId,
                    Name = o.Supplier.Name,
                    LastName=o.Supplier.LastName,
                    Email=o.Supplier.Email,
                    Phone=o.Supplier.Phone,
                    Age=o.Supplier.Age,
                    Genger=o.Supplier.Genger,
                    UsuarioId=o.Supplier.Usuario.UsuarioId,
                    LocationId=o.Supplier.Location.LocationId,
                    UserName=o.Supplier.Usuario.UserName,
                    Country=o.Supplier.Location.Country,
                    ServiceName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Name,
                    Description=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Description,
                    Cost=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Cost,
                    ServiceCategoryId=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategoryId,
                    CategoryName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategory.CategoryName
             });
        }

        public IEnumerable<ServiceDetailsViewModel> GetServiciosByLowCostAndName(string nombre)
        {
            var details = context.serviceDetails
                .Include (o => o.Supplier)
                .Include(o=>o.Supplier.Location)
                .Include(o=>o.Supplier.Usuario)
                .Include(o=>o.Servicio)
                .Include(o=>o.Servicio.ServiceCategory)
                .OrderBy (o => o.Servicio.Cost)
                .Where(o=>o.Servicio.Name==nombre)
                .ToList ();

            return details.Select (o => new ServiceDetailsViewModel {
                    ServiceDetailsId = o.ServiceDetailsId,
                    SupplierId = o.SupplierId,
                    ServicioId = o.ServicioId,
                    Name = o.Supplier.Name,
                    LastName=o.Supplier.LastName,
                    Email=o.Supplier.Email,
                    Phone=o.Supplier.Phone,
                    Age=o.Supplier.Age,
                    Genger=o.Supplier.Genger,
                    UsuarioId=o.Supplier.Usuario.UsuarioId,
                    LocationId=o.Supplier.Location.LocationId,
                    UserName=o.Supplier.Usuario.UserName,
                    Country=o.Supplier.Location.Country,
                    ServiceName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Name,
                    Description=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Description,
                    Cost=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Cost,
                    ServiceCategoryId=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategoryId,
                    CategoryName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategory.CategoryName
             });
        }

        public IEnumerable<ServiceDetailsViewModel> GetServiciosByNombre(string nombre)
        {
               var details = context.serviceDetails
                .Include (o => o.Supplier)
                .Include(o=>o.Supplier.Location)
                .Include(o=>o.Supplier.Usuario)
                .Include(o=>o.Servicio)
                .Include(o=>o.Servicio.ServiceCategory)
                .OrderByDescending (o => o.ServiceDetailsId)
                .Where(o=>o.Servicio.Name==nombre)
                .ToList ();

            return details.Select (o => new ServiceDetailsViewModel {
                    ServiceDetailsId = o.ServiceDetailsId,
                    SupplierId = o.SupplierId,
                    ServicioId = o.ServicioId,
                    Name = o.Supplier.Name,
                    LastName=o.Supplier.LastName,
                    Email=o.Supplier.Email,
                    Phone=o.Supplier.Phone,
                    Age=o.Supplier.Age,
                    Genger=o.Supplier.Genger,
                    UsuarioId=o.Supplier.Usuario.UsuarioId,
                    LocationId=o.Supplier.Location.LocationId,
                    UserName=o.Supplier.Usuario.UserName,
                    Country=o.Supplier.Location.Country,
                    ServiceName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Name,
                    Description=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Description,
                    Cost=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.Cost,
                    ServiceCategoryId=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategoryId,
                    CategoryName=context.serviceDetails.Find(o.ServiceDetailsId).Servicio.ServiceCategory.CategoryName
             });
        }

        public bool Save(ServiceDetails entity)
        {
             try
            {
                
                entity.Servicio=context.servicios.Find(entity.ServicioId);
                entity.Supplier=context.suppliers.Find(entity.SupplierId);
                
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool SaveServicio(ServiceDetailsViewModel entity)
        {
            try
            {
               

                ServiceCategory sc1=new ServiceCategory();
                sc1=context.categories.Single(o=>o.CategoryName==entity.CategoryName);

                Servicio s1=new Servicio();
                s1.Cost=entity.Cost;
                s1.Description=entity.Description;
                s1.Name=entity.ServiceName;
                s1.ServiceCategoryId=sc1.ServiceCategoryId;
                s1.ServiceCategory=sc1;

                context.Add(s1);
                context.SaveChanges();

                ServiceDetails sv1=new ServiceDetails();
                sv1.SupplierId=entity.SupplierId;
                sv1.Supplier=context.suppliers.Find(entity.SupplierId);
                sv1.ServicioId=context.servicios.OrderByDescending (o => o.ServicioId).First().ServicioId;
                sv1.Servicio=s1;

                context.Add(sv1);
     
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(ServiceDetails entity)
        {
            throw new System.NotImplementedException();
        }
    }
}