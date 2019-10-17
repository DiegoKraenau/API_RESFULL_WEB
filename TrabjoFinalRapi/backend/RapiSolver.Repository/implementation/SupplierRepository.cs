using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;
using RapiSolver.Repository.context;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository.implementation
{
    public class SupplierRepository : ISupplierRepository
    {
        
        private ApplicationDbContext context;

        public SupplierRepository (ApplicationDbContext context) {
            this.context = context;
        }


        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Supplier Get(int id)
        {
           var result = new Supplier();
            try
            {
                result = context.suppliers.Find(id);
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Supplier> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SupplierViewModel> GetAllSuppliers()
        {
           var suppliers = context.suppliers
                .Include (o => o.Usuario)
                .Include(o=>o.Location)
                .OrderByDescending (o => o.SupplierId)
                .Take (10)
                .ToList ();

            return suppliers.Select (o => new SupplierViewModel {
                    SupplierId = o.SupplierId,
                    Name = o.Name,
                    LastName = o.LastName,
                    Email = o.Email,
                    Phone=o.Phone,
                    Age=o.Age,
                    Genger=o.Genger,
                    UsuarioId=o.UsuarioId,
                    LocationId=o.LocationId,
                    UserName=o.Usuario.UserName,
                    Country=o.Location.Country,
                //    ServiciosDetails=context.serviceDetails.ToList() No se puede pasar listas al json
             });
        }

        public bool Save(Supplier entity)
        {
             try
            {
                entity.Location=context.locations.Find(entity.LocationId);
                entity.Usuario=context.usuarios.Find(entity.UsuarioId);
              //  entity.ServiciosDetails=context.serviceDetails.Where(y=>y.SupplierId==entity.SupplierId).ToList();
                
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Supplier entity)
        {
            throw new System.NotImplementedException();
        }
    }
}